using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace 文件分发
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inFile = textBox1.Text;
            string outFile = inFile + ".SNGPak";
            string password = textBox3.Text;
            DESFile.DESFileClass.EncryptFile(inFile, outFile, password);//加密文件
            textBox1.Text = string.Empty;
            MessageBox.Show("加密成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Multiselect = true;

            fileDialog.Title = "请选择需要分发的文件";

            fileDialog.Filter = "需要分发的文件|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)

            {

                string file = fileDialog.FileName;
                textBox1.Text = file;
                MessageBox.Show("已选择文件: " + file + " 请确认是否正确，如选错请重新选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
