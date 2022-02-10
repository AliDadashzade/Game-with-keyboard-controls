using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_with_keyboard_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru = 0;
        private void dis()
        {
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Right && x<700)
            {
                x +=10;
            }
            if (e.KeyCode == Keys.Left && x>0)
            {
                x -= 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                y -= 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                y += 10;
            }
            pictureBox1.Location = new Point(x, y);
            if (pictureBox1.Left>=pictureBox3.Left)
            {
                soru = 1;
                if (soru == 1)
                {
                    pictureBox3.Visible = false;
                    label2.Text = "Donusum kitabinin yazari kimdir?";
                    label7.Text = "Sabahattin Ali";
                    label8.Text = "Franz Kafka";
                    label9.Text = "George Orwell";
                    label10.Text = "Tolstoy";
                    label11.Text = "Franz Kafka";
                }
            }
            if (pictureBox1.Left <= pictureBox4.Left)
            {
                soru++;
                if (soru == 2)
                {
                    pictureBox4.Visible = false;
                    label7.Enabled = true;
                    label8.Enabled = true;
                    label9.Enabled = true;
                    label10.Enabled = true;
                    label7.BackColor = Color.Black;
                    label8.BackColor = Color.Black;
                    label9.BackColor = Color.Black;
                    label10.BackColor = Color.Black;
                    label2.Text = "1984 kitabinin yazari kimdir?";
                    label7.Text = "Dostoyevski";
                    label8.Text = "S.Zweig";
                    label9.Text = "George Orwell";
                    label10.Text = "Tolstoy";
                    label11.Text = "George Orwell";
                }
            }
            if(pictureBox1.Left>=pictureBox2.Left && pictureBox1.Top >=pictureBox2.Top)
            {
                pictureBox5.Visible = true;
                pictureBox1.Visible =false;
                pictureBox2.Visible = false;
                MessageBox.Show("You won!");
            }
        } 
        private void label7_Click(object sender, EventArgs e)
        {
            if (label11.Text == label7.Text)
            {
                label7.BackColor = Color.Green;
            }
            else
            {
                label7.BackColor=Color.Red;
            }
            dis();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            if (label11.Text == label8.Text)
            {
                label8.BackColor = Color.Green;
            }
            else
            {
                label8.BackColor = Color.Red;
            }
            dis();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label11.Text == label9.Text)
            {
                label9.BackColor = Color.Green;
            }
            else
            {
                label9.BackColor = Color.Red;
            }
            dis();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (label11.Text == label10.Text)
            {
                label10.BackColor = Color.Green;
            }
            else
            {
                label10.BackColor = Color.Red;
            }
            dis();
        }
    }
}
