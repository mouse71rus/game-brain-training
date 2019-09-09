namespace PersonalTask
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DifficultyPanel = new System.Windows.Forms.GroupBox();
            this.rb_OnlyHard = new System.Windows.Forms.RadioButton();
            this.rb_Hard = new System.Windows.Forms.RadioButton();
            this.rb_Normal = new System.Windows.Forms.RadioButton();
            this.rb_Easy = new System.Windows.Forms.RadioButton();
            this.Apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Timeout5 = new System.Windows.Forms.RadioButton();
            this.Timeout7 = new System.Windows.Forms.RadioButton();
            this.Timeout10 = new System.Windows.Forms.RadioButton();
            this.Timeout3 = new System.Windows.Forms.RadioButton();
            this.pb_20 = new System.Windows.Forms.PictureBox();
            this.pb_16 = new System.Windows.Forms.PictureBox();
            this.pb_12 = new System.Windows.Forms.PictureBox();
            this.pb_8 = new System.Windows.Forms.PictureBox();
            this.btn_GetInfoAboutit1 = new LibraryUserControls.btn_GetInfoAboutit();
            this.DifficultyPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(134, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 410);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(638, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 410);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 5);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 5);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Настройки";
            // 
            // DifficultyPanel
            // 
            this.DifficultyPanel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyPanel.Controls.Add(this.rb_OnlyHard);
            this.DifficultyPanel.Controls.Add(this.rb_Hard);
            this.DifficultyPanel.Controls.Add(this.rb_Normal);
            this.DifficultyPanel.Controls.Add(this.rb_Easy);
            this.DifficultyPanel.Controls.Add(this.pb_20);
            this.DifficultyPanel.Controls.Add(this.pb_16);
            this.DifficultyPanel.Controls.Add(this.pb_12);
            this.DifficultyPanel.Controls.Add(this.pb_8);
            this.DifficultyPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DifficultyPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DifficultyPanel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyPanel.ForeColor = System.Drawing.Color.Crimson;
            this.DifficultyPanel.Location = new System.Drawing.Point(350, 12);
            this.DifficultyPanel.Name = "DifficultyPanel";
            this.DifficultyPanel.Size = new System.Drawing.Size(282, 369);
            this.DifficultyPanel.TabIndex = 6;
            this.DifficultyPanel.TabStop = false;
            this.DifficultyPanel.Text = "Сложность";
            // 
            // rb_OnlyHard
            // 
            this.rb_OnlyHard.AutoSize = true;
            this.rb_OnlyHard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_OnlyHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_OnlyHard.Location = new System.Drawing.Point(0, 303);
            this.rb_OnlyHard.Name = "rb_OnlyHard";
            this.rb_OnlyHard.Size = new System.Drawing.Size(131, 32);
            this.rb_OnlyHard.TabIndex = 24;
            this.rb_OnlyHard.Tag = "20";
            this.rb_OnlyHard.Text = "Невозможно";
            this.rb_OnlyHard.UseVisualStyleBackColor = true;
            this.rb_OnlyHard.Click += new System.EventHandler(this.EditDifficulty_CheckedChanged);
            // 
            // rb_Hard
            // 
            this.rb_Hard.AutoSize = true;
            this.rb_Hard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Hard.Location = new System.Drawing.Point(39, 224);
            this.rb_Hard.Name = "rb_Hard";
            this.rb_Hard.Size = new System.Drawing.Size(92, 32);
            this.rb_Hard.TabIndex = 23;
            this.rb_Hard.Tag = "16";
            this.rb_Hard.Text = "Сложно";
            this.rb_Hard.UseVisualStyleBackColor = true;
            this.rb_Hard.Click += new System.EventHandler(this.EditDifficulty_CheckedChanged);
            // 
            // rb_Normal
            // 
            this.rb_Normal.AutoSize = true;
            this.rb_Normal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Normal.Location = new System.Drawing.Point(9, 134);
            this.rb_Normal.Name = "rb_Normal";
            this.rb_Normal.Size = new System.Drawing.Size(122, 32);
            this.rb_Normal.TabIndex = 22;
            this.rb_Normal.Tag = "12";
            this.rb_Normal.Text = "Нормально";
            this.rb_Normal.UseVisualStyleBackColor = true;
            this.rb_Normal.Click += new System.EventHandler(this.EditDifficulty_CheckedChanged);
            // 
            // rb_Easy
            // 
            this.rb_Easy.AutoSize = true;
            this.rb_Easy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Easy.Checked = true;
            this.rb_Easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Easy.Location = new System.Drawing.Point(53, 48);
            this.rb_Easy.Name = "rb_Easy";
            this.rb_Easy.Size = new System.Drawing.Size(78, 32);
            this.rb_Easy.TabIndex = 21;
            this.rb_Easy.TabStop = true;
            this.rb_Easy.Tag = "8";
            this.rb_Easy.Text = "Легко";
            this.rb_Easy.UseVisualStyleBackColor = true;
            this.rb_Easy.Click += new System.EventHandler(this.EditDifficulty_CheckedChanged);
            // 
            // Apply
            // 
            this.Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apply.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Apply.Location = new System.Drawing.Point(11, 364);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(117, 33);
            this.Apply.TabIndex = 7;
            this.Apply.Text = "Применить";
            this.Apply.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Timeout5);
            this.groupBox1.Controls.Add(this.Timeout7);
            this.groupBox1.Controls.Add(this.Timeout10);
            this.groupBox1.Controls.Add(this.Timeout3);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(19, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время показа";
            // 
            // Timeout5
            // 
            this.Timeout5.AutoSize = true;
            this.Timeout5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Timeout5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timeout5.Location = new System.Drawing.Point(19, 71);
            this.Timeout5.Name = "Timeout5";
            this.Timeout5.Size = new System.Drawing.Size(98, 30);
            this.Timeout5.TabIndex = 24;
            this.Timeout5.Tag = "5";
            this.Timeout5.Text = "5 секунд";
            this.Timeout5.UseVisualStyleBackColor = true;
            this.Timeout5.CheckedChanged += new System.EventHandler(this.Timeout_CheckedChanged);
            // 
            // Timeout7
            // 
            this.Timeout7.AutoSize = true;
            this.Timeout7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Timeout7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timeout7.Location = new System.Drawing.Point(19, 107);
            this.Timeout7.Name = "Timeout7";
            this.Timeout7.Size = new System.Drawing.Size(98, 30);
            this.Timeout7.TabIndex = 23;
            this.Timeout7.Tag = "7";
            this.Timeout7.Text = "7 секунд";
            this.Timeout7.UseVisualStyleBackColor = true;
            this.Timeout7.CheckedChanged += new System.EventHandler(this.Timeout_CheckedChanged);
            // 
            // Timeout10
            // 
            this.Timeout10.AutoSize = true;
            this.Timeout10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Timeout10.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timeout10.Location = new System.Drawing.Point(19, 144);
            this.Timeout10.Name = "Timeout10";
            this.Timeout10.Size = new System.Drawing.Size(109, 30);
            this.Timeout10.TabIndex = 22;
            this.Timeout10.Tag = "10";
            this.Timeout10.Text = "10 секунд";
            this.Timeout10.UseVisualStyleBackColor = true;
            this.Timeout10.CheckedChanged += new System.EventHandler(this.Timeout_CheckedChanged);
            // 
            // Timeout3
            // 
            this.Timeout3.AutoSize = true;
            this.Timeout3.Checked = true;
            this.Timeout3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Timeout3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timeout3.Location = new System.Drawing.Point(19, 35);
            this.Timeout3.Name = "Timeout3";
            this.Timeout3.Size = new System.Drawing.Size(109, 30);
            this.Timeout3.TabIndex = 21;
            this.Timeout3.TabStop = true;
            this.Timeout3.Tag = "3";
            this.Timeout3.Text = "3 секунды";
            this.Timeout3.UseVisualStyleBackColor = true;
            this.Timeout3.CheckedChanged += new System.EventHandler(this.Timeout_CheckedChanged);
            // 
            // pb_20
            // 
            this.pb_20.BackColor = System.Drawing.Color.Transparent;
            this.pb_20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_20.Image = global::PersonalTask.Properties.Resources.OnlyHard;
            this.pb_20.Location = new System.Drawing.Point(150, 278);
            this.pb_20.Name = "pb_20";
            this.pb_20.Size = new System.Drawing.Size(126, 72);
            this.pb_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_20.TabIndex = 20;
            this.pb_20.TabStop = false;
            this.pb_20.Tag = "20";
            this.pb_20.Click += new System.EventHandler(this.EditDifficulty);
            // 
            // pb_16
            // 
            this.pb_16.BackColor = System.Drawing.Color.Transparent;
            this.pb_16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_16.Image = ((System.Drawing.Image)(resources.GetObject("pb_16.Image")));
            this.pb_16.Location = new System.Drawing.Point(163, 192);
            this.pb_16.Name = "pb_16";
            this.pb_16.Size = new System.Drawing.Size(113, 80);
            this.pb_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_16.TabIndex = 19;
            this.pb_16.TabStop = false;
            this.pb_16.Tag = "16";
            this.pb_16.Click += new System.EventHandler(this.EditDifficulty);
            // 
            // pb_12
            // 
            this.pb_12.BackColor = System.Drawing.Color.Transparent;
            this.pb_12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_12.Image = ((System.Drawing.Image)(resources.GetObject("pb_12.Image")));
            this.pb_12.Location = new System.Drawing.Point(190, 106);
            this.pb_12.Name = "pb_12";
            this.pb_12.Size = new System.Drawing.Size(80, 80);
            this.pb_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_12.TabIndex = 18;
            this.pb_12.TabStop = false;
            this.pb_12.Tag = "12";
            this.pb_12.Click += new System.EventHandler(this.EditDifficulty);
            // 
            // pb_8
            // 
            this.pb_8.BackColor = System.Drawing.Color.Transparent;
            this.pb_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_8.Image = ((System.Drawing.Image)(resources.GetObject("pb_8.Image")));
            this.pb_8.Location = new System.Drawing.Point(190, 20);
            this.pb_8.Name = "pb_8";
            this.pb_8.Size = new System.Drawing.Size(80, 80);
            this.pb_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_8.TabIndex = 17;
            this.pb_8.TabStop = false;
            this.pb_8.Tag = "8";
            this.pb_8.Click += new System.EventHandler(this.EditDifficulty);
            // 
            // btn_GetInfoAboutit1
            // 
            this.btn_GetInfoAboutit1.Location = new System.Drawing.Point(232, 364);
            this.btn_GetInfoAboutit1.Name = "btn_GetInfoAboutit1";
            this.btn_GetInfoAboutit1.Size = new System.Drawing.Size(32, 33);
            this.btn_GetInfoAboutit1.TabIndex = 9;
            this.btn_GetInfoAboutit1.Click += new System.EventHandler(this.btn_GetInfoAboutit1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(643, 410);
            this.Controls.Add(this.btn_GetInfoAboutit1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.DifficultyPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.White;
            this.DifficultyPanel.ResumeLayout(false);
            this.DifficultyPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DifficultyPanel;
        private System.Windows.Forms.RadioButton rb_OnlyHard;
        private System.Windows.Forms.RadioButton rb_Hard;
        private System.Windows.Forms.RadioButton rb_Normal;
        private System.Windows.Forms.RadioButton rb_Easy;
        private System.Windows.Forms.PictureBox pb_20;
        private System.Windows.Forms.PictureBox pb_16;
        private System.Windows.Forms.PictureBox pb_12;
        private System.Windows.Forms.PictureBox pb_8;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Timeout5;
        private System.Windows.Forms.RadioButton Timeout7;
        private System.Windows.Forms.RadioButton Timeout10;
        private System.Windows.Forms.RadioButton Timeout3;
        private LibraryUserControls.btn_GetInfoAboutit btn_GetInfoAboutit1;
    }
}