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
        }
        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = modList.GetItemText(modList.SelectedItem),
                   output = "null";

            if (click == "CGP1005M")
            {
                output = Properties.Resources.CGP1005M;
            }
            else if (click == "CMP1005M")
            {
                output = Properties.Resources.CMP1005M;
            }
            else if (click == "CMP1123M")
            {
                output = Properties.Resources.CMP1123M;
            }
            else if (click == "CMP1124M")
            {
                output = Properties.Resources.CMP1124M;
            }
            else if (click == "CMP1125M")
            {
                output = Properties.Resources.CMP1125M;
            }
            else if (click == "CMP1127M")
            {
                output = Properties.Resources.CMP1127M;
            }
            else if (click == "CMP1129M")
            {
                output = Properties.Resources.CMP1129M;
            }
            modOutput.Text = output;
        }
        private void modList_Click(object sender, EventArgs e)
        {
            string selected = modList.GetItemText(modList.SelectedItem);
            string title = "No Note Loaded";
            NoteViewer noteListForm = new NoteViewer(title, selected);
            noteListForm.ShowDialog();
            this.DialogResult = DialogResult.Cancel;
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
    }
}
