
namespace _04._03._22
{
    partial class MainForm
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DescriptionData = new System.Windows.Forms.TextBox();
            this.NameData = new System.Windows.Forms.TextBox();
            this.SurnameData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NewTab = new System.Windows.Forms.Button();
            this.CleanButtom = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheThirdTab = new System.Windows.Forms.TabPage();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Data.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.TheThirdTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(681, 352);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Link);
            this.tabPage1.Controls.Add(this.SettingsButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Data);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вкладка 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(148, 292);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(140, 13);
            this.Link.TabIndex = 4;
            this.Link.TabStop = true;
            this.Link.Text = "https://github.com/nsttmf14";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(589, 287);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ссылка на ТикТок:";
            // 
            // Data
            // 
            this.Data.Controls.Add(this.SaveButton);
            this.Data.Controls.Add(this.DescriptionData);
            this.Data.Controls.Add(this.NameData);
            this.Data.Controls.Add(this.SurnameData);
            this.Data.Controls.Add(this.label3);
            this.Data.Controls.Add(this.label2);
            this.Data.Controls.Add(this.label1);
            this.Data.Location = new System.Drawing.Point(29, 22);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(435, 217);
            this.Data.TabIndex = 0;
            this.Data.TabStop = false;
            this.Data.Text = "Сведения";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(338, 176);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DescriptionData
            // 
            this.DescriptionData.Location = new System.Drawing.Point(122, 123);
            this.DescriptionData.Name = "DescriptionData";
            this.DescriptionData.Size = new System.Drawing.Size(291, 20);
            this.DescriptionData.TabIndex = 5;
            // 
            // NameData
            // 
            this.NameData.Location = new System.Drawing.Point(122, 79);
            this.NameData.Name = "NameData";
            this.NameData.Size = new System.Drawing.Size(291, 20);
            this.NameData.TabIndex = 4;
            // 
            // SurnameData
            // 
            this.SurnameData.Location = new System.Drawing.Point(120, 32);
            this.SurnameData.Name = "SurnameData";
            this.SurnameData.Size = new System.Drawing.Size(293, 20);
            this.SurnameData.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NewTab);
            this.tabPage2.Controls.Add(this.CleanButtom);
            this.tabPage2.Controls.Add(this.FileButton);
            this.tabPage2.Controls.Add(this.SaveDataButton);
            this.tabPage2.Controls.Add(this.DataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вкладка 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewTab
            // 
            this.NewTab.Location = new System.Drawing.Point(540, 6);
            this.NewTab.Name = "NewTab";
            this.NewTab.Size = new System.Drawing.Size(127, 34);
            this.NewTab.TabIndex = 4;
            this.NewTab.Text = "Новая вкладка\r\n+++";
            this.NewTab.UseVisualStyleBackColor = true;
            this.NewTab.Click += new System.EventHandler(this.NewTab_Click);
            // 
            // CleanButtom
            // 
            this.CleanButtom.Location = new System.Drawing.Point(239, 99);
            this.CleanButtom.Name = "CleanButtom";
            this.CleanButtom.Size = new System.Drawing.Size(75, 23);
            this.CleanButtom.TabIndex = 3;
            this.CleanButtom.Text = "Очистить таблицу";
            this.CleanButtom.UseVisualStyleBackColor = true;
            this.CleanButtom.Click += new System.EventHandler(this.CleanButtom_Click);
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(158, 99);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 2;
            this.FileButton.Text = "Файл";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveDataButton.Location = new System.Drawing.Point(8, 99);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(144, 23);
            this.SaveDataButton.TabIndex = 1;
            this.SaveDataButton.Text = "Сохранить таблицу";
            this.SaveDataButton.UseVisualStyleBackColor = false;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Person,
            this.Description});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridView.Location = new System.Drawing.Point(3, 3);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(667, 90);
            this.DataGridView.TabIndex = 0;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Person
            // 
            this.Person.HeaderText = "Имя";
            this.Person.Name = "Person";
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // TheThirdTab
            // 
            this.TheThirdTab.Location = new System.Drawing.Point(4, 22);
            this.TheThirdTab.Name = "TheThirdTab";
            this.TheThirdTab.Size = new System.Drawing.Size(673, 326);
            this.TheThirdTab.TabIndex = 2;
            this.TheThirdTab.Text = "Вкладка 3";
            this.TheThirdTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 352);
            this.Controls.Add(this.Tabs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionData;
        private System.Windows.Forms.TextBox NameData;
        private System.Windows.Forms.TextBox SurnameData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TabPage TheThirdTab;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button CleanButtom;
        private System.Windows.Forms.Button NewTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.LinkLabel Link;
    }
}

