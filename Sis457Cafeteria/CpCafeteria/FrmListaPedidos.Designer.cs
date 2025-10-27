﻿namespace CpCafeteria
{
    partial class FrmListaPedidos
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
            this.pnListaProductos = new System.Windows.Forms.Panel();
            this.lblReportePedidos = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pctBuscarObscuro = new System.Windows.Forms.PictureBox();
            this.pctBuscar = new System.Windows.Forms.PictureBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.pnListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarObscuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListaProductos
            // 
            this.pnListaProductos.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnListaProductos.Controls.Add(this.lblReportePedidos);
            this.pnListaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnListaProductos.Location = new System.Drawing.Point(0, 0);
            this.pnListaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.pnListaProductos.Name = "pnListaProductos";
            this.pnListaProductos.Size = new System.Drawing.Size(1400, 52);
            this.pnListaProductos.TabIndex = 14;
            // 
            // lblReportePedidos
            // 
            this.lblReportePedidos.AutoSize = true;
            this.lblReportePedidos.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportePedidos.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblReportePedidos.Location = new System.Drawing.Point(4, 0);
            this.lblReportePedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportePedidos.Name = "lblReportePedidos";
            this.lblReportePedidos.Size = new System.Drawing.Size(400, 47);
            this.lblReportePedidos.TabIndex = 5;
            this.lblReportePedidos.Text = "Reporte de Pedidos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(22, 99);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(268, 15);
            this.txtBuscar.TabIndex = 15;
            // 
            // pctBuscarObscuro
            // 
            this.pctBuscarObscuro.Image = global::CpCafeteria.Properties.Resources.lupa1;
            this.pctBuscarObscuro.Location = new System.Drawing.Point(13, 87);
            this.pctBuscarObscuro.Margin = new System.Windows.Forms.Padding(4);
            this.pctBuscarObscuro.Name = "pctBuscarObscuro";
            this.pctBuscarObscuro.Size = new System.Drawing.Size(316, 37);
            this.pctBuscarObscuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscarObscuro.TabIndex = 17;
            this.pctBuscarObscuro.TabStop = false;
            // 
            // pctBuscar
            // 
            this.pctBuscar.Image = global::CpCafeteria.Properties.Resources.lupa2;
            this.pctBuscar.Location = new System.Drawing.Point(13, 87);
            this.pctBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.pctBuscar.Name = "pctBuscar";
            this.pctBuscar.Size = new System.Drawing.Size(316, 37);
            this.pctBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscar.TabIndex = 16;
            this.pctBuscar.TabStop = false;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 136);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1371, 560);
            this.dgvPedidos.TabIndex = 18;
            // 
            // FrmListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1400, 738);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pctBuscarObscuro);
            this.Controls.Add(this.pctBuscar);
            this.Controls.Add(this.pnListaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaPedidos";
            this.Text = "FrmListaPedidos";
            this.pnListaProductos.ResumeLayout(false);
            this.pnListaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarObscuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnListaProductos;
        private System.Windows.Forms.Label lblReportePedidos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pctBuscarObscuro;
        private System.Windows.Forms.PictureBox pctBuscar;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}