using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EjunGridCtrls;

namespace pgbudget
{
    public partial class TemplateForm : Form
    {
        readonly PGDataClassesDataContext db = new PGDataClassesDataContext();

        public TemplateForm()
        {
            InitializeComponent();

            tempWorkBook.ShowNewTab = false;
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            templateBindingSource.DataSource = from template in db.template 
                                           orderby template.name select template;
        }

        private void 关闭_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tmlName = ((pgbudget.template)templateBindingSource.Current).name;
            tempWorkBook.SaveToFile("./template/" + tmlName + ".tml", true);
            db.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            template newtemplate = new template { name = "新建模板" };
            templateBindingSource.Add(newtemplate);
            db.template.InsertOnSubmit(newtemplate);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            templateBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tmlName = ((pgbudget.template)templateBindingSource.Current).name;

            try
            {
                tempWorkBook.LoadFromFile2("./template/" + tmlName + ".tml", true);
            }
            catch
            {
                MessageBox.Show("模板文件找不到！");
            }
                      
            //LoadProperty();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK) 
            {
                tempWorkBook.LoadFromExcel(openFileDialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tempWorkBook.SaveToExcel(saveFileDialog.FileName);
            }
        }

        private void LoadProperty()
        {
            //tempWorkBook
        }

        private void 下拉列表框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChoosePropertyForm chooseP = new ChoosePropertyForm())
            {
                chooseP.ShowDialog();

                if (chooseP.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    var curSheet = tempWorkBook.ActiveSheet;

                    Point p = CurCellPoint();

                    var col = p.X;
                    var row = p.Y;

                    SetCurCellType(TxCellType.cellComboBox);
                    
                    EjunGridCell cell = curSheet.get_Cells(col, row); 
                                     
                    cell.ClearItems();
                    foreach (var item in chooseP.ItemValues)
                    {
                        cell.AddItem(item);
                    }

                    if (curSheet.get_CellText(col - 1, row) == null)
                    {
                        curSheet.set_CellString(col - 1, row, chooseP.ItemName + ":");
                    }
                }
            }
        }

        private Point CurCellPoint()
        {
            var curSheet = (tempWorkBook.ActiveSheet);
            return new Point(curSheet.CurCol, curSheet.CurRow);
        }

        private void SetCurCellType(TxCellType cellType)
        {
            var curSheet = (tempWorkBook.ActiveSheet);
            var p = CurCellPoint();
            curSheet.set_CellTypes(p.X, p.Y, cellType);
        }

        private void 复选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurCellType(TxCellType.cellCheckBox);
        }

        private void 单选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurCellType(TxCellType.cellRadioBox);
        }

        private void 日期选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurCellType(TxCellType.cellCalendar);
        }

        private void 财务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurCellType(TxCellType.CellCurrency);
        }

    }
}
