namespace Graficador.UI
{
    partial class Principal
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
            this.pDibujable = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLineas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mostrar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.colorLineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDibujable
            // 
            this.pDibujable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDibujable.Location = new System.Drawing.Point(0, 0);
            this.pDibujable.Name = "pDibujable";
            this.pDibujable.Size = new System.Drawing.Size(800, 327);
            this.pDibujable.TabIndex = 1;
            this.pDibujable.Paint += new System.Windows.Forms.PaintEventHandler(this.pDibujable_Paint_1);
            this.pDibujable.Resize += new System.EventHandler(this.pDibujable_Resize);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.lineasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalaXToolStripMenuItem,
            this.escalaYToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.colorLineasToolStripMenuItem,
            this.colorFondoToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // escalaXToolStripMenuItem
            // 
            this.escalaXToolStripMenuItem.Name = "escalaXToolStripMenuItem";
            this.escalaXToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.escalaXToolStripMenuItem.Text = "Escala X";
            this.escalaXToolStripMenuItem.Click += new System.EventHandler(this.escalaXToolStripMenuItem_Click);
            // 
            // escalaYToolStripMenuItem
            // 
            this.escalaYToolStripMenuItem.Name = "escalaYToolStripMenuItem";
            this.escalaYToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.escalaYToolStripMenuItem.Text = "Escala Y";
            this.escalaYToolStripMenuItem.Click += new System.EventHandler(this.escalaYToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color guia";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.colorFondoToolStripMenuItem.Text = "Color fondo";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // lineasToolStripMenuItem
            // 
            this.lineasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            this.lineasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lineasToolStripMenuItem.Text = "Lineas";
            // 
            // agregarNuevaToolStripMenuItem
            // 
            this.agregarNuevaToolStripMenuItem.Name = "agregarNuevaToolStripMenuItem";
            this.agregarNuevaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.agregarNuevaToolStripMenuItem.Text = "Agregar nueva";
            this.agregarNuevaToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevaToolStripMenuItem_Click);
            // 
            // dgvLineas
            // 
            this.dgvLineas.AllowUserToAddRows = false;
            this.dgvLineas.AllowUserToDeleteRows = false;
            this.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.X1,
            this.Y1,
            this.X2,
            this.Y2,
            this.Pendiente,
            this.Mostrar});
            this.dgvLineas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLineas.Location = new System.Drawing.Point(0, 0);
            this.dgvLineas.MultiSelect = false;
            this.dgvLineas.Name = "dgvLineas";
            this.dgvLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLineas.Size = new System.Drawing.Size(800, 95);
            this.dgvLineas.TabIndex = 2;
            this.dgvLineas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLineas_CellValueChanged);
            this.dgvLineas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvLineas_CurrentCellDirtyStateChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            // 
            // Y1
            // 
            this.Y1.HeaderText = "Y1";
            this.Y1.Name = "Y1";
            this.Y1.ReadOnly = true;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            // 
            // Y2
            // 
            this.Y2.HeaderText = "Y2";
            this.Y2.Name = "Y2";
            this.Y2.ReadOnly = true;
            // 
            // Pendiente
            // 
            this.Pendiente.HeaderText = "Pendiente";
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.ReadOnly = true;
            // 
            // Mostrar
            // 
            this.Mostrar.HeaderText = "Mostrar";
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvLineas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pDibujable);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.TabIndex = 2;
            // 
            // colorLineasToolStripMenuItem
            // 
            this.colorLineasToolStripMenuItem.Name = "colorLineasToolStripMenuItem";
            this.colorLineasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorLineasToolStripMenuItem.Text = "Color lineas";
            this.colorLineasToolStripMenuItem.Click += new System.EventHandler(this.colorLineasToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pDibujable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFondoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvLineas;
        private System.Windows.Forms.ToolStripMenuItem lineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendiente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mostrar;
        private System.Windows.Forms.ToolStripMenuItem colorLineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
    }
}