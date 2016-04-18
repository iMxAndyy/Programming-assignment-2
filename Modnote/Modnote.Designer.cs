namespace Modnote
{
    partial class Modnote
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
            this.modList = new System.Windows.Forms.ListBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.modOutput = new System.Windows.Forms.RichTextBox();
            this.modGroupBox = new System.Windows.Forms.GroupBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModButton = new System.Windows.Forms.Button();
            this.delModButton = new System.Windows.Forms.Button();
            this.infoGroupBox.SuspendLayout();
            this.modGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modList
            // 
            this.modList.FormattingEnabled = true;
            this.modList.Items.AddRange(new object[] {
            "CGP1005M",
            "CMP1005M",
            "CMP1123M",
            "CMP1124M",
            "CMP1125M",
            "CMP1127M",
            "CMP1129M"});
            this.modList.Location = new System.Drawing.Point(12, 19);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(237, 290);
            this.modList.TabIndex = 0;
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            this.modList.DoubleClick += new System.EventHandler(this.modList_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.modOutput);
            this.infoGroupBox.Location = new System.Drawing.Point(286, 28);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(310, 367);
            this.infoGroupBox.TabIndex = 16;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Module Information";
            // 
            // modOutput
            // 
            this.modOutput.Location = new System.Drawing.Point(11, 19);
            this.modOutput.Name = "modOutput";
            this.modOutput.Size = new System.Drawing.Size(287, 332);
            this.modOutput.TabIndex = 0;
            this.modOutput.Text = "";
            // 
            // modGroupBox
            // 
            this.modGroupBox.Controls.Add(this.delModButton);
            this.modGroupBox.Controls.Add(this.addModButton);
            this.modGroupBox.Controls.Add(this.modList);
            this.modGroupBox.Location = new System.Drawing.Point(11, 28);
            this.modGroupBox.Name = "modGroupBox";
            this.modGroupBox.Size = new System.Drawing.Size(261, 367);
            this.modGroupBox.TabIndex = 17;
            this.modGroupBox.TabStop = false;
            this.modGroupBox.Text = "Module List";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // addModButton
            // 
            this.addModButton.Location = new System.Drawing.Point(24, 328);
            this.addModButton.Name = "addModButton";
            this.addModButton.Size = new System.Drawing.Size(82, 23);
            this.addModButton.TabIndex = 1;
            this.addModButton.Text = "Add Module";
            this.addModButton.UseVisualStyleBackColor = true;
            this.addModButton.Click += new System.EventHandler(this.addModButton_Click);
            // 
            // delModButton
            // 
            this.delModButton.Location = new System.Drawing.Point(146, 328);
            this.delModButton.Name = "delModButton";
            this.delModButton.Size = new System.Drawing.Size(87, 23);
            this.delModButton.TabIndex = 2;
            this.delModButton.Text = "Delete Module";
            this.delModButton.UseVisualStyleBackColor = true;
            this.delModButton.Click += new System.EventHandler(this.delModButton_Click);
            // 
            // Modnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 407);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.modGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Modnote";
            this.Text = "Modnote";
            this.infoGroupBox.ResumeLayout(false);
            this.modGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox modList;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.GroupBox modGroupBox;
        private System.Windows.Forms.RichTextBox modOutput;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Button delModButton;
        private System.Windows.Forms.Button addModButton;
    }
}

