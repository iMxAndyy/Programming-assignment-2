namespace Modnote
{
    partial class Credits
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
            this.Author = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(56, 25);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(174, 13);
            this.Author.TabIndex = 0;
            this.Author.Text = "Program By: Andy Smith(15565869)";
            this.Author.Click += new System.EventHandler(this.label1_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(102, 52);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Author);
            this.Name = "Credits";
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Button OK;
    }
}