namespace WithButton
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cxPlug = new System.Windows.Forms.ComboBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(450, 309);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 45);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // cxPlug
            // 
            this.cxPlug.FormattingEnabled = true;
            this.cxPlug.Location = new System.Drawing.Point(12, 12);
            this.cxPlug.Name = "cxPlug";
            this.cxPlug.Size = new System.Drawing.Size(175, 24);
            this.cxPlug.TabIndex = 8;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 56);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(175, 49);
            this.butAdd.TabIndex = 9;
            this.butAdd.Text = "Add plugins list";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 383);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.cxPlug);
            this.Controls.Add(this.btnSubmit);
            this.MinimumSize = new System.Drawing.Size(600, 430);
            this.Name = "Form1";
            this.Text = "CustomComponents";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.ComboBox cxPlug;
        private System.Windows.Forms.Button butAdd;
    }
}

