using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8 //Име на програмата 
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent(); 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        { 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int counter =  0;
            double number = Convert.ToDouble(textBox1.Text); //декларираме променлива, която взима стойността от текстовото поле и я превръща в реален тип
            textBox2.Text = Convert.ToString(number * 1024); //променяме стойността на второто текстово поле като изчисляваме мегабайтите и  я превръщаме в string като се умножава по 1024
            textBox3.Text = Convert.ToString(number * 1024*1024); //променяме стойността на второто текстово поле като изчисляваме килобайти и я превръща в string като се умножава два пъти по 1024
        }
}