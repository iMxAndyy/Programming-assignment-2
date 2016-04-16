namespace Modnote
{
    partial class Create
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.cancelCreateButton = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.noteName = new System.Windows.Forms.Label();
            this.variable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(26, 53);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "OK";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // cancelCreateButton
            // 
            this.cancelCreateButton.Location = new System.Drawing.Point(209, 53);
            this.cancelCreateButton.Name = "cancelCreateButton";
            this.cancelCreateButton.Size = new System.Drawing.Size(75, 23);
            this.cancelCreateButton.TabIndex = 1;
            this.cancelCreateButton.Text = "Cancel";
            this.cancelCreateButton.UseVisualStyleBackColor = true;
            this.cancelCreateButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(107, 15);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(190, 20);
            this.TitleBox.TabIndex = 2;
            // 
            // noteName
            // 
            this.noteName.AutoSize = true;
            this.noteName.Location = new System.Drawing.Point(12, 18);
            this.noteName.Name = "noteName";
            this.noteName.Size = new System.Drawing.Size(89, 13);
            this.noteName.TabIndex = 3;
            this.noteName.Text = "Enter Note Name";
            // 
            // variable
            // 
            this.variable.AutoSize = true;
            this.variable.Location = new System.Drawing.Point(134, 58);
            this.variable.Name = "variable";
            this.variable.Size = new System.Drawing.Size(35, 13);
            this.variable.TabIndex = 4;
            this.variable.Text = "label1";
            this.variable.Visible = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 95);
            this.Controls.Add(this.variable);
            this.Controls.Add(this.noteName);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.cancelCreateButton);
            this.Controls.Add(this.EnterButton);
            this.Name = "Create";
            this.Text = "Create Note";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button cancelCreateButton;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label noteName;
        private System.Windows.Forms.Label variable;
    }
}