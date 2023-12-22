
namespace modbus_plc_grafik.Forms
{
    partial class FormMain
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
            this.modbusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartCreationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelChartCreationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modbusToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.recordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modbusToolStripMenuItem
            // 
            this.modbusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.modbusToolStripMenuItem.Name = "modbusToolStripMenuItem";
            this.modbusToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.modbusToolStripMenuItem.Text = "modbus";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartCreationToolStripMenuItem,
            this.manuelChartCreationToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.chartToolStripMenuItem.Text = "chart";
            // 
            // chartCreationToolStripMenuItem
            // 
            this.chartCreationToolStripMenuItem.Name = "chartCreationToolStripMenuItem";
            this.chartCreationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.chartCreationToolStripMenuItem.Text = "chart creation";
            this.chartCreationToolStripMenuItem.Click += new System.EventHandler(this.chartCreationToolStripMenuItem_Click);
            // 
            // manuelChartCreationToolStripMenuItem
            // 
            this.manuelChartCreationToolStripMenuItem.Name = "manuelChartCreationToolStripMenuItem";
            this.manuelChartCreationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manuelChartCreationToolStripMenuItem.Text = "manuel chart creation";
            this.manuelChartCreationToolStripMenuItem.Click += new System.EventHandler(this.manuelChartCreationToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printRecordToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.recordsToolStripMenuItem.Text = "print";
            // 
            // printRecordToolStripMenuItem
            // 
            this.printRecordToolStripMenuItem.Name = "printRecordToolStripMenuItem";
            this.printRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printRecordToolStripMenuItem.Text = "print chart";
            this.printRecordToolStripMenuItem.Click += new System.EventHandler(this.printRecordToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 419);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modbusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartCreationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelChartCreationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printRecordToolStripMenuItem;
    }
}