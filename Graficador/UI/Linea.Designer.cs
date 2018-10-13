namespace Graficador.UI
{
    partial class Linea
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nX1 = new System.Windows.Forms.NumericUpDown();
            this.nY1 = new System.Windows.Forms.NumericUpDown();
            this.nX2 = new System.Windows.Forms.NumericUpDown();
            this.nY2 = new System.Windows.Forms.NumericUpDown();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.butCancelar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nY2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nX2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nY1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nX1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butAceptar, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 139);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y2";
            // 
            // nX1
            // 
            this.nX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nX1.Location = new System.Drawing.Point(146, 3);
            this.nX1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nX1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nX1.Name = "nX1";
            this.nX1.Size = new System.Drawing.Size(138, 20);
            this.nX1.TabIndex = 4;
            // 
            // nY1
            // 
            this.nY1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nY1.Location = new System.Drawing.Point(146, 29);
            this.nY1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nY1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nY1.Name = "nY1";
            this.nY1.Size = new System.Drawing.Size(138, 20);
            this.nY1.TabIndex = 5;
            // 
            // nX2
            // 
            this.nX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.nX2.Location = new System.Drawing.Point(146, 55);
            this.nX2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nX2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nX2.Name = "nX2";
            this.nX2.Size = new System.Drawing.Size(138, 20);
            this.nX2.TabIndex = 6;
            // 
            // nY2
            // 
            this.nY2.Dock = System.Windows.Forms.DockStyle.Top;
            this.nY2.Location = new System.Drawing.Point(146, 81);
            this.nY2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nY2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nY2.Name = "nY2";
            this.nY2.Size = new System.Drawing.Size(138, 20);
            this.nY2.TabIndex = 7;
            // 
            // butAceptar
            // 
            this.butAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butAceptar.Location = new System.Drawing.Point(34, 107);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 8;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butCancelar.AutoSize = true;
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(177, 107);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 9;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // Linea
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancelar;
            this.ClientSize = new System.Drawing.Size(287, 139);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Linea";
            this.Text = "Linea";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.NumericUpDown nY2;
        private System.Windows.Forms.NumericUpDown nX2;
        private System.Windows.Forms.NumericUpDown nY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nX1;
        private System.Windows.Forms.Button butAceptar;
    }
}