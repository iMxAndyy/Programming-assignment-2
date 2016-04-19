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
    public partial class Modcreator : Form
    {
        public Modcreator()
        {
            InitializeComponent();
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            string filename = "../../Resources/";
            filename += modName.Text;
            filename += ".txt";
            string[] content = InsertContentBox.Lines;
            StreamWriter File = new StreamWriter(filename);
            for (int i = 0; i < content.Length; i++)
            {
                File.WriteLine(content[i]);
            }
            File.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelNoteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
