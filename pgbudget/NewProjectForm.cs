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
    public partial class NewProjectForm : Form
    {
        readonly PGDataClassesDataContext db = new PGDataClassesDataContext();

        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void NewProjectForm_Load(object sender, EventArgs e)
        {
            var query = from template in db.template
                        select new { Id = template.id, Name = template.name };
            cboTemplate.DataSource = query.ToList();
            cboTemplate.ValueMember = "Id";
            cboTemplate.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbProjectName.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入工程名称");
                tbProjectName.Focus();                
            }
            else if (cboTemplate.SelectedItem == null )
            {
                MessageBox.Show("请选择工程模板");
                cboTemplate.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
