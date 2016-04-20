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
            modID.Text = selected;//loads the selected module name
            nameLabel.Text = title;//loads the default note name (none loaded)
            string content = "../../../Notes/";//location of the notes
                content += modID.Text;
                content += "/";
                content += nameLabel.Text;
                content += ".txt";

            if (nameLabel.Text == "No Note Loaded")//if no notes loaded (as in when first opened) do nothing
            {

            }
            else if(File.Exists(content))//check if a note exists with the selected name. If it does load it
            {
                InsertNoteBox.Text = File.ReadAllText(content);
            }
            else//if no note exists clear the content box (assuming this is because the user is creating a new note)
            {
                InsertNoteBox.Text = "";
            }
        }

        private void cancelNoteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();//closes the window
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {

            if (nameLabel.Text == "No Note Loaded")//if no note has been loaded yet present an error message
            {
                InsertNoteBox.Text = "You must first create a note or load a note before you can save";//error message
            }
            else//if a note is loaded, save it
            {
                string[] content = InsertNoteBox.Lines;//save user entered content to this array
                string filename = "../../../notes/";//file location for notes + module name folder
                filename += modID.Text;
                Directory.CreateDirectory(filename);//create a folder for this module in case one doesn't already exist.
                filename += "/";
                filename += nameLabel.Text;
                filename += ".txt";

                StreamWriter File = new StreamWriter(filename);//save note with given name (create new file or overwrite old file)
                for (int i = 0; i < content.Length; i++)
                {
                    File.WriteLine(content[i]);//save file with content entered by user
                }
                File.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();//closes the window
            }
        }

        private void clearNoteButton_Click(object sender, EventArgs e)
        {
            InsertNoteBox.Text = "";//clear the content box
        }

        private void createNoteButton_Click(object sender, EventArgs e)
        {
            string selected2 = modID.Text;
            Create createForm = new Create(selected2);//open the create note form and send it the module ID
            createForm.Show();
            this.DialogResult = DialogResult.Cancel;
            this.Close();//close this window as it will be reopened once user is done with the create note form

        }

        private void LoadNoteButton_Click(object sender, EventArgs e)
        {
            string selected2 = modID.Text;
            LoadNote loadnoteForm = new LoadNote(selected2);//open the load note form and send it the module ID
            loadnoteForm.Show();
            this.DialogResult = DialogResult.Cancel;
            this.Close();//close this window as it will be reopened once user is done with the load note form
        }
    }
}
