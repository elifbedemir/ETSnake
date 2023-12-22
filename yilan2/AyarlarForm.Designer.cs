namespace ETsnake
{
    partial class AyarlarForm
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
            yeniButon = new Button();
            devamButon = new Button();
            tusButon = new Button();
            sesButon = new Button();
            renkButon = new Button();
            hakkindaButon = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // yeniButon
            // 
            yeniButon.BackColor = Color.Transparent;
            yeniButon.FlatAppearance.BorderSize = 0;
            yeniButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            yeniButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            yeniButon.FlatStyle = FlatStyle.Flat;
            yeniButon.Location = new Point(159, 166);
            yeniButon.Name = "yeniButon";
            yeniButon.Size = new Size(124, 115);
            yeniButon.TabIndex = 6;
            yeniButon.UseVisualStyleBackColor = false;
            yeniButon.Click += yeniButon_Click;
            yeniButon.MouseEnter += yeniButon_MouseEnter;
            // 
            // devamButon
            // 
            devamButon.BackColor = Color.Transparent;
            devamButon.FlatAppearance.BorderSize = 0;
            devamButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            devamButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            devamButon.FlatStyle = FlatStyle.Flat;
            devamButon.Location = new Point(343, 166);
            devamButon.Name = "devamButon";
            devamButon.Size = new Size(124, 115);
            devamButon.TabIndex = 6;
            devamButon.UseVisualStyleBackColor = false;
            devamButon.Click += devamButon_Click;
            devamButon.MouseEnter += yeniButon_MouseEnter;
            // 
            // tusButon
            // 
            tusButon.BackColor = Color.Transparent;
            tusButon.FlatAppearance.BorderSize = 0;
            tusButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            tusButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            tusButon.FlatStyle = FlatStyle.Flat;
            tusButon.Location = new Point(159, 322);
            tusButon.Name = "tusButon";
            tusButon.Size = new Size(124, 115);
            tusButon.TabIndex = 6;
            tusButon.UseVisualStyleBackColor = false;
            tusButon.Click += tusButon_Click;
            tusButon.MouseEnter += yeniButon_MouseEnter;
            // 
            // sesButon
            // 
            sesButon.BackColor = Color.Transparent;
            sesButon.FlatAppearance.BorderSize = 0;
            sesButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            sesButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            sesButon.FlatStyle = FlatStyle.Flat;
            sesButon.Location = new Point(343, 322);
            sesButon.Name = "sesButon";
            sesButon.Size = new Size(124, 115);
            sesButon.TabIndex = 6;
            sesButon.UseVisualStyleBackColor = false;
            sesButon.Click += sesButon_Click;
            sesButon.MouseEnter += yeniButon_MouseEnter;
            // 
            // renkButon
            // 
            renkButon.BackColor = Color.Transparent;
            renkButon.FlatAppearance.BorderSize = 0;
            renkButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            renkButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            renkButon.FlatStyle = FlatStyle.Flat;
            renkButon.Location = new Point(159, 482);
            renkButon.Name = "renkButon";
            renkButon.Size = new Size(124, 115);
            renkButon.TabIndex = 6;
            renkButon.UseVisualStyleBackColor = false;
            renkButon.Click += renkButon_Click;
            renkButon.MouseEnter += yeniButon_MouseEnter;
            // 
            // hakkindaButon
            // 
            hakkindaButon.BackColor = Color.Transparent;
            hakkindaButon.FlatAppearance.BorderSize = 0;
            hakkindaButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            hakkindaButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            hakkindaButon.FlatStyle = FlatStyle.Flat;
            hakkindaButon.Location = new Point(343, 482);
            hakkindaButon.Name = "hakkindaButon";
            hakkindaButon.Size = new Size(124, 115);
            hakkindaButon.TabIndex = 6;
            hakkindaButon.UseVisualStyleBackColor = false;
            hakkindaButon.Click += hakkindaButon_Click;
            hakkindaButon.MouseEnter += yeniButon_MouseEnter;
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
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AyarlarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ayarlarMenu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 644);
            Controls.Add(button2);
            Controls.Add(hakkindaButon);
            Controls.Add(sesButon);
            Controls.Add(devamButon);
            Controls.Add(renkButon);
            Controls.Add(tusButon);
            Controls.Add(yeniButon);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "AyarlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AyarlarForm";
            Load += AyarlarForm_Load;
            KeyDown += AyarlarForm_KeyDown;
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button yeniButon;
        private Button devamButon;
        private Button tusButon;
        private Button sesButon;
        private Button renkButon;
        private Button hakkindaButon;
        private Button button2;
    }
}