using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_RRHH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 obj1 = new Form6();
            obj1.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 obj1 = new Form3();
            obj1.Show();
            this.Hide();
        }

        private void btnIngTrab_Click(object sender, EventArgs e)
        {
            Form5 obj1 = new Form5();
            obj1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 obj1 = new Form4();
            obj1.Show();
            this.Hide();
        }
    }
}
