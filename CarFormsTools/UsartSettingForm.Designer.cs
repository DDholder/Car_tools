namespace CarFormsTools
{
    partial class UsartSettingForm
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
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.dataHeadBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dataHeadBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.dataEndBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dataEndBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.dataHeadBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHeadBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEndBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEndBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHeadBox1
            // 
            this.dataHeadBox1.Location = new System.Drawing.Point(76, 21);
            this.dataHeadBox1.Name = "dataHeadBox1";
            this.dataHeadBox1.Size = new System.Drawing.Size(68, 36);
            this.dataHeadBox1.TabIndex = 0;
            this.dataHeadBox1.Text = "0xaa";
            this.dataHeadBox1.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(31, 36);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "包头";
            this.radLabel1.ThemeName = "MaterialTeal";
            // 
            // dataHeadBox2
            // 
            this.dataHeadBox2.Location = new System.Drawing.Point(150, 21);
            this.dataHeadBox2.Name = "dataHeadBox2";
            this.dataHeadBox2.Size = new System.Drawing.Size(87, 36);
            this.dataHeadBox2.TabIndex = 2;
            this.dataHeadBox2.Text = "0xbb";
            this.dataHeadBox2.ThemeName = "MaterialTeal";
            // 
            // dataEndBox2
            // 
            this.dataEndBox2.Location = new System.Drawing.Point(150, 63);
            this.dataEndBox2.Name = "dataEndBox2";
            this.dataEndBox2.Size = new System.Drawing.Size(87, 36);
            this.dataEndBox2.TabIndex = 5;
            this.dataEndBox2.Text = "0xdd";
            this.dataEndBox2.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(31, 78);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(39, 21);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "包尾";
            this.radLabel2.ThemeName = "MaterialTeal";
            // 
            // dataEndBox1
            // 
            this.dataEndBox1.Location = new System.Drawing.Point(76, 63);
            this.dataEndBox1.Name = "dataEndBox1";
            this.dataEndBox1.Size = new System.Drawing.Size(68, 36);
            this.dataEndBox1.TabIndex = 3;
            this.dataEndBox1.Text = "0xcc";
            this.dataEndBox1.ThemeName = "MaterialTeal";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(249, 68);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(120, 36);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "参数表";
            this.radButton1.ThemeName = "MaterialTeal";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(249, 315);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(120, 36);
            this.radButton2.TabIndex = 7;
            this.radButton2.Text = "确定";
            this.radButton2.ThemeName = "MaterialTeal";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // UsartSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 367);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dataEndBox2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.dataEndBox1);
            this.Controls.Add(this.dataHeadBox2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dataHeadBox1);
            this.Name = "UsartSettingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "UsartSettingForm";
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.UsartSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHeadBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHeadBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEndBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEndBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadTextBox dataHeadBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox dataHeadBox2;
        private Telerik.WinControls.UI.RadTextBox dataEndBox2;
        private Telerik.WinControls.UI.RadTextBox dataEndBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
    }
}
