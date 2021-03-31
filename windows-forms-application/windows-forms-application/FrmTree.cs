using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void FrmTree_Load(object sender, EventArgs e)
        {
            TreeView1.Nodes.Clear();
            TreeView1.Nodes.Add("Estudos");
            var node = TreeView1.Nodes[0];
            LoadDiretorios(@"C:\Users\ezefu\Desktop\Estudos\TORNE-SE UM PROGRAMADOR\C#", ref node);
        }

        private void LoadDiretorios(string diretorio, ref TreeNode node)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            foreach (string arquivo in arquivos)
            {
                node.Nodes.Add(Path.GetFileName(arquivo));
            }

            //Recursividade aplicada nos subdiretorios do diretorio principal
            string[] subdiretorios = Directory.GetDirectories(diretorio);
            foreach (string subdiretorio in subdiretorios)
            {
                TreeNode n = new TreeNode(Path.GetFileName(subdiretorio));
                LoadDiretorios(subdiretorio, ref n);
                node.Nodes.Add(n);
            }
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
