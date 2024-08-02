namespace Synapse_Z
{
    partial class ScriptHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptHub));
            panel2 = new System.Windows.Forms.Panel();
            MiniBtn = new System.Windows.Forms.Button();
            synlabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            Minimize = new System.Windows.Forms.Button();
            Maximize = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ScriptHubBox = new System.Windows.Forms.ListBox();
            DisplayBox = new System.Windows.Forms.PictureBox();
            Execute = new System.Windows.Forms.Button();
            CloseBtn = new System.Windows.Forms.Button();
            Description = new System.Windows.Forms.RichTextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DisplayBox).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            panel2.Controls.Add(MiniBtn);
            panel2.Controls.Add(synlabel);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Minimize);
            panel2.Controls.Add(Maximize);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(464, 31);
            panel2.TabIndex = 3;
            panel2.MouseDown += panel1_MouseDown;
            panel2.MouseMove += panel1_MouseMove;
            panel2.MouseUp += panel1_MouseUp;
            // 
            // MiniBtn
            // 
            MiniBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            MiniBtn.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            MiniBtn.FlatAppearance.BorderSize = 0;
            MiniBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            MiniBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MiniBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MiniBtn.ForeColor = System.Drawing.Color.White;
            MiniBtn.Location = new System.Drawing.Point(444, 0);
            MiniBtn.Name = "MiniBtn";
            MiniBtn.Size = new System.Drawing.Size(20, 23);
            MiniBtn.TabIndex = 5;
            MiniBtn.Text = "_";
            MiniBtn.UseVisualStyleBackColor = false;
            MiniBtn.Click += button1_Click;
            MiniBtn.MouseEnter += FlatButton_MouseEnter;
            MiniBtn.MouseLeave += FlatButton_MouseLeave;
            // 
            // synlabel
            // 
            synlabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            synlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            synlabel.ForeColor = System.Drawing.Color.White;
            synlabel.Location = new System.Drawing.Point(35, 0);
            synlabel.Name = "synlabel";
            synlabel.Size = new System.Drawing.Size(390, 31);
            synlabel.TabIndex = 1;
            synlabel.Text = "Synapse X - Script Hub";
            synlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            synlabel.MouseDown += panel1_MouseDown;
            synlabel.MouseMove += panel1_MouseMove;
            synlabel.MouseUp += panel1_MouseUp;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(774, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(20, 23);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // Minimize
            // 
            Minimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Minimize.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Minimize.FlatAppearance.BorderSize = 0;
            Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Minimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Minimize.ForeColor = System.Drawing.Color.White;
            Minimize.Location = new System.Drawing.Point(1375, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new System.Drawing.Size(20, 23);
            Minimize.TabIndex = 4;
            Minimize.Text = "_";
            Minimize.UseVisualStyleBackColor = false;
            // 
            // Maximize
            // 
            Maximize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Maximize.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Maximize.FlatAppearance.BorderSize = 0;
            Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Maximize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Maximize.ForeColor = System.Drawing.Color.White;
            Maximize.Location = new System.Drawing.Point(1401, 0);
            Maximize.Name = "Maximize";
            Maximize.Size = new System.Drawing.Size(20, 23);
            Maximize.TabIndex = 3;
            Maximize.Text = "M";
            Maximize.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(23, 23);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ScriptHubBox
            // 
            ScriptHubBox.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ScriptHubBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ScriptHubBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ScriptHubBox.ForeColor = System.Drawing.Color.White;
            ScriptHubBox.FormattingEnabled = true;
            ScriptHubBox.ItemHeight = 15;
            ScriptHubBox.Location = new System.Drawing.Point(12, 44);
            ScriptHubBox.Name = "ScriptHubBox";
            ScriptHubBox.Size = new System.Drawing.Size(133, 330);
            ScriptHubBox.TabIndex = 4;
            // 
            // DisplayBox
            // 
            DisplayBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            DisplayBox.Location = new System.Drawing.Point(151, 44);
            DisplayBox.Name = "DisplayBox";
            DisplayBox.Size = new System.Drawing.Size(301, 179);
            DisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            DisplayBox.TabIndex = 5;
            DisplayBox.TabStop = false;
            // 
            // Execute
            // 
            Execute.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Execute.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Execute.FlatAppearance.BorderSize = 0;
            Execute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Execute.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Execute.ForeColor = System.Drawing.Color.White;
            Execute.Location = new System.Drawing.Point(151, 348);
            Execute.Name = "Execute";
            Execute.Size = new System.Drawing.Size(145, 26);
            Execute.TabIndex = 7;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = false;
            Execute.Click += Execute_Click;
            Execute.MouseEnter += FlatButton_MouseEnter;
            Execute.MouseLeave += FlatButton_MouseLeave;
            Execute.MouseMove += panel1_MouseMove;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            CloseBtn.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CloseBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CloseBtn.ForeColor = System.Drawing.Color.White;
            CloseBtn.Location = new System.Drawing.Point(307, 348);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new System.Drawing.Size(145, 26);
            CloseBtn.TabIndex = 8;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            CloseBtn.MouseEnter += FlatButton_MouseEnter;
            CloseBtn.MouseLeave += FlatButton_MouseLeave;
            // 
            // Description
            // 
            Description.AcceptsTab = true;
            Description.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Description.ForeColor = System.Drawing.Color.White;
            Description.Location = new System.Drawing.Point(151, 229);
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            Description.Size = new System.Drawing.Size(301, 113);
            Description.TabIndex = 10;
            Description.Text = "";
            // 
            // ScriptHub
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            ClientSize = new System.Drawing.Size(464, 390);
            Controls.Add(Description);
            Controls.Add(CloseBtn);
            Controls.Add(Execute);
            Controls.Add(DisplayBox);
            Controls.Add(ScriptHubBox);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ScriptHub";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ScriptHub";
            TopMost = true;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DisplayBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Label synlabel;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.ListBox ScriptHubBox;
        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.RichTextBox Description;
    }
}