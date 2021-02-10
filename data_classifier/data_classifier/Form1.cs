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
        int currentFile = -1;
        int yesFileCount = 0;
        int noFileCount = 0;
        HashSet<string> yesFiles = new HashSet<string>();
        HashSet<string> noFiles = new HashSet<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            if(sourceDirectoryBrowser.ShowDialog() == DialogResult.OK)
            {
                showFirstFile();
                directoryLabel.Text = sourceDirectoryBrowser.SelectedPath;
                totalFilesLabel.Text = Directory.GetFiles(sourceDirectoryBrowser.SelectedPath).Length.ToString();

                reset();
            }
        }

        private void reset()
        {
            currentFile = 0;
            yesFileCount = 0;
            noFileCount = 0;
            yesFiles = new HashSet<string>();
            noFiles = new HashSet<string>();

            yesDestinationDirectoryLabel.Text = "None";
            noDestinationDirectoryLabel.Text = "None";
            finishButton.Text = "Finish";

        }

        void showNextFile()
        {
            string next = nextFile(sourceDirectoryBrowser.SelectedPath);
            if (next == null)
            {
                fileLabel.Text = "END OF FILES";
                return;
            }

            pictureBox1.Load(next);
            fileLabel.Text = pictureBox1.ImageLocation;
            // +1 because count starts from 0, want to display from 1
            currentFileNumberLabel.Text = (currentFile+1).ToString();
        }

        void showFirstFile()
        {
            pictureBox1.Load(Directory.EnumerateFiles(sourceDirectoryBrowser.SelectedPath).First());
            currentFile = 0;
            currentFileNumberLabel.Text = (currentFile + 1).ToString();
        }

        void showPrevFile()
        {
            string prev = prevFile(sourceDirectoryBrowser.SelectedPath);
            if (prev == null)
            {
                fileLabel.Text = "BEGINNING OF FILES";
                return;
            }
            pictureBox1.Load(prev);
            fileLabel.Text = pictureBox1.ImageLocation;
            // +1 because count starts from 0, want to display from 1
            currentFileNumberLabel.Text = (currentFile+1).ToString();
        }

        string nextFile(string path)
        {
            int totalFiles = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
            currentFile++;
            if (currentFile >= totalFiles)
            {
                currentFile = totalFiles;
                return null;
            }
            string filePath = Directory.EnumerateFiles(path).Skip(currentFile).First();
            return filePath;
        }

        string prevFile(string path)
        {
            currentFile--;
            if (currentFile < 0)
            {
                currentFile = 0;
                return null;
            }
            string filePath = Directory.EnumerateFiles(path).Skip(currentFile).First();
            return filePath;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (noFiles.Remove(pictureBox1.ImageLocation))
                incrementNoFileCount(-1);
            if(yesFiles.Add(pictureBox1.ImageLocation))
                incrementYesFileCount(1);
            showNextFile();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            if (yesFiles.Remove(pictureBox1.ImageLocation))
                incrementYesFileCount(-1);
            if (noFiles.Add(pictureBox1.ImageLocation))
                incrementNoFileCount(1);
            showNextFile();
        }


        private void yesDirectoryPickButton_Click(object sender, EventArgs e)
        {
            if (yesDirectoryBrowser.ShowDialog() == DialogResult.OK)
            {
                yesDestinationDirectoryLabel.Text = yesDirectoryBrowser.SelectedPath;
            }
        }

        private void noDirectoryPickButton_Click(object sender, EventArgs e)
        {
            if (noDirectoryBrowser.ShowDialog() == DialogResult.OK)
            {
                noDestinationDirectoryLabel.Text = noDirectoryBrowser.SelectedPath;
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            moveFiles();
        }

        private void moveFiles()
        {
            pictureBox1.Image = null;
            foreach (string file in yesFiles)
            {
                File.Move(file, yesDirectoryBrowser.SelectedPath + "\\" + Path.GetFileName(file));
            }

            foreach (string file in noFiles)
            {
                File.Move(file, noDirectoryBrowser.SelectedPath + "\\" + Path.GetFileName(file));
            }
            finishButton.Text = "Success!";
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            showNextFile();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            showPrevFile();
            if (yesFiles.Remove(pictureBox1.ImageLocation))
                incrementYesFileCount(-1);
            else if (noFiles.Remove(pictureBox1.ImageLocation))
                incrementNoFileCount(-1);
        }

        private void incrementYesFileCount(int change)
        {
            yesFileCount += change;
            yesFileCountLabel.Text = yesFileCount.ToString();
        }

        private void incrementNoFileCount(int change)
        {
            noFileCount += change;
            noFileCountLabel.Text = noFileCount.ToString();
        }
    }
}
