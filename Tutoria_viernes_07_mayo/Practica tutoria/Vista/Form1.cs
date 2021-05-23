using Practica_tutoria.Vista;
using System;
using System.Windows.Forms;
using Practica_tutoria.Controlador;

namespace Practica_tutoria
{
    public partial class Form1 : Form
    {
        private int counter;
        private Form2 form2;
        public Form1()
        {
            form2 = new Form2();
            InitializeComponent();
            counter = 0;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.ShowDialog();
            this.Show();
            this.BackColor = OptionsControler.backGroundColor;
            label1.ForeColor = OptionsControler.fontColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = counter.ToString();
        }
    }
}
