using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CarFormsTools
{
    public partial class UsartSettingForm : Telerik.WinControls.UI.RadForm
    {
        public UsartSettingForm()
        {
            InitializeComponent();
        }

        private void UsartSettingForm_Load(object sender, EventArgs e)
        {
            _dataTemp = UsartControl.UsartControlMain.DataClass;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            UsartControl.UsartControlMain.Head = new[]
                {Convert.ToByte(dataHeadBox1.Text, 16), Convert.ToByte(dataHeadBox2.Text, 16)};
            UsartControl.UsartControlMain.Head = new[]
                {Convert.ToByte(dataEndBox1.Text, 16), Convert.ToByte(dataEndBox2.Text, 16)};
            UsartControl.UsartControlMain.DataClass = _dataTemp;
        }

        private DataSettingForm _dataSettingForm;
        private DataClass _dataTemp;
        private void radButton1_Click(object sender, EventArgs e)
        {
            _dataTemp = UsartControl.UsartControlMain.DataClass;
            _dataSettingForm = new DataSettingForm(ref _dataTemp);
            _dataSettingForm.ShowDialog();
        }
    }
}
