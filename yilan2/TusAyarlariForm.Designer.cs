namespace ETsnake
{
    partial class TusAyarlariForm
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
            wasdButon = new Button();
            okButon = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // wasdButon
            // 
            wasdButon.BackColor = Color.Transparent;
            wasdButon.FlatAppearance.BorderSize = 0;
            wasdButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            wasdButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            wasdButon.FlatStyle = FlatStyle.Flat;
            wasdButon.Location = new Point(45, 244);
            wasdButon.Name = "wasdButon";
            wasdButon.Size = new Size(264, 265);
            wasdButon.TabIndex = 0;
            wasdButon.UseVisualStyleBackColor = false;
            wasdButon.Click += wasdButon_Click;
            wasdButon.MouseEnter += wasdButon_MouseEnter;
            wasdButon.MouseLeave += wasdButon_MouseLeave;
            // 
            // okButon
            // 
            okButon.BackColor = Color.Transparent;
            okButon.FlatAppearance.BorderSize = 0;
            okButon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            okButon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            okButon.FlatStyle = FlatStyle.Flat;
            okButon.Location = new Point(326, 244);
            okButon.Name = "okButon";
            okButon.Size = new Size(264, 265);
            okButon.TabIndex = 0;
            okButon.UseVisualStyleBackColor = false;
            okButon.Click += okButon_Click;
            okButon.MouseEnter += okButon_MouseEnter;
            okButon.MouseLeave += okButon_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.X;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(567, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 31);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TusAyarlariForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 644);
            Controls.Add(button1);
            Controls.Add(okButon);
            Controls.Add(wasdButon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TusAyarlariForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TusAyarlariForm";
            ResumeLayout(false);
        }

        #endregion

        private Button wasdButon;
        private Button okButon;
        private Button button1;
    }
}