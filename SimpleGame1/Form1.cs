using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SimpleGame1
{
    public partial class Form1 : Form
    {
        bool lose=false;
        int coins = 0;
        public Form1()
        {
            
            InitializeComponent();
            labelLose.Visible = false;
            PlayAgain.Visible = false;
            KeyPreview = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int speed = 10;
            bg1.Top += speed;
            pictureBox3.Top += speed;

            int CarSpeed = 10;
            enemy1.Top += CarSpeed;
            enemy2.Top += CarSpeed;

            coin.Top += speed;
            
            if (bg1.Top >= 600)
            {
                bg1.Top = 0;
                pictureBox3.Top = -600;
            }
            if (coin.Top >= 650) coin.Top = -50;

            if (coin.Top >= 650)
            {
                coin.Top = -400;
                Random rand = new Random();
                coin.Left = rand.Next(230, 600);
            }

            if (enemy1.Top >= 600)
            {
                enemy1.Top = -140;
                Random rand = new Random();
                enemy1.Left = rand.Next(230,600);
            }
            if (enemy2.Top >= 600) 
            {
                enemy2.Top = -400;
                Random rand = new Random();
                enemy2.Left = rand.Next(230, 600);
            }
            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                coins++;
                coinLabel.Text="Coins:" +coins.ToString();
                coin.Top = -400;
                Random rand = new Random();
                coin.Left = rand.Next(230, 600);
            }


            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;

                labelLose.Visible = true;
                PlayAgain.Visible = true;
                lose = true;
                coins = 0;
                coinLabel.Text = "Coins:0";
                coin.Top = -400;
            }
        }   

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose)
            {
                return;
            }
            int speed = 10;
            if((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 250)
            {
                player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 579)
            {
                player.Left += speed;
            }
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            enemy1.Top = -140;
            enemy2.Top = -400;
            labelLose.Visible = false;
            PlayAgain.Visible = false;
            timer1.Enabled = true;
            lose = false;
        }

        private void coinLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
