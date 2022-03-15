
namespace Presentacion.Forms
{
    partial class Notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuClickAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClickEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClickNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClickCarpeta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClickArchivotxt = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(268, 423);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(523, 423);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carpetaToolStripMenuItem,
            this.archivoDeTextoToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClickAbrir,
            this.menuClickEliminar,
            this.menuClickNuevo});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // menuClickAbrir
            // 
            this.menuClickAbrir.Name = "menuClickAbrir";
            this.menuClickAbrir.Size = new System.Drawing.Size(180, 22);
            this.menuClickAbrir.Text = "Abrir";
            this.menuClickAbrir.Click += new System.EventHandler(this.menuClickAbrir_Click);
            // 
            // menuClickEliminar
            // 
            this.menuClickEliminar.Name = "menuClickEliminar";
            this.menuClickEliminar.Size = new System.Drawing.Size(180, 22);
            this.menuClickEliminar.Text = "Eliminar";
            this.menuClickEliminar.Click += new System.EventHandler(this.menuClickEliminar_Click);
            // 
            // menuClickNuevo
            // 
            this.menuClickNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClickCarpeta,
            this.menuClickArchivotxt});
            this.menuClickNuevo.Name = "menuClickNuevo";
            this.menuClickNuevo.Size = new System.Drawing.Size(180, 22);
            this.menuClickNuevo.Text = "Nuevo";
            this.menuClickNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // menuClickCarpeta
            // 
            this.menuClickCarpeta.Name = "menuClickCarpeta";
            this.menuClickCarpeta.Size = new System.Drawing.Size(180, 22);
            this.menuClickCarpeta.Text = "Carpeta";
            this.menuClickCarpeta.Click += new System.EventHandler(this.menuClickCarpeta_Click);
            // 
            // menuClickArchivotxt
            // 
            this.menuClickArchivotxt.Name = "menuClickArchivotxt";
            this.menuClickArchivotxt.Size = new System.Drawing.Size(180, 22);
            this.menuClickArchivotxt.Text = "Archivo de texto";
            this.menuClickArchivotxt.Click += new System.EventHandler(this.menuClickArchivotxt_Click);
            // 
            // carpetaToolStripMenuItem
            // 
            this.carpetaToolStripMenuItem.Name = "carpetaToolStripMenuItem";
            this.carpetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carpetaToolStripMenuItem.Text = "Carpeta";
            this.carpetaToolStripMenuItem.Click += new System.EventHandler(this.carpetaToolStripMenuItem_Click);
            // 
            // archivoDeTextoToolStripMenuItem
            // 
            this.archivoDeTextoToolStripMenuItem.Name = "archivoDeTextoToolStripMenuItem";
            this.archivoDeTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.archivoDeTextoToolStripMenuItem.Text = "Archivo de texto";
            this.archivoDeTextoToolStripMenuItem.Click += new System.EventHandler(this.archivoDeTextoToolStripMenuItem_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuClickAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuClickEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuClickNuevo;
        private System.Windows.Forms.ToolStripMenuItem menuClickCarpeta;
        private System.Windows.Forms.ToolStripMenuItem menuClickArchivotxt;
        private System.Windows.Forms.ToolStripMenuItem carpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoDeTextoToolStripMenuItem;
    }
}