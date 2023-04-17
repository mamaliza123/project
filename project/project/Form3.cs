using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stroka = textBox1.Text;
            System.IO.File.AppendAllText(@"C:\Users\lizan\Downloads\project\project\bin\Debug\Downloads\project.txt", stroka);
            string stroka1 = textBox2.Text;
            System.IO.File.AppendAllText(@"C:\Users\lizan\Downloads\project\project\bin\Debug\Downloads\project.txt", stroka1);
            string stroka2 = textBox3.Text;
            System.IO.File.AppendAllText(@"C:\Users\lizan\Downloads\project\project\bin\Debug\Downloads\project.txt", stroka2);
            string stroka3 = textBox4.Text;
            System.IO.File.AppendAllText(@"C:\Users\lizan\Downloads\project\project\bin\Debug\Downloads\project.txt", stroka3);
        }
    }
}
