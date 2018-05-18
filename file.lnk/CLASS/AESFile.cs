using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lnkFile.CLASS
{
    public partial class AESFile : Form
    {
        public AESFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            textBox1.Text = open.FileName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rwFile encrypt = new rwFile();
            textBox2.Text = encrypt.ExecuteWriteNewFile(textBox1.Text);
        }
    }
}
