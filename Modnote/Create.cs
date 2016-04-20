using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modnote
{
    public partial class Create : Form
    {
        public Create(string selected2)
        {
            InitializeComponent();
            variable.Text = selected2;//loads the module name
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();//closes the window
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            string title = TitleBox.Text;
            string selected = variable.Text;
            NoteViewer noteListForm = new NoteViewer(title,selected);//opens the noteviewer again and sends the module name and the new note name
            noteListForm.Show();
            this.DialogResult = DialogResult.OK;
            this.Close();//closes the window
        }
    }
}
