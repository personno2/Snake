
namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.labelFPS = new System.Windows.Forms.Label();
            this.labelActualFPStext = new System.Windows.Forms.Label();
            this.labelActualFPS = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1021, 81);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(270, 44);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Location = new System.Drawing.Point(1194, 132);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(355, 35);
            this.textBoxFPS.TabIndex = 1;
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(1020, 137);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(109, 30);
            this.labelFPS.TabIndex = 2;
            this.labelFPS.Text = "Target FPS";
            // 
            // labelActualFPStext
            // 
            this.labelActualFPStext.AutoSize = true;
            this.labelActualFPStext.Location = new System.Drawing.Point(1021, 178);
            this.labelActualFPStext.Name = "labelActualFPStext";
            this.labelActualFPStext.Size = new System.Drawing.Size(111, 30);
            this.labelActualFPStext.TabIndex = 3;
            this.labelActualFPStext.Text = "Actual FPS";
            // 
            // labelActualFPS
            // 
            this.labelActualFPS.AutoSize = true;
            this.labelActualFPS.Location = new System.Drawing.Point(1194, 178);
            this.labelActualFPS.Name = "labelActualFPS";
            this.labelActualFPS.Size = new System.Drawing.Size(35, 30);
            this.labelActualFPS.TabIndex = 4;
            this.labelActualFPS.Text = "60";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1032, 351);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(517, 548);
            this.checkedListBox1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.statsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1653, 38);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 1113);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelActualFPS);
            this.Controls.Add(this.labelActualFPStext);
            this.Controls.Add(this.labelFPS);
            this.Controls.Add(this.textBoxFPS);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Label labelActualFPStext;
        private System.Windows.Forms.Label labelActualFPS;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
    }
}

