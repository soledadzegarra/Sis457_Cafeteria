namespace CpCafeteria
{
    partial class FrmCategoria
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
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.btnSalirCat = new System.Windows.Forms.Button();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.lblListaCategorias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCategoria.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAgregarCategoria.Location = new System.Drawing.Point(374, 25);
            this.lblAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(191, 41);
            this.lblAgregarCategoria.TabIndex = 13;
            this.lblAgregarCategoria.Text = "AGREGAR CATEGORIA";
            // 
            // btnSalirCat
            // 
            this.btnSalirCat.BackColor = System.Drawing.Color.Red;
            this.btnSalirCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCat.Location = new System.Drawing.Point(416, 239);
            this.btnSalirCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirCat.Name = "btnSalirCat";
            this.btnSalirCat.Size = new System.Drawing.Size(100, 28);
            this.btnSalirCat.TabIndex = 12;
            this.btnSalirCat.Text = "SALIR";
            this.btnSalirCat.UseVisualStyleBackColor = false;
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCategoria.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNombreCategoria.Location = new System.Drawing.Point(283, 95);
            this.lblNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(87, 21);
            this.lblNombreCategoria.TabIndex = 11;
            this.lblNombreCategoria.Text = "NOMBRE:";
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(378, 94);
            this.txtNombreCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(185, 22);
            this.txtNombreCat.TabIndex = 10;
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.Peru;
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.Location = new System.Drawing.Point(416, 137);
            this.btnAgregarCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarCat.TabIndex = 9;
            this.btnAgregarCat.Text = "AGREGAR";
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            // 
            // lstCategorias
            // 
            this.lstCategorias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstCategorias.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategorias.ForeColor = System.Drawing.Color.Black;
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 19;
            this.lstCategorias.Location = new System.Drawing.Point(51, 69);
            this.lstCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(169, 156);
            this.lstCategorias.TabIndex = 16;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.Color.Chocolate;
            this.btnEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCat.Location = new System.Drawing.Point(87, 262);
            this.btnEliminarCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarCat.TabIndex = 15;
            this.btnEliminarCat.Text = "ELIMINAR";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            // 
            // lblListaCategorias
            // 
            this.lblListaCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCategorias.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblListaCategorias.Location = new System.Drawing.Point(39, 26);
            this.lblListaCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaCategorias.Name = "lblListaCategorias";
            this.lblListaCategorias.Size = new System.Drawing.Size(209, 39);
            this.lblListaCategorias.TabIndex = 14;
            this.lblListaCategorias.Text = "LISTA DE CATEGORIAS";
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(640, 304);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.lblListaCategorias);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.btnSalirCat);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.txtNombreCat);
            this.Controls.Add(this.btnAgregarCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Categorias :::";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.Button btnSalirCat;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Label lblListaCategorias;
    }
}