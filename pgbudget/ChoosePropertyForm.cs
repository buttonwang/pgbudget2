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
    public partial class ChoosePropertyForm : Form
    {
        readonly PGDataClassesDataContext db = new PGDataClassesDataContext();

        public String ItemName;

        public String[] ItemValues;

        public ChoosePropertyForm()
        {
            InitializeComponent();
        }

        private void ChoosePropertyForm_Load(object sender, EventArgs e)
        {
            var query = from property in db.pgproperty
                       select new { Name = property.name };
            lbProperty.DataSource = query.Distinct().ToList();
            lbProperty.DisplayMember = "Name";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lbProperty.SelectedItem == null)
            {
                MessageBox.Show("请先选择要设置的属性！");
                return;
            }

            ItemName = lbProperty.Text;

            var query = (from property in db.pgproperty
                         where property.name.Equals(lbProperty.Text)
                         select property.value);

            ItemValues = query.ToArray();
        }
    }
}
