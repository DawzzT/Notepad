using AppCore.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class Notepad : Form
    {
        private string generalPath = null;

        private IDirectoryServices directServices;
        public Notepad(AppCore.IServices.IDirectoryServices directoryServices)
        {
            InitializeComponent();
            this.directServices = directoryServices;

        }
        private TreeNode AddDirectoryNodes(DirectoryInfo directoryInfo)
        {
          
                TreeNode root = new TreeNode("👽 " + directoryInfo.Name);
                String path = directoryInfo.FullName;
                root.Tag = path;
                foreach (var items in directoryInfo.GetFiles())
                {
                    if (Path.GetExtension(items.FullName) == ".txt")
                    {
                        TreeNode file = new TreeNode("✍ " + items.Name);
                        file.Tag = items.FullName;
                        root.Nodes.Add(file);
                    }
                }
                foreach (var items in directoryInfo.GetDirectories())
                {
                    root.Nodes.Add(AddDirectoryNodes(items));
                }

                return root;
           
           
           
        }

        private void fileNew()
        {
            try
            {
                if (treeView1.SelectedNode.Tag.ToString()==null)
                {
                    MessageBox.Show("Ningun archivo seleccionado");
                    return;
                }
                treeView1.BeginUpdate();
                Nuevo nuevo = new Nuevo();
                nuevo.ShowDialog();
                string name = nuevo.nombre + ".txt";
                if (name!= null)
                {
                    DirectoryInfo info = directServices.CreateFile(treeView1.SelectedNode.Tag.ToString(), @"\" + name);
                    TreeNode node = new TreeNode( name);
                    node.Tag = info.FullName;
                    treeView1.SelectedNode.Nodes.Add(node);
                    
                }
                else
                {
                    MessageBox.Show("Ningun archivo seleccionado");
                }
                treeView1.EndUpdate();
            }
            catch (Exception)
            {

                MessageBox.Show("Ningun archivo seleccionado");
            }
        }
        private void folderNew()
        {

            try
            {

                if (treeView1.SelectedNode.Tag.ToString()== null)
                {
                    MessageBox.Show("Please select a file.");
                    return;
                }
                treeView1.BeginUpdate();
                Nuevo nuevo = new Nuevo();
                nuevo.ShowDialog();
                string name = nuevo.nombre;
                if (name != null)
                {
                    DirectoryInfo info = directServices.Create(treeView1.SelectedNode.Tag.ToString() + @"\" + name);
                    treeView1.SelectedNode.Nodes.Add(AddDirectoryNodes(info));
                }
                else
                {
                    MessageBox.Show("Please select a file.");
                }
                treeView1.EndUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a file.");
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (generalPath == null)
            {
                nuevoToolStripMenuItem.Enabled = false;
                guardarToolStripMenuItem.Enabled = false;
                salirToolStripMenuItem.Enabled = true;
                abrirToolStripMenuItem.Enabled = true;
            }
            else
            {
                nuevoToolStripMenuItem.Enabled = true;
                guardarToolStripMenuItem.Enabled = true;
                salirToolStripMenuItem.Enabled = true;
                abrirToolStripMenuItem.Enabled = true;
            }
            if (generalPath == string.Empty || richTextBox1.Text == string.Empty)
            {
                guardarToolStripMenuItem.Enabled = false;
            }
            else
            {
                guardarToolStripMenuItem.Enabled = true;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selected = new FolderBrowserDialog();
          
            if (selected.ShowDialog() == DialogResult.OK)
            {
               generalPath = selected.SelectedPath;
               treeView1.Nodes.Add(AddDirectoryNodes(directServices.Create(generalPath)));
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string ruta;
                string extension;
                try
                {
                    treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);

                    if (treeView1.SelectedNode == null)
                    {
                        MessageBox.Show("No ha seleccionado ningún archivo");
                        contextMenuStrip1.Close();
                        return;
                    }
                    
                     ruta = treeView1.SelectedNode.FullPath;
                   
                    extension = Path.GetExtension(ruta);
                    if (extension == ".txt")
                    {
                        menuClickNuevo.Enabled = false;
                        menuClickEliminar.Enabled = true;                     
                        menuClickAbrir.Enabled = true;
                    }
                    else
                    {
                        menuClickNuevo.Enabled = true;
                        menuClickEliminar.Enabled = true;
                        menuClickAbrir.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void menuClickAbrir_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string ruta;
            if (treeView1.SelectedNode == null)
            {
                ruta = generalPath;
            }
            else
            {
                ruta = treeView1.SelectedNode.FullPath;
               
            }

            string extension = Path.GetExtension(ruta);
            if (extension == ".txt")
            {
                richTextBox1.Text = directServices.Read(treeView1.SelectedNode.Tag.ToString());
            }
            else
            {
                MessageBox.Show("No es un archivode texto");
            }
        }

        private void menuClickCarpeta_Click(object sender, EventArgs e)
        {
            folderNew();
        }

        private void menuClickArchivotxt_Click(object sender, EventArgs e)
        {
            fileNew();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuClickEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String path = treeView1.SelectedNode.Tag.ToString();
              
                    if (Path.IsPathRooted(path))
                    {
                        if (Path.HasExtension(path))
                        {
                            File.Delete(path);

                            treeView1.Nodes.Remove(treeView1.SelectedNode);
                        }
                        else
                        {
                            directServices.Delete(path);

                            treeView1.Nodes.Remove(treeView1.SelectedNode);
                        }

                    }
              
                
            }
            catch (Exception)
            {

                MessageBox.Show("No puede eliminar una carpeta");
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            directServices.OverWrite(treeView1.SelectedNode.Tag.ToString(), richTextBox1.Text);
            treeView1.EndUpdate();
            richTextBox1.Clear();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            menuClickAbrir_Click(sender , e);
        }

        private void carpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderNew();
        }

        private void archivoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileNew();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }
    }
}
