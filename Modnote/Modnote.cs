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
    public partial class Modnote : Form
    {
        public Modnote()
        {
            InitializeComponent();
            string[] array1 = Directory.GetFiles("../../Resources"),
                     array2 = new string[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = Path.GetFileNameWithoutExtension(array1[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                modList.Items.Add(array2[i]);
            }

        }
        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = modList.GetItemText(modList.SelectedItem),
                   location = "../../Resources/";
            location += click;
            location += ".txt";
            if (File.Exists(location))
            {
                modOutput.Text = File.ReadAllText(location);
            }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits creditForm = new Credits();
            creditForm.ShowDialog();
        }

        private void addModButton_Click(object sender, EventArgs e)
        {
            Modcreator newmodForm = new Modcreator();
            newmodForm.ShowDialog();

            modList.Items.Clear();
            string[] array1 = Directory.GetFiles("../../Resources"),
                         array2 = new string[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = Path.GetFileNameWithoutExtension(array1[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                modList.Items.Add(array2[i]);
            }
        }

        private void delModButton_Click(object sender, EventArgs e)
        {
            string click = modList.GetItemText(modList.SelectedItem),
                   location = "../../Resources/";
            location += click;
            location += ".txt";
            if (modList.SelectedIndex >= 0 )
            {
                modList.Items.Clear();
                File.Delete(location);

                string[] array1 = Directory.GetFiles("../../Resources"),
                         array2 = new string[array1.Length];

                for (int i = 0; i < array1.Length; i++)
                {
                    array2[i] = Path.GetFileNameWithoutExtension(array1[i]);
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    modList.Items.Add(array2[i]);
                }
            }         
        }

        private void OpenModulebutton_Click(object sender, EventArgs e)
        {
            if (modList.GetItemText(modList.SelectedItem) != "")
            {
                string selected = modList.GetItemText(modList.SelectedItem);
                string title = "No Note Loaded";
                NoteViewer notesForm = new NoteViewer(title, selected);
                notesForm.ShowDialog();
                this.DialogResult = DialogResult.Cancel;
            }
            
        }
    }
}
