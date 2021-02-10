using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_classifier
{
    public partial class Form1 : Form
    {
        int currentFile = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                showNextFile();
            }
        }


        void showNextFile()
        {
            pictureBox1.Load(nextFile(folderBrowser.SelectedPath, ref currentFile));
        }

        void showPrevFile()
        {
            pictureBox1.Load(prevFile(folderBrowser.SelectedPath, ref currentFile));
        }

        string nextFile(string path, ref int counter)
        {
            string filePath = Directory.EnumerateFiles(path).Skip(counter).First();
            counter++;
            if (counter == Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length)
            {
                counter--;
            }
            return filePath;
        }

        string prevFile(string path, ref int counter)
        {
            string filePath = Directory.EnumerateFiles(path).Skip(counter-1).First();
            counter--;
            if (counter == 0)
            {
                counter++;
            }
            return filePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showNextFile();
        }
    }
}
