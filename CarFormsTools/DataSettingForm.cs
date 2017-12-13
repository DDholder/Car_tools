using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CarFormsTools
{
    public partial class DataSettingForm : RadForm
    {
        private readonly DataClass _data;
        private readonly InIhandle _inIhandle = new InIhandle();
        public DataSettingForm(ref DataClass data)
        {
            _data = data;
            InitializeComponent();
        }
        public DataSettingForm()
        {
            InitializeComponent();
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            radListView1.Items.Clear();
        }
        
        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            _data.Clear();
            foreach (ListViewDataItem t in radListView1.Items)
            {
                _data.AddItem(t[1].ToString(),t[2].ToString());
            }
        } 
        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            radListView1.Items.Add(radListView1.Items.Count, "unnamed");
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var iniPath = saveFileDialog1.FileName;
            WriteInI(iniPath);
        }

        private void WriteInI(string path)
        {
            _inIhandle.WriteIni("Property", "length", _data.Table.Count.ToString(), path);
            for (var i = 0; i < _data.Table.Count; i++)
            {
                _inIhandle.WriteIni("Table", i.ToString(), _data.Table[i].Name, path);
                _inIhandle.WriteIni("Tips", i.ToString(), _data.Table[i].Tips, path);
            }
        }

        private void DataSettingForm_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < _data.Table.Count; i++)
            {
                radListView1.Items.Add(i, _data.Table[i].Name, _data.Table[i].Tips);
            }
        }
    }
}
