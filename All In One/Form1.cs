using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_In_One
{
    public partial class Form1 : Form
    {
        string dirFromFC;// fc stands for file changer
        string dirToFC;
        string searchFC;
        
        public Form1()
        {
            InitializeComponent();
        }

        //<summary>
        //Button to add the tags to the lines in the list
        //</summary
        private void buttonGo1_Click(object sender, EventArgs e)
        {
            string tag = txtBoxListChanger1.Text;
            String s=String.Empty;
            String Output="";

            if (txtBoxListChanger1.Text == "" || txtBoxListChanger2.Text == "")
            {
                MessageBox.Show("Please make sure you filled both textboxes","Message");
            }
            else
            {
              for (int i = 0; i < txtBoxListChanger2.Lines.Length; i++)
                {
                    if (i == 0)
                    {
                        s = txtBoxListChanger2.Lines[i];
                        Output += "<" + tag + ">" + txtBoxListChanger2.Lines[i] + "</" + tag + ">";
                    }
                    else if (txtBoxListChanger2.Lines[i] == "")
                    {}
                    else
                    {
                        s = txtBoxListChanger2.Lines[i];
                        Output += "\n" + "<" + tag + ">" + txtBoxListChanger2.Lines[i] + "</" + tag + ">";
                    }

                }
                txtBoxListChanger2.Text = Output;
            }       
        }

        //<summary>
        //Button to change the location of files
        //</summary>
        private void goButton_Click(object sender, EventArgs e)
        {
            if (txtBoxListChanger1.Text == "" || txtBoxListChanger2.Text == "" || txtBoxFileChanger1.Text == "")
            {
                MessageBox.Show("you didn\'t give a value to one of the textboxes ", "Mkay", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtBoxFileChanger1.Text = dirFromFC;
                txtBoxFileChanger2.Text = dirToFC;
                searchFC = txtBoxFileChanger3.Text;


                string[] dirs = System.IO.Directory.GetFiles(dirFromFC, searchFC + "*");
                if (dirs.Length == 0)
                {
                    MessageBox.Show("no files found in " + dirFromFC, "message");
                }
                else
                {
                    foreach (string dir in dirs)
                    {

                        string temporary = dir.Remove(0, dirFromFC.Length);
                        System.IO.File.Move(dir, dirToFC + temporary);

                    }
                    MessageBox.Show("all files that had " + searchFC + " in their name have been moved to " + dirToFC, "message");
                }
            }
        }

        //<summary>
        //Shows the file explorer to open a destination in which the files will be searched,
        //the standard destination is set to the desktop.
        //</summary>
        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (openFolder1.ShowDialog() == DialogResult.OK)
            {
                txtBoxFileChanger1.Text = openFolder1.SelectedPath;
                dirFromFC = openFolder1.SelectedPath;
            }
        }

        //<summary>
        //Shows the file explorer to open a destination in which the found files will be set,
        //the standard destination is set to the desktop.
        //</summary>
        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (openFolder2.ShowDialog() == DialogResult.OK)
            {
                txtBoxFileChanger2.Text = openFolder2.SelectedPath;
                dirToFC = openFolder2.SelectedPath;
            }
        }
    }
}
