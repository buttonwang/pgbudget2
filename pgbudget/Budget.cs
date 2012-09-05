using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//工程分为建筑、安装、拆除工程 (jz, az, cc)

namespace pgbudget
{
    class Budget
    {
        readonly PGDataClassesDataContext db = new PGDataClassesDataContext();
        
        private TreeNode findNode;

        private TreeNode FindRecursive(TreeNode treeNode, int pid)
        {
            if ((int)treeNode.Tag == pid) findNode = treeNode;

            foreach (TreeNode tn in treeNode.Nodes)
            {
                if ((int)tn.Tag == pid) findNode = tn; 
                else FindRecursive(tn, pid);
            }

            return findNode;
        }

        public TreeNode IndexTree(String indexName)
        {

            if (indexName == "jz")
            {
                var node = new TreeNode { Text = "项目拆分表", Tag = 0 };
                                
                var query = from jzgc in db.jzgcs
                        select new {mc=jzgc.mc, ID=jzgc.id, ParentID = jzgc.pid};

                foreach (var jzindex in query)
                {
                    findNode = null;
                    FindRecursive(node, jzindex.ParentID.Value);
                    if (findNode != null) findNode.Nodes.Add(new TreeNode { Text = jzindex.mc, Tag = jzindex.ID });
                    else node = new TreeNode { Text = jzindex.mc, Tag = jzindex.ID };
                }

                return node;
            }
            
            return null;
        }
    }

}
