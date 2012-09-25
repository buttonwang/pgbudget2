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
    public partial class PropertyForm : Form
    {
        readonly PGDataClassesDataContext db = new PGDataClassesDataContext();

        public PropertyForm()
        {
            InitializeComponent();
        }

        private void PropertyForm_Load(object sender, EventArgs e)
        {
            pgpropertyBS.DataSource = from pgproperty in db.pgproperty
                                      orderby pgproperty.name
                                      select pgproperty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pgpropertyBS.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pgpropertyBS.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SubmitChanges();
        }

    }
}
