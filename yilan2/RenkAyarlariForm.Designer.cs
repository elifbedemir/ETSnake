namespace ETsnake
{
    partial class RenkAyarlariForm
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
            listView4 = new ListView();
            listView3 = new ListView();
            listView2 = new ListView();
            button2 = new Button();
            lbl_arkaplanrenk = new Label();
            SuspendLayout();
            // 
            // listView4
            // 
            listView4.BorderStyle = BorderStyle.None;
            listView4.Location = new Point(275, 509);
            listView4.MultiSelect = false;
            listView4.Name = "listView4";
            listView4.Size = new Size(302, 106);
            listView4.TabIndex = 0;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.SelectedIndexChanged += listView4_SelectedIndexChanged;
            // 
            // listView3
            // 
            listView3.BorderStyle = BorderStyle.None;
            listView3.Location = new Point(275, 383);
            listView3.MultiSelect = false;
            listView3.Name = "listView3";
            listView3.Size = new Size(302, 106);
            listView3.TabIndex = 0;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // listView2
            // 
            listView2.BorderStyle = BorderStyle.None;
            listView2.Location = new Point(275, 257);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(302, 106);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.ItemSelectionChanged += listView2_ItemSelectionChanged;
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
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbl_arkaplanrenk
            // 
            lbl_arkaplanrenk.Location = new Point(275, 132);
            lbl_arkaplanrenk.Name = "lbl_arkaplanrenk";
            lbl_arkaplanrenk.Size = new Size(302, 106);
            lbl_arkaplanrenk.TabIndex = 11;
            lbl_arkaplanrenk.Click += lbl_arkaplanrenk_Click;
            // 
            // RenkAyarlariForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.renkSecimiArka;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 644);
            Controls.Add(lbl_arkaplanrenk);
            Controls.Add(button2);
            Controls.Add(listView2);
            Controls.Add(listView3);
            Controls.Add(listView4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RenkAyarlariForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RenkAyarlariForm";
            Load += RenkAyarlariForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListView listView4;
        private ListView listView3;
        private ListView listView2;
        private Button button2;
        private Label lbl_arkaplanrenk;
    }
}