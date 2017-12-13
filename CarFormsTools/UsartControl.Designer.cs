namespace CarFormsTools
{
    partial class UsartControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.comList = new Telerik.WinControls.UI.RadDropDownList();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.BaudList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.comSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataHandleCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.settingButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.comList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaudList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHandleCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // comList
            // 
            this.comList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comList.Location = new System.Drawing.Point(76, 3);
            this.comList.Name = "comList";
            this.comList.Size = new System.Drawing.Size(133, 41);
            this.comList.TabIndex = 0;
            this.comList.ThemeName = "MaterialTeal";
            // 
            // BaudList
            // 
            this.BaudList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            radListDataItem1.Text = "9600";
            radListDataItem2.Text = "115200";
            this.BaudList.Items.Add(radListDataItem1);
            this.BaudList.Items.Add(radListDataItem2);
            this.BaudList.Location = new System.Drawing.Point(76, 45);
            this.BaudList.Name = "BaudList";
            this.BaudList.Size = new System.Drawing.Size(133, 41);
            this.BaudList.TabIndex = 1;
            this.BaudList.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "端口号";
            this.radLabel1.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 51);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 21);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "波特率";
            this.radLabel2.ThemeName = "MaterialTeal";
            // 
            // comSwitch
            // 
            this.comSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comSwitch.Location = new System.Drawing.Point(92, 87);
            this.comSwitch.Name = "comSwitch";
            this.comSwitch.Size = new System.Drawing.Size(117, 37);
            this.comSwitch.TabIndex = 4;
            this.comSwitch.Text = "radToggleSwitch1";
            this.comSwitch.ThemeName = "MaterialTeal";
            this.comSwitch.Value = false;
            this.comSwitch.ValueChanged += new System.EventHandler(this.comSwitch_ValueChanged);
            this.comSwitch.Click += new System.EventHandler(this.comSwitch_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataHandleCheckBox
            // 
            this.dataHandleCheckBox.Location = new System.Drawing.Point(3, 102);
            this.dataHandleCheckBox.Name = "dataHandleCheckBox";
            this.dataHandleCheckBox.Size = new System.Drawing.Size(88, 19);
            this.dataHandleCheckBox.TabIndex = 5;
            this.dataHandleCheckBox.Text = "识别数据";
            this.dataHandleCheckBox.ThemeName = "MaterialTeal";
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(89, 130);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(120, 36);
            this.settingButton.TabIndex = 7;
            this.settingButton.Text = "设置";
            this.settingButton.ThemeName = "MaterialTeal";
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(11, 145);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 21);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "radLabel3";
            this.radLabel3.ThemeName = "MaterialTeal";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "ini文件|*.ini";
            // 
            // UsartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.dataHandleCheckBox);
            this.Controls.Add(this.comSwitch);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.BaudList);
            this.Controls.Add(this.comList);
            this.Name = "UsartControl";
            this.Size = new System.Drawing.Size(212, 223);
            this.Load += new System.EventHandler(this.UsartControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaudList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHandleCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList comList;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadDropDownList BaudList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadToggleSwitch comSwitch;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadCheckBox dataHandleCheckBox;
        private Telerik.WinControls.UI.RadButton settingButton;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
