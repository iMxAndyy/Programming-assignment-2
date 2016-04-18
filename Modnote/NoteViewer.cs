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

            if (nameLabel.Text == "No Note Loaded")
            {

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
                SaveFileDialog file = new SaveFileDialog();
                file.FileName = nameLabel.Text;
                file.Title = "Save Note";
                file.Filter = "TXT files|*.txt";
                file.InitialDirectory = "/notes";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    string name = file.FileName;
                    string content = InsertNoteBox.Text;

                    File.WriteAllText(name, content);
                }
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
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Open";
            file.Filter = "TXT files|*.txt";
            file.InitialDirectory = "/notes";

            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader inputFile = new StreamReader(file.FileName);
                InsertNoteBox.Text = inputFile.ReadToEnd();
                inputFile.Close();
                string filename = Path.GetFileNameWithoutExtension(file.FileName);
                nameLabel.Text = filename;
            }
            
        }
    }
}
