namespace Synapse_Z
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            panel2 = new System.Windows.Forms.Panel();
            Minimize = new System.Windows.Forms.Button();
            Close = new System.Windows.Forms.Button();
            synlabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            TabClosingPrompt = new System.Windows.Forms.CheckBox();
            ClearEditorPrompt = new System.Windows.Forms.CheckBox();
            TopMostCheck = new System.Windows.Forms.CheckBox();
            UnlockFPS = new System.Windows.Forms.CheckBox();
            AutoInject = new System.Windows.Forms.CheckBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            KillRBLX = new System.Windows.Forms.Button();
            Reset = new System.Windows.Forms.Button();
            EnterKey = new System.Windows.Forms.Button();
            GetCurrentKey = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            panel2.Controls.Add(Minimize);
            panel2.Controls.Add(Close);
            panel2.Controls.Add(synlabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(330, 31);
            panel2.TabIndex = 2;
            panel2.MouseDown += panel1_MouseDown;
            panel2.MouseMove += panel1_MouseMove;
            panel2.MouseUp += panel1_MouseUp;
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
            Minimize.Location = new System.Drawing.Point(284, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new System.Drawing.Size(20, 23);
            Minimize.TabIndex = 4;
            Minimize.Text = "_";
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            Minimize.MouseEnter += FlatButton_MouseEnter;
            Minimize.MouseLeave += FlatButton_MouseLeave;
            // 
            // Close
            // 
            Close.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Close.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Close.ForeColor = System.Drawing.Color.White;
            Close.Location = new System.Drawing.Point(310, 0);
            Close.Name = "Close";
            Close.Size = new System.Drawing.Size(20, 23);
            Close.TabIndex = 3;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += CloseBtn_Click;
            Close.MouseEnter += FlatButton_MouseEnter;
            Close.MouseLeave += FlatButton_MouseLeave;
            // 
            // synlabel
            // 
            synlabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            synlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            synlabel.ForeColor = System.Drawing.Color.White;
            synlabel.Location = new System.Drawing.Point(33, 0);
            synlabel.Name = "synlabel";
            synlabel.Size = new System.Drawing.Size(252, 31);
            synlabel.TabIndex = 1;
            synlabel.Text = "Synapse X - Options";
            synlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            synlabel.Click += synlabel_Click;
            synlabel.MouseDown += panel1_MouseDown;
            synlabel.MouseMove += panel1_MouseMove;
            synlabel.MouseUp += panel1_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(23, 23);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TabClosingPrompt
            // 
            TabClosingPrompt.AutoSize = true;
            TabClosingPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TabClosingPrompt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TabClosingPrompt.ForeColor = System.Drawing.Color.White;
            TabClosingPrompt.Location = new System.Drawing.Point(17, 109);
            TabClosingPrompt.Name = "TabClosingPrompt";
            TabClosingPrompt.Size = new System.Drawing.Size(265, 23);
            TabClosingPrompt.TabIndex = 3;
            TabClosingPrompt.Text = "                           Tab Closing Prompt";
            TabClosingPrompt.UseVisualStyleBackColor = true;
            TabClosingPrompt.CheckedChanged += TabClosingPrompt_CheckedChanged;
            // 
            // ClearEditorPrompt
            // 
            ClearEditorPrompt.AutoSize = true;
            ClearEditorPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ClearEditorPrompt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ClearEditorPrompt.ForeColor = System.Drawing.Color.White;
            ClearEditorPrompt.Location = new System.Drawing.Point(17, 76);
            ClearEditorPrompt.Name = "ClearEditorPrompt";
            ClearEditorPrompt.Size = new System.Drawing.Size(265, 23);
            ClearEditorPrompt.TabIndex = 3;
            ClearEditorPrompt.Text = "                          Clear Editor Prompt";
            ClearEditorPrompt.UseVisualStyleBackColor = true;
            ClearEditorPrompt.CheckedChanged += ClearEditorPrompt_CheckedChanged;
            // 
            // TopMostCheck
            // 
            TopMostCheck.AutoSize = true;
            TopMostCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TopMostCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TopMostCheck.ForeColor = System.Drawing.Color.White;
            TopMostCheck.Location = new System.Drawing.Point(17, 142);
            TopMostCheck.Name = "TopMostCheck";
            TopMostCheck.Size = new System.Drawing.Size(265, 23);
            TopMostCheck.TabIndex = 3;
            TopMostCheck.Text = "                                            Top Most";
            TopMostCheck.UseVisualStyleBackColor = true;
            TopMostCheck.CheckedChanged += TopMost_CheckedChanged;
            // 
            // UnlockFPS
            // 
            UnlockFPS.AutoSize = true;
            UnlockFPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            UnlockFPS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UnlockFPS.ForeColor = System.Drawing.Color.White;
            UnlockFPS.Location = new System.Drawing.Point(17, 45);
            UnlockFPS.Name = "UnlockFPS";
            UnlockFPS.Size = new System.Drawing.Size(264, 23);
            UnlockFPS.TabIndex = 3;
            UnlockFPS.Text = "                                         Unlock FPS";
            UnlockFPS.UseVisualStyleBackColor = true;
            UnlockFPS.CheckedChanged += UnlockFPS_CheckedChanged;
            // 
            // AutoInject
            // 
            AutoInject.AutoSize = true;
            AutoInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AutoInject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AutoInject.ForeColor = System.Drawing.Color.White;
            AutoInject.Location = new System.Drawing.Point(17, 12);
            AutoInject.Name = "AutoInject";
            AutoInject.Size = new System.Drawing.Size(265, 23);
            AutoInject.TabIndex = 3;
            AutoInject.Text = "                                         Auto Inject";
            AutoInject.UseVisualStyleBackColor = true;
            AutoInject.CheckedChanged += AutoInject_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "chrome", "clouds", "crimson_editor", "dawn", "dreamweaver", "eclipse", "github", "iplastic", "katzenmilch", "kuroir", "solarized_light", "sqlserver", "textmate", "tomorrow", "xcode", "ambiance", "chaos", "clouds_midnight", "cobalt", "dracula", "gob", "gruvbox", "idle_fingers", "kr_theme", "merbivore", "merbivore_soft", "mono_industrial", "monokai", "pastel_on_dark", "solarized_dark", "terminal", "tomorrow_night", "tomorrow_night_blue", "tomorrow_night_bright", "tomorrow_night_eighties", "twilight" });
            comboBox1.Location = new System.Drawing.Point(17, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(273, 24);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(116, 228);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 15);
            label1.TabIndex = 5;
            label1.Text = "Editor Theme";
            label1.Click += label1_Click;
            // 
            // KillRBLX
            // 
            KillRBLX.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            KillRBLX.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            KillRBLX.FlatAppearance.BorderSize = 0;
            KillRBLX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            KillRBLX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            KillRBLX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            KillRBLX.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            KillRBLX.ForeColor = System.Drawing.Color.White;
            KillRBLX.Location = new System.Drawing.Point(50, 187);
            KillRBLX.Name = "KillRBLX";
            KillRBLX.Size = new System.Drawing.Size(205, 26);
            KillRBLX.TabIndex = 9;
            KillRBLX.Text = "Kill Roblox";
            KillRBLX.UseVisualStyleBackColor = false;
            KillRBLX.Click += KillRBLX_Click;
            // 
            // Reset
            // 
            Reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Reset.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Reset.FlatAppearance.BorderSize = 0;
            Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Reset.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Reset.ForeColor = System.Drawing.Color.White;
            Reset.Location = new System.Drawing.Point(50, 308);
            Reset.Name = "Reset";
            Reset.Size = new System.Drawing.Size(205, 26);
            Reset.TabIndex = 10;
            Reset.Text = "Reset Settings";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // EnterKey
            // 
            EnterKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            EnterKey.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            EnterKey.FlatAppearance.BorderSize = 0;
            EnterKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            EnterKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            EnterKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EnterKey.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EnterKey.ForeColor = System.Drawing.Color.White;
            EnterKey.Location = new System.Drawing.Point(50, 278);
            EnterKey.Name = "EnterKey";
            EnterKey.Size = new System.Drawing.Size(97, 26);
            EnterKey.TabIndex = 10;
            EnterKey.Text = "Set Current Key";
            EnterKey.UseVisualStyleBackColor = false;
            EnterKey.Click += EnterKey_Click;
            // 
            // GetCurrentKey
            // 
            GetCurrentKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            GetCurrentKey.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            GetCurrentKey.FlatAppearance.BorderSize = 0;
            GetCurrentKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            GetCurrentKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            GetCurrentKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            GetCurrentKey.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            GetCurrentKey.ForeColor = System.Drawing.Color.White;
            GetCurrentKey.Location = new System.Drawing.Point(158, 278);
            GetCurrentKey.Name = "GetCurrentKey";
            GetCurrentKey.Size = new System.Drawing.Size(97, 26);
            GetCurrentKey.TabIndex = 10;
            GetCurrentKey.Text = "Get Current Key";
            GetCurrentKey.UseVisualStyleBackColor = false;
            GetCurrentKey.Click += GetCurrentKey_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(GetCurrentKey);
            panel1.Controls.Add(EnterKey);
            panel1.Controls.Add(Reset);
            panel1.Controls.Add(KillRBLX);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(AutoInject);
            panel1.Controls.Add(UnlockFPS);
            panel1.Controls.Add(TopMostCheck);
            panel1.Controls.Add(ClearEditorPrompt);
            panel1.Controls.Add(TabClosingPrompt);
            panel1.Location = new System.Drawing.Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(306, 348);
            panel1.TabIndex = 4;
            // 
            // Options
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            ClientSize = new System.Drawing.Size(330, 397);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Options";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label synlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox TabClosingPrompt;
        private System.Windows.Forms.CheckBox ClearEditorPrompt;
        private System.Windows.Forms.CheckBox TopMostCheck;
        private System.Windows.Forms.CheckBox UnlockFPS;
        private System.Windows.Forms.CheckBox AutoInject;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KillRBLX;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button EnterKey;
        private System.Windows.Forms.Button GetCurrentKey;
        private System.Windows.Forms.Panel panel1;
    }
}