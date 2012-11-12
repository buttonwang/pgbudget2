namespace pgbudget
{
    partial class TemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tmlDG = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempWorkBook = new AxEjunGridCtrls.AxEjunWorkbook();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.常规ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复选框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单选框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下拉列表框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日期选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.财务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmlDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempWorkBook)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 32);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(767, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "关闭";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.关闭_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(249, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(508, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "导入Excel模板";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(609, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "导出Excel模板";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "打开";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "新建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tmlDG);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tempWorkBook);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(854, 440);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 2;
            // 
            // tmlDG
            // 
            this.tmlDG.AllowUserToAddRows = false;
            this.tmlDG.AllowUserToOrderColumns = true;
            this.tmlDG.AutoGenerateColumns = false;
            this.tmlDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tmlDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tmlDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.tmlDG.DataSource = this.templateBindingSource;
            this.tmlDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tmlDG.Location = new System.Drawing.Point(0, 0);
            this.tmlDG.MultiSelect = false;
            this.tmlDG.Name = "tmlDG";
            this.tmlDG.RowHeadersVisible = false;
            this.tmlDG.RowTemplate.Height = 23;
            this.tmlDG.Size = new System.Drawing.Size(180, 440);
            this.tmlDG.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "模板名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataSource = typeof(pgbudget.template);
            // 
            // tempWorkBook
            // 
            this.tempWorkBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempWorkBook.Location = new System.Drawing.Point(0, 25);
            this.tempWorkBook.Name = "tempWorkBook";
            this.tempWorkBook.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tempWorkBook.OcxState")));
            this.tempWorkBook.Size = new System.Drawing.Size(670, 415);
            this.tempWorkBook.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.常规ToolStripMenuItem,
            this.复选框ToolStripMenuItem,
            this.单选框ToolStripMenuItem,
            this.下拉列表框ToolStripMenuItem,
            this.日期选择ToolStripMenuItem,
            this.财务ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(84, 22);
            this.toolStripSplitButton1.Text = "单元格类型";
            // 
            // 常规ToolStripMenuItem
            // 
            this.常规ToolStripMenuItem.Name = "常规ToolStripMenuItem";
            this.常规ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.常规ToolStripMenuItem.Text = "常规";
            // 
            // 复选框ToolStripMenuItem
            // 
            this.复选框ToolStripMenuItem.Name = "复选框ToolStripMenuItem";
            this.复选框ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.复选框ToolStripMenuItem.Text = "复选框";
            this.复选框ToolStripMenuItem.Click += new System.EventHandler(this.复选框ToolStripMenuItem_Click);
            // 
            // 单选框ToolStripMenuItem
            // 
            this.单选框ToolStripMenuItem.Name = "单选框ToolStripMenuItem";
            this.单选框ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.单选框ToolStripMenuItem.Text = "单选框";
            this.单选框ToolStripMenuItem.Click += new System.EventHandler(this.单选框ToolStripMenuItem_Click);
            // 
            // 下拉列表框ToolStripMenuItem
            // 
            this.下拉列表框ToolStripMenuItem.Name = "下拉列表框ToolStripMenuItem";
            this.下拉列表框ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下拉列表框ToolStripMenuItem.Text = "组合列表框";
            this.下拉列表框ToolStripMenuItem.Click += new System.EventHandler(this.下拉列表框ToolStripMenuItem_Click);
            // 
            // 日期选择ToolStripMenuItem
            // 
            this.日期选择ToolStripMenuItem.Name = "日期选择ToolStripMenuItem";
            this.日期选择ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.日期选择ToolStripMenuItem.Text = "日期选择";
            this.日期选择ToolStripMenuItem.Click += new System.EventHandler(this.日期选择ToolStripMenuItem_Click);
            // 
            // 财务ToolStripMenuItem
            // 
            this.财务ToolStripMenuItem.Name = "财务ToolStripMenuItem";
            this.财务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.财务ToolStripMenuItem.Text = "财务金额";
            this.财务ToolStripMenuItem.Click += new System.EventHandler(this.财务ToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xls";
            this.openFileDialog.Filter = "Excel|*.xls";
            this.openFileDialog.Title = "导入Excel模板";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Excel|*.xls";
            this.saveFileDialog.Title = "导出Excel模板";
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 472);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "模板管理";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tmlDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempWorkBook)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView tmlDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private AxEjunGridCtrls.AxEjunWorkbook tempWorkBook;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 常规ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复选框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单选框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下拉列表框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日期选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 财务ToolStripMenuItem;
    }
}