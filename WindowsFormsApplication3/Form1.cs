using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private PictureBox[] pb;
        private PictureBox[] rand_pb;
        private PictureBox[] Box;
        private int[] check;
        private int[] press;
        private int click;
        private int correct;
        private int div;
        Random r;
        int cnt;
        int[,] board;
        public Form1()
        {
            InitializeComponent();
            pb = new PictureBox[72];
            rand_pb = new PictureBox[72];
            r = new Random();
            check = new int[72];
            press = new int[72];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            board = new int[10, 11];
            div = 72;
            correct = 0;
            click = 0;
            label1.Text = Convert.ToString(correct);
            label4.Text = Convert.ToString(div) ;
            add_image();
            table_image();
            init_check();
            init_press();
            init_select();
        }

        //ㅅㅐ로 시작
        private void button1_Click(object sender, EventArgs e)
        {
            board = new int[10, 11];
            div = 72;
            correct = 0;
            click = 0;
            label1.Text = Convert.ToString(correct);
            label4.Text = Convert.ToString(div);
            add_image();
            table_image();
            init_check();
            init_press();
            image_show();
            init_select();
        }
        private void init_borad()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
        private void image_show()
        {
            for (int i = 0; i < 72; i++)
            {
                Box[i].Show();
            }
        }
        private void init_press()
        {
            for (int i = 0; i < press.Length; i++)
            {
                press[i] = 0;
            }
        }

        private void init_check()
        {
            for (int i = 0; i < check.Length; i++)
            {
                check[i] = 0;
            }
        }
        private void init_select()
        {
            for (int i = 0; i < Box.Length; i++)
            {
                Box[i].BackColor = Color.White;
            }
        }
        public void add_image()
        {
            Box = new PictureBox[72];
            init_check();
            int rand_num;
            cnt = 0;
            Box[1] = pictureBox2; Box[0] = pictureBox1; Box[2] = pictureBox3;
            Box[4] = pictureBox5; Box[3] = pictureBox4; Box[5] = pictureBox6;
            Box[7] = pictureBox8; Box[6] = pictureBox7; Box[8] = pictureBox9;
            Box[10] = pictureBox11; Box[9] = pictureBox10; Box[11] = pictureBox12;
            Box[13] = pictureBox14; Box[12] = pictureBox13; Box[14] = pictureBox15;
            Box[16] = pictureBox17; Box[15] = pictureBox16; Box[17] = pictureBox18;
            Box[19] = pictureBox20; Box[18] = pictureBox19; Box[20] = pictureBox21;
            Box[22] = pictureBox23; Box[21] = pictureBox22; Box[23] = pictureBox24;
            Box[25] = pictureBox26; Box[24] = pictureBox25; Box[26] = pictureBox27;
            Box[28] = pictureBox29; Box[27] = pictureBox28; Box[29] = pictureBox30;
            Box[31] = pictureBox32; Box[30] = pictureBox31; Box[32] = pictureBox33;
            Box[34] = pictureBox35; Box[33] = pictureBox34; Box[35] = pictureBox36;
            Box[37] = pictureBox38; Box[36] = pictureBox37; Box[38] = pictureBox39;
            Box[40] = pictureBox41; Box[39] = pictureBox40; Box[41] = pictureBox42;
            Box[43] = pictureBox44; Box[42] = pictureBox43; Box[44] = pictureBox45;
            Box[46] = pictureBox47; Box[45] = pictureBox46; Box[47] = pictureBox48;
            Box[49] = pictureBox50; Box[48] = pictureBox49; Box[50] = pictureBox51;
            Box[52] = pictureBox53; Box[51] = pictureBox52; Box[53] = pictureBox54;
            Box[55] = pictureBox56; Box[54] = pictureBox55; Box[56] = pictureBox57;
            Box[58] = pictureBox59; Box[57] = pictureBox58; Box[59] = pictureBox60;
            Box[61] = pictureBox62; Box[60] = pictureBox61; Box[62] = pictureBox63;
            Box[64] = pictureBox65; Box[63] = pictureBox64; Box[65] = pictureBox66;
            Box[67] = pictureBox68; Box[66] = pictureBox67; Box[68] = pictureBox69;
            Box[70] = pictureBox71; Box[69] = pictureBox70; Box[71] = pictureBox72;

            for (int i = 0; i < 72; i++)
            {
                rand_num = r.Next(0,71);
                if (check[rand_num] != 1)
                {
                    check[rand_num] = 1;
                    rand_pb[cnt++] = Box[rand_num];
                }
            }
            for (int i = 0; i < 72; i++)
            {
                if (check[i] == 0)
                {
                    rand_pb[cnt++] = Box[i];
                }
            }
        }
        public void table_image()
        {
            int index=-1;
            for(int i =1;i<9;i++){
                for(int j = 1;j<10;j++){
                    if (index == 72) { }
                    else
                    {
                        tableLayoutPanel1.Controls.Add(rand_pb[++index], i, j);
                    }
                }
            }
        }
        private void New(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asdf");
        }
        //##################################################################
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            press[0]=1;
            Box[0].BackColor = Color.Red;
            click++;
            if (click == 2)
            {
                if (press[0] == press[36])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox1.Hide();
                    pictureBox37.Hide();
                }
                else
                {
                    init_press();
                    Box[0].BackColor = Color.White;
                    init_select();
                }
                click = 0;
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            press[36] = 1;
            click++;
            if (click == 2)
            {
                if (press[0] == press[36])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox1.Hide();
                    pictureBox37.Hide();
                }
                else
                {
                    init_press();
                    init_select();
                }
                click = 0;
            }
        }
    //##################################################################
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            press[1] = 1;
            click++;
            if (click == 2)
            {
                if (press[1] == press[37])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox2.Hide();
                    pictureBox38.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox38_Click(object sender, EventArgs e)
        {
            press[37] = 1;
            click++;
            if (click == 2)
            {
                if (press[1] == press[37])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox2.Hide();
                    pictureBox38.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            press[2] = 1;
            click++;
            if (click == 2)
            {
                if (press[2] == press[38])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox3.Hide();
                    pictureBox39.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            press[38] = 1;
            click++;
            if (click == 2)
            {
                if (press[2] == press[38])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox3.Hide();
                    pictureBox39.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################               
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            press[3] = 1;
            click++;
            if (click == 2)
            {
                if (press[3] == press[39])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox4.Hide();
                    pictureBox40.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox40_Click(object sender, EventArgs e)
        {
            press[39] = 1;
            click++;
            if (click == 2)
            {
                if (press[3] == press[39])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox4.Hide();
                    pictureBox40.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            press[4] = 1;
            click++;
            if (click == 2)
            {
                if (press[4] == press[40])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox5.Hide();
                    pictureBox41.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            press[40] = 1;
            click++;
            if (click == 2)
            {
                if (press[4] == press[40])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox5.Hide();
                    pictureBox41.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            press[5] = 1;
            click++;
            if (click == 2)
            {
                if (press[5] == press[41])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox6.Hide();
                    pictureBox42.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox42_Click(object sender, EventArgs e)
        {
            press[41] = 1;
            click++;
            if (click == 2)
            {
                if (press[5] == press[41])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox6.Hide();
                    pictureBox42.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            press[6] = 1;
            click++;
            if (click == 2)
            {
                if (press[6] == press[42])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox7.Hide();
                    pictureBox43.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            press[42] = 1;
            click++;
            if (click == 2)
            {
                if (press[6] == press[42])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox7.Hide();
                    pictureBox43.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################     

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            press[7] = 1;
            click++;
            if (click == 2)
            {
                if (press[7] == press[43])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox8.Hide();
                    pictureBox44.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox44_Click(object sender, EventArgs e)
        {
            press[43] = 1;
            click++;
            if (click == 2)
            {
                if (press[7] == press[43])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox8.Hide();
                    pictureBox44.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            press[8] = 1;
            click++;
            if (click == 2)
            {
                if (press[8] == press[44])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox9.Hide();
                    pictureBox45.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            press[44] = 1;
            click++;
            if (click == 2)
            {
                if (press[8] == press[44])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox9.Hide();
                    pictureBox45.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            press[9] = 1;
            click++;
            if (click == 2)
            {
                if (press[9] == press[45])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox10.Hide();
                    pictureBox46.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            press[45] = 1;
            click++;
            if (click == 2)
            {
                if (press[9] == press[45])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox10.Hide();
                    pictureBox46.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            press[10] = 1;
            click++;
            if (click == 2)
            {
                if (press[10] == press[46])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox11.Hide();
                    pictureBox47.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            press[46] = 1;
            click++;
            if (click == 2)
            {
                if (press[10] == press[46])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox11.Hide();
                    pictureBox47.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            press[11] = 1;
            click++;
            if (click == 2)
            {
                if (press[11] == press[47])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox12.Hide();
                    pictureBox48.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox48_Click(object sender, EventArgs e)
        {
            press[47] = 1;
            click++;
            if (click == 2)
            {
                if (press[11] == press[47])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox12.Hide();
                    pictureBox48.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            press[12] = 1;
            click++;
            if (click == 2)
            {
                if (press[12] == press[48])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox13.Hide();
                    pictureBox49.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox49_Click(object sender, EventArgs e)
        {
            press[48] = 1;
            click++;
            if (click == 2)
            {
                if (press[12] == press[48])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox13.Hide();
                    pictureBox49.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            press[13] = 1;
            click++;
            if (click == 2)
            {
                if (press[13] == press[49])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox14.Hide();
                    pictureBox50.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox50_Click(object sender, EventArgs e)
        {
            press[49] = 1;
            click++;
            if (click == 2)
            {
                if (press[13] == press[49])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox14.Hide();
                    pictureBox50.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            press[14] = 1;
            click++;
            if (click == 2)
            {
                if (press[14] == press[50])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox15.Hide();
                    pictureBox51.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox51_Click(object sender, EventArgs e)
        {
            press[50] = 1;
            click++;
            if (click == 2)
            {
                if (press[14] == press[50])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox15.Hide();
                    pictureBox51.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            press[15] = 1;
            click++;
            if (click == 2)
            {
                if (press[15] == press[51])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox16.Hide();
                    pictureBox52.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox52_Click(object sender, EventArgs e)
        {
            press[51] = 1;
            click++;
            if (click == 2)
            {
                if (press[15] == press[51])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox16.Hide();
                    pictureBox52.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            press[16] = 1;
            click++;
            if (click == 2)
            {
                if (press[16] == press[52])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox17.Hide();
                    pictureBox53.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox53_Click(object sender, EventArgs e)
        {
            press[52] = 1;
            click++;
            if (click == 2)
            {
                if (press[16] == press[52])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox17.Hide();
                    pictureBox53.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            press[17] = 1;
            click++;
            if (click == 2)
            {
                if (press[17] == press[53])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox18.Hide();
                    pictureBox54.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox54_Click(object sender, EventArgs e)
        {
            press[53] = 1;
            click++;
            if (click == 2)
            {
                if (press[17] == press[53])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox18.Hide();
                    pictureBox54.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            press[18] = 1;
            click++;
            if (click == 2)
            {
                if (press[18] == press[54])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox19.Hide();
                    pictureBox55.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox55_Click(object sender, EventArgs e)
        {
            press[54] = 1;
            click++;
            if (click == 2)
            {
                if (press[18] == press[54])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox19.Hide();
                    pictureBox55.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            press[19] = 1;
            click++;
            if (click == 2)
            {
                if (press[19] == press[55])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox20.Hide();
                    pictureBox56.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox56_Click(object sender, EventArgs e)
        {
            press[55] = 1;
            click++;
            if (click == 2)
            {
                if (press[19] == press[55])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox20.Hide();
                    pictureBox56.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################  
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            press[20] = 1;
            click++;
            if (click == 2)
            {
                if (press[20] == press[56])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox21.Hide();
                    pictureBox57.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox57_Click(object sender, EventArgs e)
        {
            press[56] = 1;
            click++;
            if (click == 2)
            {
                if (press[20] == press[56])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox21.Hide();
                    pictureBox57.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            press[21] = 1;
            click++;
            if (click == 2)
            {
                if (press[21] == press[57])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox22.Hide();
                    pictureBox58.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox58_Click(object sender, EventArgs e)
        {
            press[57] = 1;
            click++;
            if (click == 2)
            {
                if (press[21] == press[57])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox22.Hide();
                    pictureBox58.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            press[22] = 1;
            click++;
            if (click == 2)
            {
                if (press[22] == press[58])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox23.Hide();
                    pictureBox59.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox59_Click(object sender, EventArgs e)
        {
            press[58] = 1;
            click++;
            if (click == 2)
            {
                if (press[22] == press[58])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox23.Hide();
                    pictureBox59.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            press[23] = 1;
            click++;
            if (click == 2)
            {
                if (press[23] == press[59])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox24.Hide();
                    pictureBox60.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox60_Click(object sender, EventArgs e)
        {
            press[59] = 1;
            click++;
            if (click == 2)
            {
                if (press[23] == press[59])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox24.Hide();
                    pictureBox60.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            press[24] = 1;
            click++;
            if (click == 2)
            {
                if (press[24] == press[60])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox25.Hide();
                    pictureBox61.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox61_Click(object sender, EventArgs e)
        {
            press[60] = 1;
            click++;
            if (click == 2)
            {
                if (press[24] == press[60])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox25.Hide();
                    pictureBox61.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            press[25] = 1;
            click++;
            if (click == 2)
            {
                if (press[25] == press[61])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox26.Hide();
                    pictureBox62.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox62_Click(object sender, EventArgs e)
        {
            press[61] = 1;
            click++;
            if (click == 2)
            {
                if (press[25] == press[61])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox26.Hide();
                    pictureBox62.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            press[26] = 1;
            click++;
            if (click == 2)
            {
                if (press[26] == press[62])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox27.Hide();
                    pictureBox63.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox63_Click(object sender, EventArgs e)
        {
            press[62] = 1;
            click++;
            if (click == 2)
            {
                if (press[26] == press[62])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox27.Hide();
                    pictureBox63.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
       
        //##################################################################
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            press[27] = 1;
            click++;
            if (click == 2)
            {
                if (press[27] == press[63])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox28.Hide();
                    pictureBox64.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox64_Click(object sender, EventArgs e)
        {
            press[63] = 1;
            click++;
            if (click == 2)
            {
                if (press[27] == press[63])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox28.Hide();
                    pictureBox64.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        
        //##################################################################
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            press[28] = 1;
            click++;
            if (click == 2)
            {
                if (press[28] == press[64])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox29.Hide();
                    pictureBox65.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox65_Click(object sender, EventArgs e)
        {
            press[64] = 1;
            click++;
            if (click == 2)
            {
                if (press[28] == press[64])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox29.Hide();
                    pictureBox65.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
       
        //##################################################################
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            press[29] = 1;
            click++;
            if (click == 2)
            {
                if (press[29] == press[65])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox66.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox66_Click(object sender, EventArgs e)
        {
            press[65] = 1;
            click++;
            if (click == 2)
            {
                if (press[29] == press[65])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox30.Hide();
                    pictureBox66.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
       
        //##################################################################
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            press[30] = 1;
            click++;
            if (click == 2)
            {
                if (press[30] == press[66])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox31.Hide();
                    pictureBox67.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox67_Click(object sender, EventArgs e)
        {
            press[66] = 1;
            click++;
            if (click == 2)
            {
                if (press[30] == press[66])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox31.Hide();
                    pictureBox67.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        
        //##################################################################
        private void pictureBox32_Click(object sender, EventArgs e)
        {
            press[31] = 1;
            click++;
            if (click == 2)
            {
                if (press[31] == press[67])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox32.Hide();
                    pictureBox68.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox68_Click(object sender, EventArgs e)
        {
            press[67] = 1;
            click++;
            if (click == 2)
            {
                if (press[31] == press[67])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox32.Hide();
                    pictureBox68.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        
        //##################################################################
        private void pictureBox33_Click(object sender, EventArgs e)
        {
            press[32] = 1;
            click++;
            if (click == 2)
            {
                if (press[32] == press[68])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox33.Hide();
                    pictureBox69.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox69_Click(object sender, EventArgs e)
        {
            press[68] = 1;
            click++;
            if (click == 2)
            {
                if (press[32] == press[68])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox33.Hide();
                    pictureBox69.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
       
        //##################################################################
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            press[33] = 1;
            click++;
            if (click == 2)
            {
                if (press[33] == press[69])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox34.Hide();
                    pictureBox70.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox70_Click(object sender, EventArgs e)
        {
            press[69] = 1;
            click++;
            if (click == 2)
            {
                if (press[33] == press[69])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox34.Hide();
                    pictureBox70.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
       
        //##################################################################
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            press[34] = 1;
            click++;
            if (click == 2)
            {
                if (press[34] == press[70])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox35.Hide();
                    pictureBox71.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox71_Click(object sender, EventArgs e)
        {
            press[70] = 1;
            click++;
            if (click == 2)
            {
                if (press[34] == press[70])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox35.Hide();
                    pictureBox71.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            press[35] = 1;
            click++;
            if (click == 2)
            {
                if (press[35] == press[71])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox36.Hide();
                    pictureBox72.Hide();
                }

                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        private void pictureBox72_Click(object sender, EventArgs e)
        {
            press[71] = 1;
            click++;
            if (click == 2)
            {
                if (press[35] == press[71])
                {
                    label1.Text = Convert.ToString(correct += 2);
                    label4.Text = Convert.ToString(div -= 2);
                    pictureBox36.Hide();
                    pictureBox72.Hide();
                }
                else
                {
                    init_press();
                }
                click = 0;
            }
        }
        //##################################################################
       


        
    }
}
