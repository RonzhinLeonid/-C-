namespace Les7Exercise2
{
    partial class GuessNumber
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.chbNewForm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(96, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(199, 45);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(110, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Ввести число";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(115, 46);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(61, 22);
            this.tbNumber.TabIndex = 2;
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(16, 50);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(84, 13);
            this.lblEnterNumber.TabIndex = 3;
            this.lblEnterNumber.Text = "Введите число";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(103, 19);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(36, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "label1";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbNewForm
            // 
            this.chbNewForm.AutoSize = true;
            this.chbNewForm.Location = new System.Drawing.Point(68, 116);
            this.chbNewForm.Name = "chbNewForm";
            this.chbNewForm.Size = new System.Drawing.Size(184, 17);
            this.chbNewForm.TabIndex = 5;
            this.chbNewForm.Text = "Ввод числа в отдельном окне";
            this.chbNewForm.UseVisualStyleBackColor = true;
            this.chbNewForm.CheckedChanged += new System.EventHandler(this.chbNewForm_CheckedChanged);
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.chbNewForm);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnStart);
            this.Name = "GuessNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chbNewForm;
    }
}

