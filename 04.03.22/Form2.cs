using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04._03._22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SettingsCancelButton_Click(object sender, EventArgs e)
        {
            SettingsCancelButton.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            SettingsSaveButton.DialogResult = DialogResult.OK;
        }
    }
}
