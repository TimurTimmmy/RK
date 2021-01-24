namespace RK
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
            this.FirstFile = new System.Windows.Forms.TextBox();
            this.SecondFile = new System.Windows.Forms.TextBox();
            this.FirstFileButton = new System.Windows.Forms.Button();
            this.SecondFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.GBStoreID = new System.Windows.Forms.GroupBox();
            this.PsRadio = new System.Windows.Forms.RadioButton();
            this.RibRadio = new System.Windows.Forms.RadioButton();
            this.KiwiRadio = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.GBStoreID.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstFile
            // 
            this.FirstFile.Location = new System.Drawing.Point(16, 39);
            this.FirstFile.Margin = new System.Windows.Forms.Padding(4);
            this.FirstFile.Name = "FirstFile";
            this.FirstFile.Size = new System.Drawing.Size(197, 22);
            this.FirstFile.TabIndex = 1;
            // 
            // SecondFile
            // 
            this.SecondFile.Location = new System.Drawing.Point(16, 73);
            this.SecondFile.Margin = new System.Windows.Forms.Padding(4);
            this.SecondFile.Name = "SecondFile";
            this.SecondFile.Size = new System.Drawing.Size(197, 22);
            this.SecondFile.TabIndex = 2;
            // 
            // FirstFileButton
            // 
            this.FirstFileButton.Location = new System.Drawing.Point(221, 39);
            this.FirstFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.FirstFileButton.Name = "FirstFileButton";
            this.FirstFileButton.Size = new System.Drawing.Size(135, 28);
            this.FirstFileButton.TabIndex = 3;
            this.FirstFileButton.Text = "Исх файл";
            this.FirstFileButton.UseVisualStyleBackColor = true;
            this.FirstFileButton.Click += new System.EventHandler(this.FirstFileButton_Click);
            // 
            // SecondFileButton
            // 
            this.SecondFileButton.Location = new System.Drawing.Point(221, 67);
            this.SecondFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.SecondFileButton.Name = "SecondFileButton";
            this.SecondFileButton.Size = new System.Drawing.Size(135, 28);
            this.SecondFileButton.TabIndex = 4;
            this.SecondFileButton.Text = "Вх файл";
            this.SecondFileButton.UseVisualStyleBackColor = true;
            this.SecondFileButton.Click += new System.EventHandler(this.SecondFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // GBStoreID
            // 
            this.GBStoreID.Controls.Add(this.PsRadio);
            this.GBStoreID.Controls.Add(this.RibRadio);
            this.GBStoreID.Controls.Add(this.KiwiRadio);
            this.GBStoreID.Location = new System.Drawing.Point(17, 105);
            this.GBStoreID.Margin = new System.Windows.Forms.Padding(4);
            this.GBStoreID.Name = "GBStoreID";
            this.GBStoreID.Padding = new System.Windows.Forms.Padding(4);
            this.GBStoreID.Size = new System.Drawing.Size(197, 118);
            this.GBStoreID.TabIndex = 5;
            this.GBStoreID.TabStop = false;
            this.GBStoreID.Text = "StoreID";
            // 
            // PsRadio
            // 
            this.PsRadio.AutoSize = true;
            this.PsRadio.Location = new System.Drawing.Point(9, 82);
            this.PsRadio.Margin = new System.Windows.Forms.Padding(4);
            this.PsRadio.Name = "PsRadio";
            this.PsRadio.Size = new System.Drawing.Size(86, 21);
            this.PsRadio.TabIndex = 2;
            this.PsRadio.TabStop = true;
            this.PsRadio.Text = "PaySend";
            this.PsRadio.UseVisualStyleBackColor = true;
            this.PsRadio.CheckedChanged += new System.EventHandler(this.PsRadio_CheckedChanged);
            // 
            // RibRadio
            // 
            this.RibRadio.AutoSize = true;
            this.RibRadio.Location = new System.Drawing.Point(9, 54);
            this.RibRadio.Margin = new System.Windows.Forms.Padding(4);
            this.RibRadio.Name = "RibRadio";
            this.RibRadio.Size = new System.Drawing.Size(51, 21);
            this.RibRadio.TabIndex = 1;
            this.RibRadio.TabStop = true;
            this.RibRadio.Text = "RIB";
            this.RibRadio.UseVisualStyleBackColor = true;
            this.RibRadio.CheckedChanged += new System.EventHandler(this.RibRadio_CheckedChanged);
            // 
            // KiwiRadio
            // 
            this.KiwiRadio.AutoSize = true;
            this.KiwiRadio.Location = new System.Drawing.Point(9, 25);
            this.KiwiRadio.Margin = new System.Windows.Forms.Padding(4);
            this.KiwiRadio.Name = "KiwiRadio";
            this.KiwiRadio.Size = new System.Drawing.Size(57, 21);
            this.KiwiRadio.TabIndex = 0;
            this.KiwiRadio.TabStop = true;
            this.KiwiRadio.Text = "KIWI";
            this.KiwiRadio.UseVisualStyleBackColor = true;
            this.KiwiRadio.CheckedChanged += new System.EventHandler(this.KiwiRadio_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 80);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сформировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 236);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GBStoreID);
            this.Controls.Add(this.SecondFileButton);
            this.Controls.Add(this.FirstFileButton);
            this.Controls.Add(this.SecondFile);
            this.Controls.Add(this.FirstFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "RK 0.1";
            this.GBStoreID.ResumeLayout(false);
            this.GBStoreID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FirstFile;
        private System.Windows.Forms.TextBox SecondFile;
        private System.Windows.Forms.Button FirstFileButton;
        private System.Windows.Forms.Button SecondFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox GBStoreID;
        private System.Windows.Forms.RadioButton PsRadio;
        private System.Windows.Forms.RadioButton RibRadio;
        private System.Windows.Forms.RadioButton KiwiRadio;
        private System.Windows.Forms.Button button2;
    }
}

