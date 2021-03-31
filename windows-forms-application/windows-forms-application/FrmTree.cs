using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_forms_application
{
    public partial class FrmTree : Form
    {
        public FrmTree()
        {
            InitializeComponent();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void BtnChecados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LerChecados(TreeView1.Nodes[0]));
        }

        private string LerChecados(TreeNode node, string checkeds = "")
        {
           foreach (TreeNode n in node.Nodes)
           {
                if (n.Checked)
                {
                    checkeds += n.Text + ", ";
                }
                checkeds = LerChecados(n, checkeds);
           }

            return checkeds;
        }
    }
}
