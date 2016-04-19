namespace Modnote
{
    partial class LoadNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notesList = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ModID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notesList
            // 
            this.notesList.FormattingEnabled = true;
            this.notesList.Location = new System.Drawing.Point(10, 25);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(178, 134);
            this.notesList.TabIndex = 0;
            this.notesList.DoubleClick += new System.EventHandler(this.notesList_DoubleClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(63, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ModID
            // 
            this.ModID.AutoSize = true;
            this.ModID.Location = new System.Drawing.Point(12, 9);
            this.ModID.Name = "ModID";
            this.ModID.Size = new System.Drawing.Size(63, 13);
            this.ModID.TabIndex = 2;
            this.ModID.Text = "Will change";
            // 
            // LoadNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 215);
            this.Controls.Add(this.ModID);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.notesList);
            this.Name = "LoadNote";
            this.Text = "Notes List";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox notesList;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label ModID;
    }
}