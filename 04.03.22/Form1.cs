using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _04._03._22
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form2 sf = new Form2();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                //Если пункт "запрещена" включён, то блокируем TextBox'ы...
                if (sf.UnavailableRadioButton.Checked)
                {
                    SurnameData.Enabled = false;
                    NameData.Enabled = false;
                    DescriptionData.Enabled = false;
                }
                //...иначе разблокируем
                else
                {
                    SurnameData.Enabled = true;
                    NameData.Enabled = true;
                    DescriptionData.Enabled = true;
                }
            }
        }

 
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Доавляем человека в таблицу
            DataGridView.Rows.Add(SurnameData.Text, NameData.Text, DescriptionData.Text);

            //И очищаем TextBox'ы для новой записи
            SurnameData.Clear();
            NameData.Clear();
            DescriptionData.Clear();
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*."
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = new string[DataGridView.Rows.Count];
                for (int i = 0; i < DataGridView.Rows.Count - 1; i++)
                {
                    //Добавляем | вместо " ", т.к. в описании могут быть пробелы, из-за которых разделение сработает некорректно
                    lines[i] = DataGridView[0, i].Value.ToString() + "|" + DataGridView[1, i].Value.ToString()
                        + "|" + DataGridView[2, i].Value.ToString();
                }
                File.WriteAllLines(sfd.FileName, lines);
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    //Сплит строки по пробелам на имя-возраст-описание
                    string[] line = lines[i].Split('|');

                    //Добавление в соответствующие ячейки одного ряда эти значения
                    DataGridView.Rows.Add(line[0], line[1], line[2]);
                }
                File.WriteAllLines(ofd.FileName, lines);
            }
        }

        private void CleanButtom_Click(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
        }

        private void NewTab_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage
            {
                Text = $"Вкладка {Tabs.TabPages.Count + 1}"
            };
            Tabs.TabPages.Add(newTabPage);
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nsttmf14");
        }
    }
}
