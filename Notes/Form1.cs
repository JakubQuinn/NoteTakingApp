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
            // On the click of the button it saves it to a preset file
            File.WriteAllText("C:\\Notes.txt", textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream mystream;
            OpenFileDialog openfile = new OpenFileDialog();

            if(openfile.ShowDialog() == DialogResult.OK)
            {
                if((mystream = openfile.OpenFile()) != null)
                {
                    string strfilename = openfile.FileName;
                    String filetext = File.ReadAllText(strfilename);
                    textBox1.Text = filetext;
                }
            }
        }

        /*
        private void Save_As_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
