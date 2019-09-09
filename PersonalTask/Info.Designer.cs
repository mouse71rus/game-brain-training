namespace PersonalTask
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Caption = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.info0 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.info3 = new System.Windows.Forms.Label();
            this.info4 = new System.Windows.Forms.Label();
            this.info5 = new System.Windows.Forms.Label();
            this.info6 = new System.Windows.Forms.Label();
            this.info7 = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.btn_Downlands = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Selec_LVL = new System.Windows.Forms.Panel();
            this.SelectedLVL = new System.Windows.Forms.Label();
            this.btn_down1 = new LibraryUserControls.btn_down();
            this.btn_up1 = new LibraryUserControls.btn_up();
            this.InfoPanel.SuspendLayout();
            this.Selec_LVL.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(536, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(95, 34);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Закрыть";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Caption.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Caption.Location = new System.Drawing.Point(12, 12);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(107, 37);
            this.Caption.TabIndex = 5;
            this.Caption.Text = "Справка";
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.Controls.Add(this.info0);
            this.InfoPanel.Controls.Add(this.info1);
            this.InfoPanel.Controls.Add(this.info2);
            this.InfoPanel.Controls.Add(this.info3);
            this.InfoPanel.Controls.Add(this.info4);
            this.InfoPanel.Controls.Add(this.info5);
            this.InfoPanel.Controls.Add(this.info6);
            this.InfoPanel.Controls.Add(this.info7);
            this.InfoPanel.Location = new System.Drawing.Point(443, 49);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(189, 349);
            this.InfoPanel.TabIndex = 18;
            this.InfoPanel.Tag = "0";
            // 
            // info0
            // 
            this.info0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info0.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info0.Location = new System.Drawing.Point(3, 0);
            this.info0.Name = "info0";
            this.info0.Size = new System.Drawing.Size(164, 81);
            this.info0.TabIndex = 9;
            this.info0.Tag = "0";
            this.info0.Text = "О программе";
            this.info0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info0.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // info1
            // 
            this.info1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info1.Location = new System.Drawing.Point(3, 81);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(164, 81);
            this.info1.TabIndex = 10;
            this.info1.Tag = "1";
            this.info1.Text = "Правила игры";
            this.info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info1.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // info2
            // 
            this.info2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info2.Location = new System.Drawing.Point(3, 162);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(164, 81);
            this.info2.TabIndex = 11;
            this.info2.Tag = "2";
            this.info2.Text = "Главное окно игры";
            this.info2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info2.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // info3
            // 
            this.info3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info3.Location = new System.Drawing.Point(3, 243);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(164, 81);
            this.info3.TabIndex = 12;
            this.info3.Tag = "3";
            this.info3.Text = "Меню";
            this.info3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info3.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // info4
            // 
            this.info4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info4.Location = new System.Drawing.Point(3, 324);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(164, 81);
            this.info4.TabIndex = 13;
            this.info4.Tag = "4";
            this.info4.Text = "Настройки";
            this.info4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info4.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // info5
            // 
            this.info5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info5.Location = new System.Drawing.Point(3, 405);
            this.info5.Name = "info5";
            this.info5.Size = new System.Drawing.Size(164, 81);
            this.info5.TabIndex = 14;
            this.info5.Tag = "5";
            this.info5.Text = "Уровни";
            this.info5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info5.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // info6
            // 
            this.info6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info6.Location = new System.Drawing.Point(3, 486);
            this.info6.Name = "info6";
            this.info6.Size = new System.Drawing.Size(164, 81);
            this.info6.TabIndex = 16;
            this.info6.Tag = "6";
            this.info6.Text = "Пользовательские уровни";
            this.info6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info6.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // info7
            // 
            this.info7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info7.Location = new System.Drawing.Point(3, 567);
            this.info7.Name = "info7";
            this.info7.Size = new System.Drawing.Size(164, 81);
            this.info7.TabIndex = 17;
            this.info7.Tag = "7";
            this.info7.Text = "Рекорды";
            this.info7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info7.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoEllipsis = true;
            this.MainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(19, 49);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(418, 349);
            this.MainLabel.TabIndex = 19;
            this.MainLabel.Text = "Выберите интересующую справку";
            // 
            // btn_Downlands
            // 
            this.btn_Downlands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Downlands.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Downlands.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_Downlands.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Downlands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Downlands.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Downlands.Location = new System.Drawing.Point(357, 366);
            this.btn_Downlands.Name = "btn_Downlands";
            this.btn_Downlands.Size = new System.Drawing.Size(74, 26);
            this.btn_Downlands.TabIndex = 20;
            this.btn_Downlands.Text = "Скачать";
            this.btn_Downlands.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Downlands.UseVisualStyleBackColor = true;
            this.btn_Downlands.Visible = false;
            this.btn_Downlands.Click += new System.EventHandler(this.btn_Downlands_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(-1, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Уровень";
            // 
            // Selec_LVL
            // 
            this.Selec_LVL.Controls.Add(this.label1);
            this.Selec_LVL.Controls.Add(this.SelectedLVL);
            this.Selec_LVL.Controls.Add(this.btn_down1);
            this.Selec_LVL.Controls.Add(this.btn_up1);
            this.Selec_LVL.Location = new System.Drawing.Point(28, 304);
            this.Selec_LVL.Name = "Selec_LVL";
            this.Selec_LVL.Size = new System.Drawing.Size(132, 88);
            this.Selec_LVL.TabIndex = 27;
            this.Selec_LVL.Visible = false;
            // 
            // SelectedLVL
            // 
            this.SelectedLVL.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedLVL.ForeColor = System.Drawing.Color.Green;
            this.SelectedLVL.Location = new System.Drawing.Point(96, 28);
            this.SelectedLVL.Name = "SelectedLVL";
            this.SelectedLVL.Size = new System.Drawing.Size(25, 30);
            this.SelectedLVL.TabIndex = 30;
            this.SelectedLVL.Text = "1";
            // 
            // btn_down1
            // 
            this.btn_down1.BackColor = System.Drawing.Color.Transparent;
            this.btn_down1.Location = new System.Drawing.Point(97, 65);
            this.btn_down1.Name = "btn_down1";
            this.btn_down1.Size = new System.Drawing.Size(25, 21);
            this.btn_down1.TabIndex = 29;
            this.btn_down1.Click += new System.EventHandler(this.btn_down1_Click);
            // 
            // btn_up1
            // 
            this.btn_up1.BackColor = System.Drawing.Color.Transparent;
            this.btn_up1.Location = new System.Drawing.Point(97, 5);
            this.btn_up1.Name = "btn_up1";
            this.btn_up1.Size = new System.Drawing.Size(25, 21);
            this.btn_up1.TabIndex = 28;
            this.btn_up1.Click += new System.EventHandler(this.btn_up1_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(643, 410);
            this.Controls.Add(this.Selec_LVL);
            this.Controls.Add(this.btn_Downlands);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.Shown += new System.EventHandler(this.Info_Shown);
            this.InfoPanel.ResumeLayout(false);
            this.Selec_LVL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.FlowLayoutPanel InfoPanel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label info0;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label info3;
        private System.Windows.Forms.Label info4;
        private System.Windows.Forms.Label info5;
        private System.Windows.Forms.Label info6;
        private System.Windows.Forms.Button btn_Downlands;
        private System.Windows.Forms.Label info7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Selec_LVL;
        private LibraryUserControls.btn_up btn_up1;
        private LibraryUserControls.btn_down btn_down1;
        private System.Windows.Forms.Label SelectedLVL;
    }
}