namespace LibraryUserControls
{
    partial class lbl_SelectedLVL
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.M_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // M_label
            // 
            this.M_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M_label.Location = new System.Drawing.Point(0, 0);
            this.M_label.Name = "M_label";
            this.M_label.Size = new System.Drawing.Size(66, 42);
            this.M_label.TabIndex = 0;
            this.M_label.Text = "1";
            // 
            // lbl_SelectedLVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.M_label);
            this.Name = "lbl_SelectedLVL";
            this.Size = new System.Drawing.Size(66, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label M_label;
    }
}
