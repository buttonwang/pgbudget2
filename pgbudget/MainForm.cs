using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace pgbudget
{
    public partial class MainForm : Form
    {
        readonly PGDataClassesDataContext db = new PGDataClassesDataContext();

        private project p = null;

        private Budget budget = new Budget();

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        public MainForm()
        {
            InitializeComponent();

            //InitProject(0);

            InitSetup();
        }

        //初始化工程信息
        private void InitProject(int id)
        {
            p = (from project in db.projects
                 where project.id == id
                 select project).SingleOrDefault();
            if (p == null)
            {
                p = new project { 工程编号 = "新建工程" };
                db.projects.InsertOnSubmit(p);
            }
            ProjectPropertyGrid.SelectedObject = p;
        }
        
        //初始化设置
        private void InitSetup()
        {
            InitYSTitle();

            InitProjectItemDivision();

            //EGridTotal.LoadFromExcel("工程模板-总算表.xls", 0);
            //eWorkbook.NewSheet("sheeet1");
            //eWorkbook.GetSheetByName("sheeet1").LoadFromExcel("工程模板-总算表.xls", 0);
            //eWorkbook.LoadFromExcel("工程模板2.xls");

        }

        //初始化预算项目列标题
        private void InitYSTitle()
        {
            ETreeGridJZ.ColCount = Const.ysColumns.Count() + 1;
           
            for (int i = 0; i < Const.ysColumns.Count(); i++)
            {
                ETreeGridJZ.set_CellString(i+1, 0, Const.ysColumns[i]);
            }           
        }

        //初始化工程项目划分树
        private void InitProjectItemDivision()
        {
            InitJZGC();
            InitAZGC();
            InitQTGC();
        }

        //初始化建筑工程项目划分
        private void InitJZGC()
        {
            treeViewJZIndex.Nodes.Add(budget.IndexTree("jz"));
            treeViewJZIndex.ExpandAll();
        }

        //初始化安装工程项目划分
        private void InitAZGC()
        {
            //treeViewJZIndex.Nodes.Add(budget.IndexTree("jz"));
            //treeViewJZIndex.ExpandAll();
        }

        //初始化其他工程项目划分
        private void InitQTGC()
        {
            //treeViewJZIndex.Nodes.Add(budget.IndexTree("jz"));
            //treeViewJZIndex.ExpandAll();
        }

        //打开工程信息
        public void OpenProject(int id)
        {
            InitProject(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {                       
            db.SubmitChanges();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewProjectForm newProjectForm = new NewProjectForm())
            {
                newProjectForm.ShowDialog();
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindProjectForm fgForm = new FindProjectForm();
            try
            {
                fgForm.ShowDialog();
            }
            finally
            {
                if (fgForm != null)
                    fgForm.Dispose();
            }
        }

        private void 定额维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DictForm deForm = new DictForm("定额");
            try
            {
                deForm.ShowDialog();
            }
            finally
            {
                if (deForm != null)
                    deForm.Dispose();
            }
        }

        private void 材机维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DictForm cjForm = new DictForm("材机");
            try
            {
                cjForm.ShowDialog();
            }
            finally
            {
                if (cjForm != null)
                    cjForm.Dispose();
            }
        }

        private void 设备维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DictForm sbForm = new DictForm("设备");
            try
            {
                sbForm.ShowDialog();
            }
            finally
            {
                if (sbForm != null)
                    sbForm.Dispose();
            }
        }

        private void 装材维护ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DictForm zcForm = new DictForm("装材");
            try
            {
                zcForm.ShowDialog();
            }
            finally
            {
                if (zcForm != null)
                    zcForm.Dispose(); 
            }
        }

        private void 组件库维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZJKForm zjkForm = new ZJKForm();
            try
            {
                zjkForm.ShowDialog();
            }
            finally
            {
                if (zjkForm != null)
                    zjkForm.Dispose();
            }
        }

        private void 表达式引擎ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FleeForm fleeForm = new FleeForm())
            {
                fleeForm.ShowDialog();
            }
            
        }

        private void 模板管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TemplateForm templateForm = new TemplateForm())
            {
                templateForm.ShowDialog();
            }
        }

        private void 属性维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PropertyForm propertyForm = new PropertyForm())
            {
                propertyForm.ShowDialog();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox aboutbox = new AboutBox())
            {
                aboutbox.ShowDialog();
            }
        }
       
    }
}