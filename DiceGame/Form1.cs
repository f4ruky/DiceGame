using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int oyuncu1toplam, oyuncu2toplam = 0;
        int a, b;

        private void zarAt()
        {
            a = rnd.Next(1, 7);
            b = rnd.Next(1, 7);

            //Oyuncu1 için
            if (a==1)
            {
                pictureBox1.ImageLocation = "images\\1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "images\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "images\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "images\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "images\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "images\\6.png";
            }

            //Oyuncu2 için
            if (b == 1)
            {
                pictureBox2.ImageLocation = "images\\1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "images\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "images\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "images\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "images\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "images\\6.png";
            }

        }
        private void oyuncuSkor()
        {
            if (oyuncu1toplam>=Convert.ToInt32(textBox1.Text))
            {
                label3.Visible = true;
                label3.Text = "Oyuncu 1 Kazandı...";
                button_Tekrar.Visible = true;
                button_oyuncu2.Enabled = false;
            }
            if (oyuncu2toplam >= Convert.ToInt32(textBox1.Text))
            {
                label3.Visible = true;
                label3.Text = "Oyuncu 2 Kazandı...";
                button_Tekrar.Visible = true;
                button_Oyuncu1.Enabled = false;
            }
        }
        private void button_Oyuncu1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_Oyuncu1.Enabled = false;
            button_oyuncu2.Enabled = true;
            zarAt();
            oyuncu1toplam = oyuncu1toplam + a + b;
            label_oyuncu1.Text = oyuncu1toplam.ToString();
            oyuncuSkor();
        }

        private void button_oyuncu2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_oyuncu2.Enabled = false;
            button_Oyuncu1.Enabled = true;
            zarAt();
            oyuncu2toplam = oyuncu2toplam + a + b;
            label_oyuncu2.Text = oyuncu2toplam.ToString();
            oyuncuSkor();
        }

        private void button_Tekrar_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "100";
            button_Oyuncu1.Enabled = true;
            button_oyuncu2.Enabled = true;
            label3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            oyuncu1toplam = 0;
            oyuncu2toplam = 0;
            label_oyuncu1.Text = "0";
            label_oyuncu2.Text = "0";
            button_Tekrar.Visible = false;

        }
    }
}
