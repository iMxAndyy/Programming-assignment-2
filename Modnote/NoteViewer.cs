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
using System.Diagnostics;

namespace Modnote
{
    public partial class NoteViewer : Form
    {
        public NoteViewer(string title, string selected)
        {
            InitializeComponent();
            modID.Text = selected;
            nameLabel.Text = title;
            string content = "../../../Notes/";
                content += modID.Text;
                content += "/";
                content += nameLabel.Text;
                content += ".txt";

            if (nameLabel.Text == "No Note Loaded")
            {

            }
            else if(File.Exists(content))
            {
                InsertNoteBox.Text = File.ReadAllText(content);
            }
            else
            {
                InsertNoteBox.Text = "";
            }
        }

        private void cancelNoteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {

            if (nameLabel.Text == "No Note Loaded")
            {
                InsertNoteBox.Text = "You must first create a note or load a note before you can save";
            }
            else
            {
                string[] content = InsertNoteBox.Lines;
                string filename = "../../../notes/";
                filename += modID.Text;
                Directory.CreateDirectory(filename);
                filename += "/";
                filename += nameLabel.Text;
                filename += ".txt";

                StreamWriter File = new StreamWriter(filename);
                for (int i = 0; i < content.Length; i++)
                {
                    File.WriteLine(content[i]);
                }
                File.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void clearNoteButton_Click(object sender, EventArgs e)
        {
            InsertNoteBox.Text = "";
        }

        private void createNoteButton_Click(object sender, EventArgs e)
        {
            string selected2 = modID.Text;
            Create createForm = new Create(selected2);
            createForm.Show();
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void LoadNoteButton_Click(object sender, EventArgs e)
        {
            string selected2 = modID.Text;
            LoadNote loadnoteForm = new LoadNote(selected2);
            loadnoteForm.Show();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            //string location = "../../../notes/";
            //location += modID.Text;
            //Directory.CreateDirectory(location);

            //OpenFileDialog file = new OpenFileDialog();
            //file.Title = "Open";
            //file.Filter = "TXT files|*.txt";
            //file.InitialDirectory = "../../../notes/";

            //if (file.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader inputFile = new StreamReader(file.FileName);
            //    InsertNoteBox.Text = inputFile.ReadToEnd();
            //    inputFile.Close();
            //    string filename = Path.GetFileNameWithoutExtension(file.FileName);
            //    nameLabel.Text = filename;
            //}

        }
    }
}
