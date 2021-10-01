
namespace Graph_Winform
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjacentMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjacentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnView = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnKruskal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStartTraversal = new System.Windows.Forms.ComboBox();
            this.btnBfs = new System.Windows.Forms.Button();
            this.btnDfs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPaint = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVertexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.graphControl = new Graph_Winform.Components.GraphControl();
            this.menuStrip.SuspendLayout();
            this.pnView.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnPaint.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adjacentMatrixToolStripMenuItem,
            this.adjacentListToolStripMenuItem,
            this.toolStripSeparator2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // adjacentMatrixToolStripMenuItem
            // 
            this.adjacentMatrixToolStripMenuItem.Name = "adjacentMatrixToolStripMenuItem";
            this.adjacentMatrixToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.adjacentMatrixToolStripMenuItem.Text = "Adjacent Matrix";
            this.adjacentMatrixToolStripMenuItem.Click += new System.EventHandler(this.adjacentMatrixToolStripMenuItem_Click);
            // 
            // adjacentListToolStripMenuItem
            // 
            this.adjacentListToolStripMenuItem.Name = "adjacentListToolStripMenuItem";
            this.adjacentListToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.adjacentListToolStripMenuItem.Text = "Adjacent List";
            this.adjacentListToolStripMenuItem.Click += new System.EventHandler(this.adjacentListToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // pnView
            // 
            this.pnView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnView.Controls.Add(this.groupBox2);
            this.pnView.Controls.Add(this.groupBox1);
            this.pnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnView.Location = new System.Drawing.Point(0, 30);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(258, 532);
            this.pnView.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPrim);
            this.groupBox2.Controls.Add(this.btnKruskal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minimum spanning tree";
            // 
            // btnPrim
            // 
            this.btnPrim.AutoSize = true;
            this.btnPrim.Location = new System.Drawing.Point(147, 26);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(75, 30);
            this.btnPrim.TabIndex = 2;
            this.btnPrim.Text = "Prim";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnKruskal
            // 
            this.btnKruskal.AutoSize = true;
            this.btnKruskal.Location = new System.Drawing.Point(42, 26);
            this.btnKruskal.Name = "btnKruskal";
            this.btnKruskal.Size = new System.Drawing.Size(75, 30);
            this.btnKruskal.TabIndex = 2;
            this.btnKruskal.Text = "Kruskal";
            this.btnKruskal.UseVisualStyleBackColor = true;
            this.btnKruskal.Click += new System.EventHandler(this.btnKruskal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboStartTraversal);
            this.groupBox1.Controls.Add(this.btnBfs);
            this.groupBox1.Controls.Add(this.btnDfs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traversal";
            // 
            // cboStartTraversal
            // 
            this.cboStartTraversal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartTraversal.FormattingEnabled = true;
            this.cboStartTraversal.Location = new System.Drawing.Point(62, 26);
            this.cboStartTraversal.Name = "cboStartTraversal";
            this.cboStartTraversal.Size = new System.Drawing.Size(121, 28);
            this.cboStartTraversal.TabIndex = 4;
            // 
            // btnBfs
            // 
            this.btnBfs.AutoSize = true;
            this.btnBfs.Location = new System.Drawing.Point(147, 64);
            this.btnBfs.Name = "btnBfs";
            this.btnBfs.Size = new System.Drawing.Size(75, 30);
            this.btnBfs.TabIndex = 3;
            this.btnBfs.Text = "BFS";
            this.btnBfs.UseVisualStyleBackColor = true;
            this.btnBfs.Click += new System.EventHandler(this.btnBfs_Click);
            // 
            // btnDfs
            // 
            this.btnDfs.AutoSize = true;
            this.btnDfs.Location = new System.Drawing.Point(42, 64);
            this.btnDfs.Name = "btnDfs";
            this.btnDfs.Size = new System.Drawing.Size(75, 30);
            this.btnDfs.TabIndex = 2;
            this.btnDfs.Text = "DFS";
            this.btnDfs.UseVisualStyleBackColor = true;
            this.btnDfs.Click += new System.EventHandler(this.btnDfs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // pnPaint
            // 
            this.pnPaint.BackColor = System.Drawing.Color.White;
            this.pnPaint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPaint.ContextMenuStrip = this.contextMenu;
            this.pnPaint.Controls.Add(this.graphControl);
            this.pnPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPaint.Location = new System.Drawing.Point(258, 30);
            this.pnPaint.Name = "pnPaint";
            this.pnPaint.Size = new System.Drawing.Size(742, 532);
            this.pnPaint.TabIndex = 3;
            this.pnPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPaint_Paint);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.addVertexToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(151, 52);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // addVertexToolStripMenuItem
            // 
            this.addVertexToolStripMenuItem.Name = "addVertexToolStripMenuItem";
            this.addVertexToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.addVertexToolStripMenuItem.Text = "Add vertex";
            // 
            // openFileDlg
            // 
            this.openFileDlg.Title = "Open File";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Title = "Save File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sum";
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.Color.White;
            this.txtSum.Enabled = false;
            this.txtSum.ForeColor = System.Drawing.Color.Black;
            this.txtSum.Location = new System.Drawing.Point(122, 65);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 27);
            this.txtSum.TabIndex = 4;
            this.txtSum.TabStop = false;
            // 
            // graphControl
            // 
            this.graphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.graphControl.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.graphControl.BackColor = System.Drawing.SystemColors.Control;
            this.graphControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphControl.Location = new System.Drawing.Point(511, 4);
            this.graphControl.Margin = new System.Windows.Forms.Padding(4);
            this.graphControl.Name = "graphControl";
            this.graphControl.Size = new System.Drawing.Size(223, 95);
            this.graphControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.pnPaint);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnView.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnPaint.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.Panel pnPaint;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem addVertexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjacentMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjacentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Components.GraphControl graphControl;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.Button btnBfs;
        private System.Windows.Forms.Button btnDfs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnKruskal;
        private System.Windows.Forms.ComboBox cboStartTraversal;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label2;
    }
}

