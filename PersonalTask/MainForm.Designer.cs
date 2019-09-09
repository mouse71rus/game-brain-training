namespace PersonalTask
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonMenu = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(71, 32);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbScore.Location = new System.Drawing.Point(552, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(63, 24);
            this.lbScore.TabIndex = 7;
            this.lbScore.Text = "Рекорд:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(718, 414);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.buttonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренировка памяти";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label lbScore;
    }
}

