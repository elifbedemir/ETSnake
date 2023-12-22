namespace ETsnake
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
            components = new System.ComponentModel.Container();
            oyunAlani = new Panel();
            menuStrip1 = new MenuStrip();
            yeniOyunToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            puanLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            rekorLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // oyunAlani
            // 
            oyunAlani.BackgroundImageLayout = ImageLayout.Stretch;
            oyunAlani.Location = new Point(0, 24);
            oyunAlani.Name = "oyunAlani";
            oyunAlani.Size = new Size(600, 601);
            oyunAlani.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem, ayarlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            yeniOyunToolStripMenuItem.Size = new Size(73, 20);
            yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            yeniOyunToolStripMenuItem.Click += yeniOyunToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(56, 20);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            ayarlarToolStripMenuItem.Click += ayarlarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(611, 64);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 1;
            label1.Text = "PUAN";
            // 
            // puanLabel
            // 
            puanLabel.AutoSize = true;
            puanLabel.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold);
            puanLabel.ForeColor = Color.Red;
            puanLabel.Location = new Point(741, 64);
            puanLabel.Name = "puanLabel";
            puanLabel.Size = new Size(36, 37);
            puanLabel.TabIndex = 2;
            puanLabel.Text = "0";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(611, 253);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 1;
            label2.Text = "REKOR";
            // 
            // rekorLabel
            // 
            rekorLabel.AutoSize = true;
            rekorLabel.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold);
            rekorLabel.ForeColor = Color.Red;
            rekorLabel.Location = new Point(741, 253);
            rekorLabel.Name = "rekorLabel";
            rekorLabel.Size = new Size(36, 37);
            rekorLabel.TabIndex = 2;
            rekorLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 625);
            Controls.Add(menuStrip1);
            Controls.Add(oyunAlani);
            Controls.Add(rekorLabel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(puanLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E.T. Snake";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel oyunAlani;
        private Label label1;
        private Label puanLabel;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label rekorLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniOyunToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
    }
}
