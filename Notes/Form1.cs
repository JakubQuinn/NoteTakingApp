using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_File = new SaveFileDialog();


            if (save_File.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_File.FileName, textBox1.Text);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open_File = new OpenFileDialog();
            open_File.Title = "Open File";

            if(open_File.ShowDialog() == DialogResult.OK)
            {
                StreamReader mystream = new StreamReader(File.OpenRead(open_File.FileName));
                textBox1.Text = mystream.ReadToEnd();
                mystream.Close();
                
            }
        }



    }
}
