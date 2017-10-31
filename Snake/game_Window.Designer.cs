namespace Snake
{
    partial class game_Window
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
            this.components = new System.ComponentModel.Container();
            this.controls_Group_Box = new System.Windows.Forms.GroupBox();
            this.controls_Label = new System.Windows.Forms.Label();
            this.game_Playing_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.controls_Group_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // controls_Group_Box
            // 
            this.controls_Group_Box.Controls.Add(this.controls_Label);
            this.controls_Group_Box.Location = new System.Drawing.Point(0, 600);
            this.controls_Group_Box.Name = "controls_Group_Box";
            this.controls_Group_Box.Size = new System.Drawing.Size(600, 100);
            this.controls_Group_Box.TabIndex = 0;
            this.controls_Group_Box.TabStop = false;
            this.controls_Group_Box.Text = "Controls";
            // 
            // controls_Label
            // 
            this.controls_Label.AutoSize = true;
            this.controls_Label.Location = new System.Drawing.Point(115, 45);
            this.controls_Label.Name = "controls_Label";
            this.controls_Label.Size = new System.Drawing.Size(371, 25);
            this.controls_Label.TabIndex = 1;
            this.controls_Label.Text = "Press Space to Start, Press X to Quit.";
            // 
            // game_Playing_Timer
            // 
            this.game_Playing_Timer.Interval = 50;
            this.game_Playing_Timer.Tick += new System.EventHandler(this.game_Playing_Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Painter);
            // 
            // game_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controls_Group_Box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "game_Window";
            this.Text = "game_Window";
            this.Load += new System.EventHandler(this.game_Window_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Window_KeyUp);
            this.controls_Group_Box.ResumeLayout(false);
            this.controls_Group_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controls_Group_Box;
        private System.Windows.Forms.Label controls_Label;
        private System.Windows.Forms.Timer game_Playing_Timer;
        private System.Windows.Forms.PictureBox food_Item;
        private System.Windows.Forms.Panel panel1;
    }
}