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
            string filename = "../../Resources/";//location of the module files
            filename += modName.Text;
            filename += ".txt";
            string[] content = InsertContentBox.Lines;//saves all entered information to this array
            StreamWriter File = new StreamWriter(filename);//saves a new file with the name and content provided by the user
            for (int i = 0; i < content.Length; i++)
            {
                File.WriteLine(content[i]);//saves the user entered module information from the content array
            }
            File.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();//closes the window
        }

        private void cancelNoteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();//closes the window
        }
    }
}
