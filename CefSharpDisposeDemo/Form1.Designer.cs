namespace CefSharpDisposeDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateBtn = new System.Windows.Forms.ToolStripButton();
            this.SubProcessNumLabel = new System.Windows.Forms.ToolStripLabel();
            this.DsposeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DisposeParentBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateBtn,
            this.toolStripSeparator1,
            this.DsposeBtn,
            this.toolStripSeparator2,
            this.DisposeParentBtn,
            this.toolStripSeparator3,
            this.SubProcessNumLabel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(266, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateBtn
            // 
            this.CreateBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateBtn.Image")));
            this.CreateBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(50, 22);
            this.CreateBtn.Text = "Create";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // SubProcessNumLabel
            // 
            this.SubProcessNumLabel.Name = "SubProcessNumLabel";
            this.SubProcessNumLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // DsposeBtn
            // 
            this.DsposeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DsposeBtn.Image = ((System.Drawing.Image)(resources.GetObject("DsposeBtn.Image")));
            this.DsposeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DsposeBtn.Name = "DsposeBtn";
            this.DsposeBtn.Size = new System.Drawing.Size(59, 22);
            this.DsposeBtn.Text = "Dispose";
            this.DsposeBtn.Click += new System.EventHandler(this.DsposeBtn_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(823, 503);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(823, 528);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DisposeParentBtn
            // 
            this.DisposeParentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DisposeParentBtn.Image = ((System.Drawing.Image)(resources.GetObject("DisposeParentBtn.Image")));
            this.DisposeParentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisposeParentBtn.Name = "DisposeParentBtn";
            this.DisposeParentBtn.Size = new System.Drawing.Size(96, 22);
            this.DisposeParentBtn.Text = "DisposeParent";
            this.DisposeParentBtn.Click += new System.EventHandler(this.DisposeParentBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 528);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton CreateBtn;
        private ToolStripLabel SubProcessNumLabel;
        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripButton DsposeBtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton DisposeParentBtn;
        private ToolStripSeparator toolStripSeparator3;
    }
}