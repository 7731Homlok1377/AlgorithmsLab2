namespace HanoiTowers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstHamleler = new System.Windows.Forms.ListBox();
            this.pbKule1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oynatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.pbKule2 = new System.Windows.Forms.PictureBox();
            this.pbKule3 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbKule1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule3)).BeginInit();
            this.SuspendLayout();
            // 
            // lstHamleler
            // 
            this.lstHamleler.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHamleler.FormattingEnabled = true;
            this.lstHamleler.ItemHeight = 19;
            this.lstHamleler.Location = new System.Drawing.Point(940, 160);
            this.lstHamleler.Margin = new System.Windows.Forms.Padding(4);
            this.lstHamleler.Name = "lstHamleler";
            this.lstHamleler.Size = new System.Drawing.Size(242, 479);
            this.lstHamleler.TabIndex = 0;
            // 
            // pbKule1
            // 
            this.pbKule1.Image = ((System.Drawing.Image)(resources.GetObject("pbKule1.Image")));
            this.pbKule1.Location = new System.Drawing.Point(269, 169);
            this.pbKule1.Margin = new System.Windows.Forms.Padding(4);
            this.pbKule1.Name = "pbKule1";
            this.pbKule1.Size = new System.Drawing.Size(155, 475);
            this.pbKule1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKule1.TabIndex = 1;
            this.pbKule1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1214, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtDurum
            // 
            this.txtDurum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDurum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(54, 20);
            this.txtDurum.Text = "Durum";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oynatToolStripMenuItem,
            this.btnYeni});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oynatToolStripMenuItem
            // 
            this.oynatToolStripMenuItem.AutoSize = false;
            this.oynatToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oynatToolStripMenuItem.Name = "oynatToolStripMenuItem";
            this.oynatToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.oynatToolStripMenuItem.Text = "Play";
            this.oynatToolStripMenuItem.Click += new System.EventHandler(this.oynatToolStripMenuItem_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(99, 24);
            this.btnYeni.Text = "New game";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // pbKule2
            // 
            this.pbKule2.Image = ((System.Drawing.Image)(resources.GetObject("pbKule2.Image")));
            this.pbKule2.Location = new System.Drawing.Point(504, 169);
            this.pbKule2.Margin = new System.Windows.Forms.Padding(4);
            this.pbKule2.Name = "pbKule2";
            this.pbKule2.Size = new System.Drawing.Size(161, 475);
            this.pbKule2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKule2.TabIndex = 4;
            this.pbKule2.TabStop = false;
            // 
            // pbKule3
            // 
            this.pbKule3.Image = ((System.Drawing.Image)(resources.GetObject("pbKule3.Image")));
            this.pbKule3.Location = new System.Drawing.Point(717, 169);
            this.pbKule3.Margin = new System.Windows.Forms.Padding(4);
            this.pbKule3.Name = "pbKule3";
            this.pbKule3.Size = new System.Drawing.Size(163, 475);
            this.pbKule3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKule3.TabIndex = 5;
            this.pbKule3.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(1010, 106);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 26);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "All steps";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1214, 690);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pbKule3);
            this.Controls.Add(this.pbKule2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbKule1);
            this.Controls.Add(this.lstHamleler);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hanoi Towers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKule1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKule3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHamleler;
        private System.Windows.Forms.PictureBox pbKule1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtDurum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnYeni;
        private System.Windows.Forms.PictureBox pbKule2;
        private System.Windows.Forms.PictureBox pbKule3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ToolStripMenuItem oynatToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

