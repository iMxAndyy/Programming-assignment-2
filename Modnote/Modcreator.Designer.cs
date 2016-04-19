namespace Modnote
{
    partial class Modcreator
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
            this.modID = new System.Windows.Forms.GroupBox();
            this.cancelNoteButton = new System.Windows.Forms.Button();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.InsertContentBox = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.modName = new System.Windows.Forms.TextBox();
            this.modID.SuspendLayout();
            this.SuspendLayout();
            // 
            // modID
            // 
            this.modID.Controls.Add(this.modName);
            this.modID.Controls.Add(this.nameLabel);
            this.modID.Controls.Add(this.cancelNoteButton);
            this.modID.Controls.Add(this.saveNoteButton);
            this.modID.Controls.Add(this.InsertContentBox);
            this.modID.Location = new System.Drawing.Point(5, 5);
            this.modID.Name = "modID";
            this.modID.Size = new System.Drawing.Size(432, 345);
            this.modID.TabIndex = 2;
            this.modID.TabStop = false;
            // 
            // cancelNoteButton
            // 
            this.cancelNoteButton.Location = new System.Drawing.Point(296, 316);
            this.cancelNoteButton.Name = "cancelNoteButton";
            this.cancelNoteButton.Size = new System.Drawing.Size(80, 23);
            this.cancelNoteButton.TabIndex = 3;
            this.cancelNoteButton.Text = "Cancel";
            this.cancelNoteButton.UseVisualStyleBackColor = true;
            this.cancelNoteButton.Click += new System.EventHandler(this.cancelNoteButton_Click);
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.Location = new System.Drawing.Point(44, 316);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(79, 23);
            this.saveNoteButton.TabIndex = 1;
            this.saveNoteButton.Text = "Save Module";
            this.saveNoteButton.UseVisualStyleBackColor = true;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // InsertContentBox
            // 
            this.InsertContentBox.Location = new System.Drawing.Point(6, 44);
            this.InsertContentBox.Name = "InsertContentBox";
            this.InsertContentBox.Size = new System.Drawing.Size(420, 266);
            this.InsertContentBox.TabIndex = 0;
            this.InsertContentBox.Text = "CODE\n<Enter Text Here>\nTITLE\n<Enter Text Here>\nSYNOPSIS\n<Enter Text Here>\nLO\n<Ent" +
    "er Text Here>\nASSIGNMENT\n<Enter Text Here>";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Module Name:";
            // 
            // modName
            // 
            this.modName.Location = new System.Drawing.Point(89, 18);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(236, 20);
            this.modName.TabIndex = 11;
            // 
            // Modcreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 358);
            this.Controls.Add(this.modID);
            this.Name = "Modcreator";
            this.Text = "Add module";
            this.modID.ResumeLayout(false);
            this.modID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modID;
        private System.Windows.Forms.Button cancelNoteButton;
        private System.Windows.Forms.Button saveNoteButton;
        private System.Windows.Forms.RichTextBox InsertContentBox;
        private System.Windows.Forms.TextBox modName;
        private System.Windows.Forms.Label nameLabel;
    }
}