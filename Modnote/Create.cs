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
            variable.Text = selected2;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            string title = TitleBox.Text;
            string selected = variable.Text;
            NoteViewer noteListForm = new NoteViewer(title,selected);
            noteListForm.Show();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
