using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaJava;
namespace PruebaJava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            DemoJava.ClaseJava clasejava=new DemoJava.ClaseJava();
            string s2=clasejava.FuncionDePrueba(s1);
            textBox2.Text = s2;

        }
    }
}
