using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Demoç

{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.Exists("E:/Mosquito");
            Directory.CreateDirectory("E:/Mosquito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valor = Directory.Exists("E:/Mosquito");
            Directory.Delete("E:/Mosquito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Create("E:/Mosquito/Hola.txt");
        }
    }
}
