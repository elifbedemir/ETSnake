namespace ETsnake
{
    partial class HakkindaForm
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
            components = new System.ComponentModel.Container();
            button2 = new Button();
            btn_guncelle = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_isimler = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
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
            // btn_guncelle
            // 
            btn_guncelle.BackColor = Color.Transparent;
            btn_guncelle.FlatAppearance.BorderSize = 0;
            btn_guncelle.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_guncelle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_guncelle.FlatStyle = FlatStyle.Flat;
            btn_guncelle.Location = new Point(392, 138);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(168, 54);
            btn_guncelle.TabIndex = 10;
            btn_guncelle.UseVisualStyleBackColor = false;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // lbl_isimler
            // 
            lbl_isimler.BackColor = Color.Transparent;
            lbl_isimler.Font = new Font("Segoe UI", 38F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_isimler.Location = new Point(-2, 364);
            lbl_isimler.Name = "lbl_isimler";
            lbl_isimler.Size = new Size(633, 74);
            lbl_isimler.TabIndex = 11;
            lbl_isimler.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(-2, 569);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 74);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(-4, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 74);
            panel1.TabIndex = 12;
            // 
            // HakkindaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hakkindaArkaplan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 644);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btn_guncelle);
            Controls.Add(button2);
            Controls.Add(lbl_isimler);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HakkindaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HakkindaForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button btn_guncelle;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_isimler;
        private Panel panel2;
        private Panel panel1;
    }
}