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
            this.button1 = new System.Windows.Forms.Button();
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
            this.GBStoreID.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstFile
            // 
            this.FirstFile.Location = new System.Drawing.Point(12, 32);
            this.FirstFile.Name = "FirstFile";
            this.FirstFile.Size = new System.Drawing.Size(149, 20);
            this.FirstFile.TabIndex = 1;
            // 
            // SecondFile
            // 
            this.SecondFile.Location = new System.Drawing.Point(12, 59);
            this.SecondFile.Name = "SecondFile";
            this.SecondFile.Size = new System.Drawing.Size(149, 20);
            this.SecondFile.TabIndex = 2;
            // 
            // FirstFileButton
            // 
            this.FirstFileButton.Location = new System.Drawing.Point(181, 32);
            this.FirstFileButton.Name = "FirstFileButton";
            this.FirstFileButton.Size = new System.Drawing.Size(75, 23);
            this.FirstFileButton.TabIndex = 3;
            this.FirstFileButton.Text = "Исх файл";
            this.FirstFileButton.UseVisualStyleBackColor = true;
            this.FirstFileButton.Click += new System.EventHandler(this.FirstFileButton_Click);
            // 
            // SecondFileButton
            // 
            this.SecondFileButton.Location = new System.Drawing.Point(181, 55);
            this.SecondFileButton.Name = "SecondFileButton";
            this.SecondFileButton.Size = new System.Drawing.Size(75, 23);
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
            this.GBStoreID.Location = new System.Drawing.Point(13, 85);
            this.GBStoreID.Name = "GBStoreID";
            this.GBStoreID.Size = new System.Drawing.Size(148, 96);
            this.GBStoreID.TabIndex = 5;
            this.GBStoreID.TabStop = false;
            this.GBStoreID.Text = "StoreID";
            // 
            // PsRadio
            // 
            this.PsRadio.AutoSize = true;
            this.PsRadio.Location = new System.Drawing.Point(7, 67);
            this.PsRadio.Name = "PsRadio";
            this.PsRadio.Size = new System.Drawing.Size(68, 17);
            this.PsRadio.TabIndex = 2;
            this.PsRadio.TabStop = true;
            this.PsRadio.Text = "PaySend";
            this.PsRadio.UseVisualStyleBackColor = true;
            this.PsRadio.CheckedChanged += new System.EventHandler(this.PsRadio_CheckedChanged);
            // 
            // RibRadio
            // 
            this.RibRadio.AutoSize = true;
            this.RibRadio.Location = new System.Drawing.Point(7, 44);
            this.RibRadio.Name = "RibRadio";
            this.RibRadio.Size = new System.Drawing.Size(43, 17);
            this.RibRadio.TabIndex = 1;
            this.RibRadio.TabStop = true;
            this.RibRadio.Text = "RIB";
            this.RibRadio.UseVisualStyleBackColor = true;
            this.RibRadio.CheckedChanged += new System.EventHandler(this.RibRadio_CheckedChanged);
            // 
            // KiwiRadio
            // 
            this.KiwiRadio.AutoSize = true;
            this.KiwiRadio.Location = new System.Drawing.Point(7, 20);
            this.KiwiRadio.Name = "KiwiRadio";
            this.KiwiRadio.Size = new System.Drawing.Size(49, 17);
            this.KiwiRadio.TabIndex = 0;
            this.KiwiRadio.TabStop = true;
            this.KiwiRadio.Text = "KIWI";
            this.KiwiRadio.UseVisualStyleBackColor = true;
            this.KiwiRadio.CheckedChanged += new System.EventHandler(this.KiwiRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 192);
            this.Controls.Add(this.GBStoreID);
            this.Controls.Add(this.SecondFileButton);
            this.Controls.Add(this.FirstFileButton);
            this.Controls.Add(this.SecondFile);
            this.Controls.Add(this.FirstFile);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RK";
            this.GBStoreID.ResumeLayout(false);
            this.GBStoreID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

