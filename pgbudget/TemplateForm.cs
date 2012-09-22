using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pgbudget
{
    public partial class TemplateForm : Form
    {
        readonly PGDataClassesDataContext db = new PGDataClassesDataContext();

        public TemplateForm()
        {
            InitializeComponent();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            templateBindingSource.DataSource = from template in db.template orderby template.name select template;
        }

        private void 关闭_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempWorkBook.SaveToFile("tempnam", true);
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

    }
}
