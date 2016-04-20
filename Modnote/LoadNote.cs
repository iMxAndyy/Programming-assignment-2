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

namespace Modnote
{
    public partial class LoadNote : Form
    {
        public LoadNote(string selected2)
        {
            InitializeComponent();
            ModID.Text = selected2;//loads the module name
            string location = "../../../Notes/";//the location the notes are stored in
            location += ModID.Text;
            Directory.CreateDirectory(location);
            string[] array1 = Directory.GetFiles(location),//loads in the list of notes for the selected module
                     array2 = new string[array1.Length];//stores the list of notes without path

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = Path.GetFileNameWithoutExtension(array1[i]);//removes the path
            }
            if (array2.Length == 0)
            {
                notesList.Visible = false;//if no notes exist, It hides the list
                noNotesLabel.Visible = true;//and shows 2 labels telling the user what to do next
                noNotesLabel2.Visible = true;
            }
            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    notesList.Items.Add(array2[i]);//adds all of the available notes to the list for the user to select
                }
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();//closes the window
        }

        private void notesList_DoubleClick(object sender, EventArgs e)
        {
            string selected = ModID.Text;
            string title = notesList.GetItemText(notesList.SelectedItem);
            NoteViewer notesForm = new NoteViewer(title, selected);//opens the noteviewer again and sends the module name back to it along with the selected note name
            notesForm.Show();
            this.DialogResult = DialogResult.OK;
            this.Close();//closes the window
        }
    }
}
