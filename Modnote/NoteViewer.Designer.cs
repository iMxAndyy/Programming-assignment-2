namespace Modnote
{
    partial class NoteViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteViewer));
            this.modID = new System.Windows.Forms.GroupBox();
            this.clearNoteButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.createNoteButton = new System.Windows.Forms.Button();
            this.cancelNoteButton = new System.Windows.Forms.Button();
            this.loadNoteButton = new System.Windows.Forms.Button();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.InsertNoteBox = new System.Windows.Forms.RichTextBox();
            this.modID.SuspendLayout();
            this.SuspendLayout();
            // 
            // modID
            // 
            this.modID.Controls.Add(this.clearNoteButton);
            this.modID.Controls.Add(this.nameLabel);
            this.modID.Controls.Add(this.createNoteButton);
            this.modID.Controls.Add(this.cancelNoteButton);
            this.modID.Controls.Add(this.loadNoteButton);
            this.modID.Controls.Add(this.saveNoteButton);
            this.modID.Controls.Add(this.InsertNoteBox);
            this.modID.Location = new System.Drawing.Point(12, 12);
            this.modID.Name = "modID";
            this.modID.Size = new System.Drawing.Size(432, 345);
            this.modID.TabIndex = 1;
            this.modID.TabStop = false;
            this.modID.Text = "Change To Module ID";
            // 
            // clearNoteButton
            // 
            this.clearNoteButton.Location = new System.Drawing.Point(260, 317);
            this.clearNoteButton.Name = "clearNoteButton";
            this.clearNoteButton.Size = new System.Drawing.Size(75, 23);
            this.clearNoteButton.TabIndex = 10;
            this.clearNoteButton.Text = "Clear Note";
            this.clearNoteButton.UseVisualStyleBackColor = true;
            this.clearNoteButton.Click += new System.EventHandler(this.clearNoteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "No Note Loaded";
            // 
            // createNoteButton
            // 
            this.createNoteButton.Location = new System.Drawing.Point(16, 316);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(75, 23);
            this.createNoteButton.TabIndex = 4;
            this.createNoteButton.Text = "Create Note";
            this.createNoteButton.UseVisualStyleBackColor = true;
            this.createNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // cancelNoteButton
            // 
            this.cancelNoteButton.Location = new System.Drawing.Point(341, 316);
            this.cancelNoteButton.Name = "cancelNoteButton";
            this.cancelNoteButton.Size = new System.Drawing.Size(75, 23);
            this.cancelNoteButton.TabIndex = 3;
            this.cancelNoteButton.Text = "Cancel";
            this.cancelNoteButton.UseVisualStyleBackColor = true;
            this.cancelNoteButton.Click += new System.EventHandler(this.cancelNoteButton_Click);
            // 
            // loadNoteButton
            // 
            this.loadNoteButton.Location = new System.Drawing.Point(97, 316);
            this.loadNoteButton.Name = "loadNoteButton";
            this.loadNoteButton.Size = new System.Drawing.Size(75, 23);
            this.loadNoteButton.TabIndex = 2;
            this.loadNoteButton.Text = "Load Note";
            this.loadNoteButton.UseVisualStyleBackColor = true;
            this.loadNoteButton.Click += new System.EventHandler(this.LoadNoteButton_Click);
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.Location = new System.Drawing.Point(178, 316);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(75, 23);
            this.saveNoteButton.TabIndex = 1;
            this.saveNoteButton.Text = "Save Note";
            this.saveNoteButton.UseVisualStyleBackColor = true;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // InsertNoteBox
            // 
            this.InsertNoteBox.Location = new System.Drawing.Point(6, 44);
            this.InsertNoteBox.Name = "InsertNoteBox";
            this.InsertNoteBox.Size = new System.Drawing.Size(420, 266);
            this.InsertNoteBox.TabIndex = 0;
            this.InsertNoteBox.Text = resources.GetString("InsertNoteBox.Text");
            // 
            // NoteViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 368);
            this.Controls.Add(this.modID);
            this.Name = "NoteViewer";
            this.Text = "Note Viewer";
            this.TopMost = true;
            this.modID.ResumeLayout(false);
            this.modID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modID;
        private System.Windows.Forms.Button cancelNoteButton;
        private System.Windows.Forms.Button loadNoteButton;
        private System.Windows.Forms.Button saveNoteButton;
        private System.Windows.Forms.RichTextBox InsertNoteBox;
        private System.Windows.Forms.Button createNoteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button clearNoteButton;
    }
}