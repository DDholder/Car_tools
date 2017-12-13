namespace Car_tools
{
    partial class RadForm1
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "FPS");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Value");
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.usartControl1 = new CarFormsTools.UsartControl();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(558, 362);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(72, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "radLabel1";
            this.radLabel1.ThemeName = "MaterialTeal";
            // 
            // usartControl1
            // 
            this.usartControl1.CurrentData = null;
            this.usartControl1.Datapath = "F:\\111.ini";
            this.usartControl1.End = new byte[] {
        ((byte)(204)),
        ((byte)(221))};
            this.usartControl1.Head = new byte[] {
        ((byte)(170)),
        ((byte)(187))};
            this.usartControl1.Location = new System.Drawing.Point(384, 109);
            this.usartControl1.Name = "usartControl1";
            this.usartControl1.Size = new System.Drawing.Size(212, 223);
            this.usartControl1.TabIndex = 2;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(601, 22);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(120, 36);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Text";
            this.radButton1.ThemeName = "MaterialTeal";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radListView1
            // 
            listViewDetailColumn3.HeaderText = "FPS";
            listViewDetailColumn3.Width = 100F;
            listViewDetailColumn4.HeaderText = "Value";
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 32);
            this.radListView1.ItemSize = new System.Drawing.Size(200, 32);
            this.radListView1.ItemSpacing = -1;
            this.radListView1.Location = new System.Drawing.Point(12, 12);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(302, 537);
            this.radListView1.TabIndex = 4;
            this.radListView1.Text = "radListView1";
            this.radListView1.ThemeName = "MaterialTeal";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 561);
            this.Controls.Add(this.radListView1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.usartControl1);
            this.Controls.Add(this.radLabel1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private CarFormsTools.UsartControl usartControl1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadListView radListView1;
    }
}