namespace LibraryUserControls
{
    partial class UIButton
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
            this.Caption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.Caption.Location = new System.Drawing.Point(81, 62);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(90, 37);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "Цвета";
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Caption);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(282, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Caption;
    }
}
