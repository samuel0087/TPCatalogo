namespace CatalogoWinformApp
{
    partial class Catalogo
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
            this.lblTitlo = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dboCampo = new System.Windows.Forms.ComboBox();
            this.dboCriterio = new System.Windows.Forms.ComboBox();
            this.chbAvanzado = new System.Windows.Forms.CheckBox();
            this.btnEliminarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlo
            // 
            this.lblTitlo.AutoSize = true;
            this.lblTitlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlo.Location = new System.Drawing.Point(519, 10);
            this.lblTitlo.Name = "lblTitlo";
            this.lblTitlo.Size = new System.Drawing.Size(157, 29);
            this.lblTitlo.TabIndex = 0;
            this.lblTitlo.Text = "CatalogoAPP";
            this.lblTitlo.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(226, 60);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(450, 222);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(732, 60);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(256, 222);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(226, 299);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(344, 299);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(458, 299);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(578, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(10, 142);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 4;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(11, 196);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(10, 63);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(43, 13);
            this.lblBusqueda.TabIndex = 4;
            this.lblBusqueda.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(73, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(120, 261);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 21);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dboCampo
            // 
            this.dboCampo.FormattingEnabled = true;
            this.dboCampo.Location = new System.Drawing.Point(73, 139);
            this.dboCampo.Name = "dboCampo";
            this.dboCampo.Size = new System.Drawing.Size(121, 21);
            this.dboCampo.TabIndex = 6;
            this.dboCampo.SelectedIndexChanged += new System.EventHandler(this.dboCampo_SelectedIndexChanged);
            // 
            // dboCriterio
            // 
            this.dboCriterio.FormattingEnabled = true;
            this.dboCriterio.Location = new System.Drawing.Point(73, 193);
            this.dboCriterio.Name = "dboCriterio";
            this.dboCriterio.Size = new System.Drawing.Size(121, 21);
            this.dboCriterio.TabIndex = 6;
            // 
            // chbAvanzado
            // 
            this.chbAvanzado.AutoSize = true;
            this.chbAvanzado.Location = new System.Drawing.Point(73, 97);
            this.chbAvanzado.Name = "chbAvanzado";
            this.chbAvanzado.Size = new System.Drawing.Size(124, 17);
            this.chbAvanzado.TabIndex = 7;
            this.chbAvanzado.Text = "Busqueda avanzada";
            this.chbAvanzado.UseVisualStyleBackColor = true;
            this.chbAvanzado.CheckedChanged += new System.EventHandler(this.chbAvanzado_CheckedChanged);
            // 
            // btnEliminarFiltros
            // 
            this.btnEliminarFiltros.Location = new System.Drawing.Point(14, 261);
            this.btnEliminarFiltros.Name = "btnEliminarFiltros";
            this.btnEliminarFiltros.Size = new System.Drawing.Size(77, 21);
            this.btnEliminarFiltros.TabIndex = 1;
            this.btnEliminarFiltros.Text = "Eliminar filtro";
            this.btnEliminarFiltros.UseVisualStyleBackColor = true;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 381);
            this.Controls.Add(this.chbAvanzado);
            this.Controls.Add(this.dboCriterio);
            this.Controls.Add(this.dboCampo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminarFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblTitlo);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox dboCampo;
        private System.Windows.Forms.ComboBox dboCriterio;
        private System.Windows.Forms.CheckBox chbAvanzado;
        private System.Windows.Forms.Button btnEliminarFiltros;
    }
}