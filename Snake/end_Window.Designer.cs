namespace Snake
{
    partial class end_Window
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
            this.death_Message_Label = new System.Windows.Forms.Label();
            this.max_Message_Label = new System.Windows.Forms.Label();
            this.points_Label = new System.Windows.Forms.Label();
            this.quit_Button = new System.Windows.Forms.Button();
            this.restart_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.Location = new System.Drawing.Point(90, 25);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(121, 25);
            this.title_Label.TabIndex = 0;
            this.title_Label.Text = "Game Over";
            // 
            // death_Message_Label
            // 
            this.death_Message_Label.AutoSize = true;
            this.death_Message_Label.Location = new System.Drawing.Point(97, 56);
            this.death_Message_Label.Name = "death_Message_Label";
            this.death_Message_Label.Size = new System.Drawing.Size(107, 25);
            this.death_Message_Label.TabIndex = 1;
            this.death_Message_Label.Text = "You Died!";
            // 
            // max_Message_Label
            // 
            this.max_Message_Label.AutoSize = true;
            this.max_Message_Label.Location = new System.Drawing.Point(97, 56);
            this.max_Message_Label.Name = "max_Message_Label";
            this.max_Message_Label.Size = new System.Drawing.Size(107, 25);
            this.max_Message_Label.TabIndex = 2;
            this.max_Message_Label.Text = "You Won!";
            // 
            // points_Label
            // 
            this.points_Label.AutoSize = true;
            this.points_Label.Location = new System.Drawing.Point(48, 87);
            this.points_Label.Name = "points_Label";
            this.points_Label.Size = new System.Drawing.Size(205, 25);
            this.points_Label.TabIndex = 3;
            this.points_Label.Text = "You Got ### Points.";
            // 
            // quit_Button
            // 
            this.quit_Button.Location = new System.Drawing.Point(25, 199);
            this.quit_Button.Name = "quit_Button";
            this.quit_Button.Size = new System.Drawing.Size(250, 75);
            this.quit_Button.TabIndex = 4;
            this.quit_Button.Text = "Quit";
            this.quit_Button.UseVisualStyleBackColor = true;
            this.quit_Button.Click += new System.EventHandler(this.quit_Button_Click);
            // 
            // restart_Button
            // 
            this.restart_Button.Location = new System.Drawing.Point(25, 118);
            this.restart_Button.Name = "restart_Button";
            this.restart_Button.Size = new System.Drawing.Size(250, 75);
            this.restart_Button.TabIndex = 5;
            this.restart_Button.Text = "Restart";
            this.restart_Button.UseVisualStyleBackColor = true;
            this.restart_Button.Click += new System.EventHandler(this.restart_Button_Click);
            // 
            // end_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.restart_Button);
            this.Controls.Add(this.quit_Button);
            this.Controls.Add(this.points_Label);
            this.Controls.Add(this.max_Message_Label);
            this.Controls.Add(this.death_Message_Label);
            this.Controls.Add(this.title_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "end_Window";
            this.Text = "end_Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Button quit_Button;
        private System.Windows.Forms.Button restart_Button;
        public System.Windows.Forms.Label death_Message_Label;
        public System.Windows.Forms.Label max_Message_Label;
        public System.Windows.Forms.Label points_Label;
    }
}