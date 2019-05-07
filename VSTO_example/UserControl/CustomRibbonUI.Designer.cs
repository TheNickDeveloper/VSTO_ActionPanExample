namespace VSTO_example
{
    partial class CustomRibbonUI : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CustomRibbonUI()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCustomRibbon = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnActionPan = this.Factory.CreateRibbonButton();
            this.tabCustomRibbon.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomRibbon
            // 
            this.tabCustomRibbon.Groups.Add(this.group1);
            this.tabCustomRibbon.Label = "CustomRibbon";
            this.tabCustomRibbon.Name = "tabCustomRibbon";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnActionPan);
            this.group1.Name = "group1";
            // 
            // btnActionPan
            // 
            this.btnActionPan.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnActionPan.Label = "ActionPan";
            this.btnActionPan.Name = "btnActionPan";
            this.btnActionPan.OfficeImageId = "ExportTextFile";
            this.btnActionPan.ShowImage = true;
            this.btnActionPan.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnActionPan_Click);
            // 
            // CustomRibbonUI
            // 
            this.Name = "CustomRibbonUI";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabCustomRibbon);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomRibbonUI_Load);
            this.tabCustomRibbon.ResumeLayout(false);
            this.tabCustomRibbon.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabCustomRibbon;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnActionPan;
    }

    partial class ThisRibbonCollection
    {
        internal CustomRibbonUI CustomRibbonUI
        {
            get { return this.GetRibbon<CustomRibbonUI>(); }
        }
    }
}
