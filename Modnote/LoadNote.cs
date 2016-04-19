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
            ModID.Text = selected2;
            string location = "../../../Notes/";
            location += ModID.Text;
            Directory.CreateDirectory(location);
            string[] array1 = Directory.GetFiles(location),
                     array2 = new string[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = Path.GetFileNameWithoutExtension(array1[i]);
            }
            if (array2.Length == 0)
            {
                notesList.Items.Add("No Notes Exist for this module");
                notesList.Items.Add("Click 'Cancel' to go back");
            }
            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    notesList.Items.Add(array2[i]);
                }
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void notesList_DoubleClick(object sender, EventArgs e)
        {
            string selected = ModID.Text;
            string title = notesList.GetItemText(notesList.SelectedItem);
            NoteViewer notesForm = new NoteViewer(title, selected);
            notesForm.Show();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
