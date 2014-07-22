namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_playField = new System.Windows.Forms.Panel();
            this.btn_DrawField = new System.Windows.Forms.Button();
            this.pictureBox_Field = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Field)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_playField
            // 
            this.panel_playField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_playField.Location = new System.Drawing.Point(12, 12);
            this.panel_playField.Name = "panel_playField";
            this.panel_playField.Size = new System.Drawing.Size(322, 347);
            this.panel_playField.TabIndex = 0;
            // 
            // btn_DrawField
            // 
            this.btn_DrawField.Location = new System.Drawing.Point(340, 12);
            this.btn_DrawField.Name = "btn_DrawField";
            this.btn_DrawField.Size = new System.Drawing.Size(131, 23);
            this.btn_DrawField.TabIndex = 1;
            this.btn_DrawField.Text = "Нарисовать поле";
            this.btn_DrawField.UseVisualStyleBackColor = true;
            this.btn_DrawField.Click += new System.EventHandler(this.btn_DrawField_Click);
            // 
            // pictureBox_Field
            // 
            this.pictureBox_Field.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Field.Location = new System.Drawing.Point(477, 12);
            this.pictureBox_Field.Name = "pictureBox_Field";
            this.pictureBox_Field.Size = new System.Drawing.Size(322, 347);
            this.pictureBox_Field.TabIndex = 2;
            this.pictureBox_Field.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 371);
            this.Controls.Add(this.pictureBox_Field);
            this.Controls.Add(this.btn_DrawField);
            this.Controls.Add(this.panel_playField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Field)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_playField;
        private System.Windows.Forms.Button btn_DrawField;
        private System.Windows.Forms.PictureBox pictureBox_Field;
    }
}

