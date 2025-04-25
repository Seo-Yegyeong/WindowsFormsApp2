using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome!");
            textBox_print.Text = "this is \r\na multiline \r\ntextbox!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요 호호");
        }

        private void textBox_print_TextChanged(object sender, EventArgs e)
        {
            textBox_print.Text = "안녕하세유...";
        }
    }
}
