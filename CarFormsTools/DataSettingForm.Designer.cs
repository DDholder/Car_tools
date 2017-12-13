namespace CarFormsTools
{
    partial class DataSettingForm
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "编号");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "参数名称");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "备注");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("ListViewGroup 1");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup2 = new Telerik.WinControls.UI.ListViewDataItemGroup("ListViewGroup 2");
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radListView1);
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0, -5, 0, 0);
            this.radGroupBox1.HeaderText = "参数列表";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 69);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(372, 492);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "参数列表";
            this.radGroupBox1.ThemeName = "MaterialTeal";
            // 
            // radListView1
            // 
            listViewDetailColumn1.HeaderText = "编号";
            listViewDetailColumn1.Width = 60F;
            listViewDetailColumn2.HeaderText = "参数名称";
            listViewDetailColumn2.Width = 100F;
            listViewDetailColumn3.HeaderText = "备注";
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 32);
            listViewDataItemGroup1.Text = "ListViewGroup 1";
            listViewDataItemGroup2.Text = "ListViewGroup 2";
            this.radListView1.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1,
            listViewDataItemGroup2});
            this.radListView1.ItemSize = new System.Drawing.Size(200, 32);
            this.radListView1.ItemSpacing = -1;
            this.radListView1.Location = new System.Drawing.Point(2, 18);
            this.radListView1.Name = "radListView1";
            this.radContextMenuManager1.SetRadContextMenu(this.radListView1, this.radContextMenu1);
            this.radListView1.Size = new System.Drawing.Size(368, 472);
            this.radListView1.TabIndex = 3;
            this.radListView1.Text = "radListView1";
            this.radListView1.ThemeName = "MaterialTeal";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(578, 630);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(120, 36);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "radButton1";
            this.radButton1.ThemeName = "MaterialTeal";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(614, 418);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(72, 21);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "radLabel1";
            this.radLabel1.ThemeName = "MaterialTeal";
            // 
            // radContextMenu1
            // 
            this.radContextMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem6,
            this.radMenuItem5});
            this.radContextMenu1.ThemeName = "MaterialTeal";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "添加";
            this.radMenuItem6.Click += new System.EventHandler(this.radMenuItem6_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "确认";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 698);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(766, 25);
            this.radStatusStrip1.TabIndex = 4;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "MaterialTeal";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "文件";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "新建";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "打开";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "保存";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(766, 37);
            this.radMenu1.TabIndex = 5;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "MaterialTeal";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "ini文件|*.ini";
            // 
            // DataSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 723);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "DataSettingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "radRibbonBar1";
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.DataSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}
