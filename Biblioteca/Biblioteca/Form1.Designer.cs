namespace SistemaGestionBiblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.LblNumeroCopias = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNumeroCopias = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.lblAñoPublicacion = new System.Windows.Forms.Label();
            this.txtAñoPublicacion = new System.Windows.Forms.TextBox();
            this.lbleditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(170, 189);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(56, 24);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            this.lblISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(170, 228);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(170, 269);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 24);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor";
            // 
            // LblNumeroCopias
            // 
            this.LblNumeroCopias.AutoSize = true;
            this.LblNumeroCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroCopias.Location = new System.Drawing.Point(170, 309);
            this.LblNumeroCopias.Name = "LblNumeroCopias";
            this.LblNumeroCopias.Size = new System.Drawing.Size(74, 24);
            this.LblNumeroCopias.TabIndex = 4;
            this.LblNumeroCopias.Text = "Copias";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(170, 351);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(80, 24);
            this.lblgenero.TabIndex = 5;
            this.lblgenero.Text = "Genero";
            this.lblgenero.Click += new System.EventHandler(this.lblgenero_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(265, 228);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(211, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(265, 194);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(211, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(265, 273);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(211, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // txtNumeroCopias
            // 
            this.txtNumeroCopias.Location = new System.Drawing.Point(265, 313);
            this.txtNumeroCopias.Name = "txtNumeroCopias";
            this.txtNumeroCopias.Size = new System.Drawing.Size(211, 20);
            this.txtNumeroCopias.TabIndex = 9;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(265, 356);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(211, 20);
            this.txtGenero.TabIndex = 10;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.AutoSize = true;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.Location = new System.Drawing.Point(576, 223);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(137, 62);
            this.btnAgregarLibro.TabIndex = 11;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAñoPublicacion
            // 
            this.lblAñoPublicacion.AutoSize = true;
            this.lblAñoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoPublicacion.Location = new System.Drawing.Point(66, 394);
            this.lblAñoPublicacion.Name = "lblAñoPublicacion";
            this.lblAñoPublicacion.Size = new System.Drawing.Size(184, 24);
            this.lblAñoPublicacion.TabIndex = 12;
            this.lblAñoPublicacion.Text = "Fecha Publicación";
            // 
            // txtAñoPublicacion
            // 
            this.txtAñoPublicacion.Location = new System.Drawing.Point(265, 399);
            this.txtAñoPublicacion.Name = "txtAñoPublicacion";
            this.txtAñoPublicacion.Size = new System.Drawing.Size(211, 20);
            this.txtAñoPublicacion.TabIndex = 13;
            this.txtAñoPublicacion.TextChanged += new System.EventHandler(this.txtAnioPublicacion_TextChanged);
            // 
            // lbleditorial
            // 
            this.lbleditorial.AutoSize = true;
            this.lbleditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditorial.Location = new System.Drawing.Point(160, 435);
            this.lbleditorial.Name = "lbleditorial";
            this.lbleditorial.Size = new System.Drawing.Size(86, 24);
            this.lbleditorial.TabIndex = 14;
            this.lbleditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(265, 440);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(211, 20);
            this.txtEditorial.TabIndex = 15;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLibro.Location = new System.Drawing.Point(576, 336);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(143, 58);
            this.btnEliminarLibro.TabIndex = 16;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 535);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lbleditorial);
            this.Controls.Add(this.txtAñoPublicacion);
            this.Controls.Add(this.lblAñoPublicacion);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNumeroCopias);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.LblNumeroCopias);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label LblNumeroCopias;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNumeroCopias;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Label lblAñoPublicacion;
        private System.Windows.Forms.TextBox txtAñoPublicacion;
        private System.Windows.Forms.Label lbleditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Button btnEliminarLibro;
    }
}

