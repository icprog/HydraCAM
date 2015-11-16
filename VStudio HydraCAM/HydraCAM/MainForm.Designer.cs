namespace HydraCAM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainRibbon = new System.Windows.Forms.Ribbon();
            this.controlTab = new System.Windows.Forms.RibbonTab();
            this.filePanel = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.runPanel = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel2 = new System.Windows.Forms.RibbonLabel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.toolTab = new System.Windows.Forms.RibbonTab();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.spindlePanel1 = new HydraCAM.SpindlePanel();
            this.bedViewer1 = new HydraCAM.BedViewer();
            this.gCodeStatus1 = new HydraCAM.GCodeStatus();
            this.motionPanel1 = new HydraCAM.MotionPanel();
            this.statusPanel1 = new HydraCAM.StatusPanel();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.CaptionBarVisible = false;
            this.mainRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.Minimized = false;
            this.mainRibbon.Name = "mainRibbon";
            // 
            // 
            // 
            this.mainRibbon.OrbDropDown.BorderRoundness = 8;
            this.mainRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.OrbDropDown.Name = "";
            this.mainRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.mainRibbon.OrbDropDown.TabIndex = 0;
            this.mainRibbon.OrbImage = null;
            this.mainRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.mainRibbon.OrbText = "FILE";
            this.mainRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainRibbon.Size = new System.Drawing.Size(1007, 106);
            this.mainRibbon.TabIndex = 0;
            this.mainRibbon.Tabs.Add(this.controlTab);
            this.mainRibbon.Tabs.Add(this.toolTab);
            this.mainRibbon.Tabs.Add(this.ribbonTab1);
            this.mainRibbon.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.mainRibbon.Text = "File";
            this.mainRibbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // controlTab
            // 
            this.controlTab.Panels.Add(this.filePanel);
            this.controlTab.Panels.Add(this.runPanel);
            this.controlTab.Text = "Control";
            // 
            // filePanel
            // 
            this.filePanel.Items.Add(this.ribbonButton4);
            this.filePanel.Items.Add(this.ribbonButton5);
            this.filePanel.Text = "File";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "Open";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Close";
            // 
            // runPanel
            // 
            this.runPanel.Items.Add(this.ribbonButton1);
            this.runPanel.Items.Add(this.ribbonButton2);
            this.runPanel.Items.Add(this.ribbonButton3);
            this.runPanel.Text = "Program Run";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.DropDownItems.Add(this.ribbonLabel1);
            this.ribbonButton1.DropDownItems.Add(this.ribbonLabel2);
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Start";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Text = "ribbonLabel1";
            // 
            // ribbonLabel2
            // 
            this.ribbonLabel2.Text = "ribbonLabel2";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Stop";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Pause";
            // 
            // toolTab
            // 
            this.toolTab.Text = "Tools";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // spindlePanel1
            // 
            this.spindlePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spindlePanel1.Location = new System.Drawing.Point(2, 462);
            this.spindlePanel1.Name = "spindlePanel1";
            this.spindlePanel1.Size = new System.Drawing.Size(540, 106);
            this.spindlePanel1.TabIndex = 5;
            // 
            // bedViewer1
            // 
            this.bedViewer1.Location = new System.Drawing.Point(631, 293);
            this.bedViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bedViewer1.Name = "bedViewer1";
            this.bedViewer1.Size = new System.Drawing.Size(577, 363);
            this.bedViewer1.TabIndex = 4;
            // 
            // gCodeStatus1
            // 
            this.gCodeStatus1.Location = new System.Drawing.Point(0, 600);
            this.gCodeStatus1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gCodeStatus1.Name = "gCodeStatus1";
            this.gCodeStatus1.Size = new System.Drawing.Size(1007, 133);
            this.gCodeStatus1.TabIndex = 3;
            // 
            // motionPanel1
            // 
            this.motionPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.motionPanel1.Location = new System.Drawing.Point(2, 159);
            this.motionPanel1.Name = "motionPanel1";
            this.motionPanel1.Size = new System.Drawing.Size(540, 301);
            this.motionPanel1.TabIndex = 2;
            // 
            // statusPanel1
            // 
            this.statusPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusPanel1.Location = new System.Drawing.Point(2, 107);
            this.statusPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusPanel1.Name = "statusPanel1";
            this.statusPanel1.Size = new System.Drawing.Size(540, 50);
            this.statusPanel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1007, 733);
            this.Controls.Add(this.spindlePanel1);
            this.Controls.Add(this.bedViewer1);
            this.Controls.Add(this.gCodeStatus1);
            this.Controls.Add(this.motionPanel1);
            this.Controls.Add(this.statusPanel1);
            this.Controls.Add(this.mainRibbon);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon mainRibbon;
        private System.Windows.Forms.RibbonTab controlTab;
        private System.Windows.Forms.RibbonPanel runPanel;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.RibbonLabel ribbonLabel2;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel filePanel;
        private System.Windows.Forms.RibbonTab toolTab;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private StatusPanel statusPanel1;
        private MotionPanel motionPanel1;
        private GCodeStatus gCodeStatus1;
        private BedViewer bedViewer1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private SpindlePanel spindlePanel1;

    }
}

