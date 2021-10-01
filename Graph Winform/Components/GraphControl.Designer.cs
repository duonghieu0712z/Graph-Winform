
namespace Graph_Winform.Components
{
    partial class GraphControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumOfVertices = new System.Windows.Forms.TextBox();
            this.txtNumOfEdges = new System.Windows.Forms.TextBox();
            this.chkDirected = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumOfVertices
            // 
            this.txtNumOfVertices.BackColor = System.Drawing.Color.White;
            this.txtNumOfVertices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOfVertices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumOfVertices.Enabled = false;
            this.txtNumOfVertices.ForeColor = System.Drawing.Color.Black;
            this.txtNumOfVertices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNumOfVertices.Location = new System.Drawing.Point(160, 3);
            this.txtNumOfVertices.Name = "txtNumOfVertices";
            this.txtNumOfVertices.ReadOnly = true;
            this.txtNumOfVertices.ShortcutsEnabled = false;
            this.txtNumOfVertices.Size = new System.Drawing.Size(50, 27);
            this.txtNumOfVertices.TabIndex = 1;
            this.txtNumOfVertices.TabStop = false;
            // 
            // txtNumOfEdges
            // 
            this.txtNumOfEdges.BackColor = System.Drawing.Color.White;
            this.txtNumOfEdges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOfEdges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumOfEdges.Enabled = false;
            this.txtNumOfEdges.ForeColor = System.Drawing.Color.Black;
            this.txtNumOfEdges.Location = new System.Drawing.Point(160, 36);
            this.txtNumOfEdges.Name = "txtNumOfEdges";
            this.txtNumOfEdges.ReadOnly = true;
            this.txtNumOfEdges.Size = new System.Drawing.Size(50, 27);
            this.txtNumOfEdges.TabIndex = 2;
            this.txtNumOfEdges.TabStop = false;
            // 
            // chkDirected
            // 
            this.chkDirected.AutoCheck = false;
            this.chkDirected.AutoSize = true;
            this.chkDirected.BackColor = System.Drawing.Color.Transparent;
            this.chkDirected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDirected.ForeColor = System.Drawing.Color.Black;
            this.chkDirected.Location = new System.Drawing.Point(160, 69);
            this.chkDirected.Name = "chkDirected";
            this.chkDirected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDirected.Size = new System.Drawing.Size(50, 17);
            this.chkDirected.TabIndex = 3;
            this.chkDirected.TabStop = false;
            this.chkDirected.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of vertices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of edges";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkDirected, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNumOfVertices, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumOfEdges, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 95);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Directed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraphControl";
            this.Size = new System.Drawing.Size(223, 95);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumOfVertices;
        private System.Windows.Forms.TextBox txtNumOfEdges;
        private System.Windows.Forms.CheckBox chkDirected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}
