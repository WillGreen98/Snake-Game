namespace Snake
{
    partial class start_Form
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
            this.title_Label = new System.Windows.Forms.Label();
            this.start_Button = new System.Windows.Forms.Button();
            this.quit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.Location = new System.Drawing.Point(115, 25);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(73, 25);
            this.title_Label.TabIndex = 0;
            this.title_Label.Text = "Snake";
            // 
            // start_Button
            // 
            this.start_Button.Location = new System.Drawing.Point(25, 75);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(250, 75);
            this.start_Button.TabIndex = 1;
            this.start_Button.Text = "Start";
            this.start_Button.UseVisualStyleBackColor = true;
            this.start_Button.Click += new System.EventHandler(this.start_Button_Click);
            // 
            // quit_Button
            // 
            this.quit_Button.Location = new System.Drawing.Point(25, 175);
            this.quit_Button.Name = "quit_Button";
            this.quit_Button.Size = new System.Drawing.Size(250, 75);
            this.quit_Button.TabIndex = 2;
            this.quit_Button.Text = "Quit";
            this.quit_Button.UseVisualStyleBackColor = true;
            this.quit_Button.Click += new System.EventHandler(this.quit_Button_Click);
            // 
            // start_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.quit_Button);
            this.Controls.Add(this.start_Button);
            this.Controls.Add(this.title_Label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "start_Form";
            this.Text = "Start Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.Button quit_Button;
    }
}

