
namespace _04._03._22
{
    partial class Form2
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
            this.UnavailableRadioButton = new System.Windows.Forms.RadioButton();
            this.SettingsSaveButton = new System.Windows.Forms.Button();
            this.SettingsCancelButton = new System.Windows.Forms.Button();
            this.AvailableButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // UnavailableRadioButton
            // 
            this.UnavailableRadioButton.AutoSize = true;
            this.UnavailableRadioButton.Location = new System.Drawing.Point(175, 100);
            this.UnavailableRadioButton.Name = "UnavailableRadioButton";
            this.UnavailableRadioButton.Size = new System.Drawing.Size(96, 30);
            this.UnavailableRadioButton.TabIndex = 0;
            this.UnavailableRadioButton.TabStop = true;
            this.UnavailableRadioButton.Text = "ВЫКЛЮЧИТЬ\r\n\r\n";
            this.UnavailableRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsSaveButton
            // 
            this.SettingsSaveButton.Location = new System.Drawing.Point(74, 200);
            this.SettingsSaveButton.Name = "SettingsSaveButton";
            this.SettingsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsSaveButton.TabIndex = 1;
            this.SettingsSaveButton.Text = "OK";
            this.SettingsSaveButton.UseVisualStyleBackColor = true;
            this.SettingsSaveButton.Click += new System.EventHandler(this.SettingsSaveButton_Click);
            // 
            // SettingsCancelButton
            // 
            this.SettingsCancelButton.Location = new System.Drawing.Point(292, 200);
            this.SettingsCancelButton.Name = "SettingsCancelButton";
            this.SettingsCancelButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsCancelButton.TabIndex = 2;
            this.SettingsCancelButton.Text = "Отмена";
            this.SettingsCancelButton.UseVisualStyleBackColor = true;
            this.SettingsCancelButton.Click += new System.EventHandler(this.SettingsCancelButton_Click);
            // 
            // AvailableButton
            // 
            this.AvailableButton.AutoSize = true;
            this.AvailableButton.Location = new System.Drawing.Point(175, 48);
            this.AvailableButton.Name = "AvailableButton";
            this.AvailableButton.Size = new System.Drawing.Size(86, 30);
            this.AvailableButton.TabIndex = 3;
            this.AvailableButton.TabStop = true;
            this.AvailableButton.Text = "ВКЛЮЧИТЬ\r\n\r\n";
            this.AvailableButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 256);
            this.Controls.Add(this.AvailableButton);
            this.Controls.Add(this.SettingsCancelButton);
            this.Controls.Add(this.SettingsSaveButton);
            this.Controls.Add(this.UnavailableRadioButton);
            this.Name = "Form2";
            this.Text = "Сделайте выбор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SettingsSaveButton;
        private System.Windows.Forms.Button SettingsCancelButton;
        public System.Windows.Forms.RadioButton UnavailableRadioButton;
        private System.Windows.Forms.RadioButton AvailableButton;
    }
}