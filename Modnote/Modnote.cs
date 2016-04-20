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
            string[] array1 = Directory.GetFiles("../../Resources"),//load all available modules here (with path)
                     array2 = new string[array1.Length];//array for module names without path

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = Path.GetFileNameWithoutExtension(array1[i]);//remove the path from the module names
            }
            for (int i = 0; i < array2.Length; i++)
            {
                modList.Items.Add(array2[i]);//add all modules names to the list
            }

        }
        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = modList.GetItemText(modList.SelectedItem),//when user clicks a module on the list get the name
                   location = "../../Resources/";
            location += click;
            location += ".txt";
            if (File.Exists(location))//if the file exists in the modules folder load it to the window
            {
                modOutput.Text = File.ReadAllText(location);//add all lines from the selected module file to the window
            }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();//closes the program
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits creditForm = new Credits();//opens the credits form
            creditForm.ShowDialog();
        }

        private void addModButton_Click(object sender, EventArgs e)
        {
            Modcreator newmodForm = new Modcreator();//opens the modcreator form
            newmodForm.ShowDialog();
            //everything below this runs when the user returns from the modcreator form
            modList.Items.Clear();//clears the list so it can be reloaded once the user finishes creating a module

            string[] array1 = Directory.GetFiles("../../Resources"),//reload the list the same was it was origionally loaded
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
            string click = modList.GetItemText(modList.SelectedItem),//get the module name that is currently selected
                   location = "../../Resources/";
            location += click;
            location += ".txt";
            if (modList.SelectedIndex >= 0 )//if the user has something selected do this otherwise do nothing
            {
                modList.Items.Clear();//clear the list
                File.Delete(location);//delete the selected module file

                string[] array1 = Directory.GetFiles("../../Resources"),//reload the list the same way it was origionally loaded
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
            if (modList.SelectedIndex >= 0)//if the user has something selected do this
            {
                string selected = modList.GetItemText(modList.SelectedItem);//get the selected modules name
                string title = "No Note Loaded";//default title for the noteviewer
                NoteViewer notesForm = new NoteViewer(title, selected);//open the noteviewer and send the module ID and the default title
                notesForm.ShowDialog();
            }
            
        }
    }
}
