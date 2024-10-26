namespace MetaDataStringEditor {
    partial class Редактирование {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Сохранить = new System.Windows.Forms.Button();
            this.cancellation = new System.Windows.Forms.Button();
            this.RECOVERY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 220);
            this.textBox1.TabIndex = 0;
            // 
            // Сохранить
            // 
            this.Сохранить.Location = new System.Drawing.Point(74, 250);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(75, 25);
            this.Сохранить.TabIndex = 1;
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.UseVisualStyleBackColor = true;
            this.Сохранить.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancellation
            // 
            this.cancellation.Location = new System.Drawing.Point(266, 250);
            this.cancellation.Name = "Отмена";
            this.cancellation.Size = new System.Drawing.Size(79, 25);
            this.cancellation.TabIndex = 2;
            this.cancellation.Text = "Отмена";
            this.cancellation.UseVisualStyleBackColor = true;
            this.cancellation.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // RECOVERY
            // 
            this.RECOVERY.Location = new System.Drawing.Point(155, 250);
            this.RECOVERY.Name = "Восстановить значение";
            this.RECOVERY.Size = new System.Drawing.Size(105, 25);
            this.RECOVERY.TabIndex = 3;
            this.RECOVERY.Text = "Восстановить значение";
            this.RECOVERY.UseVisualStyleBackColor = true;
            this.RECOVERY.Click += new System.EventHandler(this.Recover_Click);
            // 
            // Редактирование
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 287);
            this.Controls.Add(this.RECOVERY);
            this.Controls.Add(this.cancellation);
            this.Controls.Add(this.Сохранить);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Редактирование";
            this.ShowIcon = false;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Сохранить;
        private System.Windows.Forms.Button cancellation;
        private System.Windows.Forms.Button RECOVERY;
    }
}