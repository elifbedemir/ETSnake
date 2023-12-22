namespace ETsnake
{
    partial class SesAyarlariForm
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
            oyunSesButon = new Button();
            button2 = new Button();
            myTrackBar1 = new Vumetre.MyTrackBar();
            trackbar_label = new Label();
            SuspendLayout();
            // 
            // oyunSesButon
            // 
            oyunSesButon.BackColor = Color.Transparent;
            oyunSesButon.FlatAppearance.BorderSize = 0;
            oyunSesButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            oyunSesButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            oyunSesButon.FlatStyle = FlatStyle.Flat;
            oyunSesButon.Location = new Point(408, 256);
            oyunSesButon.Name = "oyunSesButon";
            oyunSesButon.Size = new Size(89, 94);
            oyunSesButon.TabIndex = 0;
            oyunSesButon.UseVisualStyleBackColor = false;
            oyunSesButon.Click += oyunSesButon_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.X;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(567, 12);
            button2.Name = "button2";
            button2.Size = new Size(38, 31);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // myTrackBar1
            // 
            myTrackBar1.BackColor = Color.Transparent;
            myTrackBar1.Location = new Point(391, 460);
            myTrackBar1.Maximum = 100;
            myTrackBar1.Name = "myTrackBar1";
            myTrackBar1.Size = new Size(205, 36);
            myTrackBar1.TabIndex = 10;
            myTrackBar1.TabStop = true;
            myTrackBar1.Scroll += myTrackBar1_Scroll;
            // 
            // trackbar_label
            // 
            trackbar_label.BackColor = Color.Transparent;
            trackbar_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            trackbar_label.ForeColor = Color.Black;
            trackbar_label.Location = new Point(334, 468);
            trackbar_label.Name = "trackbar_label";
            trackbar_label.Size = new Size(51, 23);
            trackbar_label.TabIndex = 11;
            trackbar_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SesAyarlariForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 644);
            Controls.Add(trackbar_label);
            Controls.Add(myTrackBar1);
            Controls.Add(button2);
            Controls.Add(oyunSesButon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SesAyarlariForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SesAyarlariForm";
            Load += SesAyarlariForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button oyunSesButon;
        private Button button2;
        private Vumetre.MyTrackBar myTrackBar1;
        private Label trackbar_label;
    }
}