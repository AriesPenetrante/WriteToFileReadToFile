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

namespace WriteToFileReadToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {

            writetofile();



        }



        private void writetofile()


        {

            /// Start of Writing 
            string filePath = @"C:\TestFile\Testfile.txt";
            string content = outputTextBox.Text;

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine(content);
            }
            ///end of writing




        }
        /// end of writetofile()
        /// 

        private void readtofile()

        {

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.ShowDialog();

            string readfile = File.ReadAllText(dialog.FileName);

            outputTextBox.Text = readfile;






        }

        private void readBtn_Click(object sender, EventArgs e)
        {

            readtofile();

        }

        private void coptBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(outputTextBox.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = string.Empty;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        ///end of readtofile()



    }

}
