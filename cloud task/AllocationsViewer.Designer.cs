namespace AllocationsApplication
{
    partial class AllocationsViewerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllocationsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.errorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.generateAllocationsButton = new System.Windows.Forms.Button();
            this.allocationsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.urlComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.validateToolStripMenuItem,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(645, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAllocationsFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openAllocationsFileToolStripMenuItem
            // 
            this.openAllocationsFileToolStripMenuItem.Name = "openAllocationsFileToolStripMenuItem";
            this.openAllocationsFileToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openAllocationsFileToolStripMenuItem.Text = "Open";
            this.openAllocationsFileToolStripMenuItem.Click += new System.EventHandler(this.OpenAllocationsFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allocationToolStripMenuItem});
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.validateToolStripMenuItem.Text = "Validate";
            // 
            // allocationToolStripMenuItem
            // 
            this.allocationToolStripMenuItem.Enabled = false;
            this.allocationToolStripMenuItem.Name = "allocationToolStripMenuItem";
            this.allocationToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.allocationToolStripMenuItem.Text = "Allocations";
            this.allocationToolStripMenuItem.Click += new System.EventHandler(this.AllocationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorListToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem2.Text = "View";
            // 
            // errorListToolStripMenuItem
            // 
            this.errorListToolStripMenuItem.Name = "errorListToolStripMenuItem";
            this.errorListToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.errorListToolStripMenuItem.Text = "Error List";
            this.errorListToolStripMenuItem.Click += new System.EventHandler(this.ErrorListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.aboutToolStripMenuItem.Text = "About Allocations";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "TAFF files (*.taff)|*.taff|All files (*.*)|*.*";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.urlComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.generateAllocationsButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.allocationsWebBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(645, 705);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 14;
            // 
            // generateAllocationsButton
            // 
            this.generateAllocationsButton.Location = new System.Drawing.Point(481, 0);
            this.generateAllocationsButton.Name = "generateAllocationsButton";
            this.generateAllocationsButton.Size = new System.Drawing.Size(152, 26);
            this.generateAllocationsButton.TabIndex = 15;
            this.generateAllocationsButton.Text = "Generate Allocations";
            this.generateAllocationsButton.UseVisualStyleBackColor = true;
            this.generateAllocationsButton.Click += new System.EventHandler(this.generateAllocationsButton_Click);
            // 
            // allocationsWebBrowser
            // 
            this.allocationsWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allocationsWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.allocationsWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.allocationsWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.allocationsWebBrowser.Name = "allocationsWebBrowser";
            this.allocationsWebBrowser.Size = new System.Drawing.Size(645, 666);
            this.allocationsWebBrowser.TabIndex = 12;
            // 
            // urlComboBox
            // 
            this.urlComboBox.FormattingEnabled = true;
            this.urlComboBox.Items.AddRange(new object[] {
            "https://sit323sa.blob.core.windows.net/at2/TestSmall.cff",
            "https://sit323sa.blob.core.windows.net/at2/TestLarge.cff",
            "https://sit323sa.blob.core.windows.net/at2/TestExtraLarge.cff"});
            this.urlComboBox.Location = new System.Drawing.Point(0, 2);
            this.urlComboBox.Name = "urlComboBox";
            this.urlComboBox.Size = new System.Drawing.Size(475, 24);
            this.urlComboBox.TabIndex = 16;
            this.urlComboBox.Text = "https://sit323sa.blob.core.windows.net/at2/TestSmall.cff";
            // 
            // AllocationsViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 733);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllocationsViewerForm";
            this.Text = "Allocations - Assessment Task 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openAllocationsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem errorListToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button generateAllocationsButton;
        private System.Windows.Forms.WebBrowser allocationsWebBrowser;
        private System.Windows.Forms.ComboBox urlComboBox;
    }
}

