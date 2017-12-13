using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_tools
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }
        //66666
        private void usartControl1_DataFinished(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usartControl1.DataClass.Table[0].Length; i++)
            {
                radListView1.Items.Add(usartControl1.DataClass.Table[0].DatasList[i].Frame,
                    usartControl1.DataClass.Table[0].DatasList[i].Value);
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                usartControl1.DataClass.Table[0].AddData(i*10);
            }
        }
    }
}
