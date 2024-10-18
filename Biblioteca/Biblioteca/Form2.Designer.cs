namespace TuNombreDeEspacio
{
    partial class FormReservas
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
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dataGridReservas = new System.Windows.Forms.DataGridView();
            this.dtpFechaRetorno = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(28, 174);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarios.TabIndex = 0;
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(470, 174);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(121, 21);
            this.cmbLibros.TabIndex = 2;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(225, 207);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 3;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(242, 287);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(164, 63);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reserva";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // dataGridReservas
            // 
            this.dataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservas.Location = new System.Drawing.Point(28, 17);
            this.dataGridReservas.Name = "dataGridReservas";
            this.dataGridReservas.Size = new System.Drawing.Size(610, 138);
            this.dataGridReservas.TabIndex = 5;
            // 
            // dtpFechaRetorno
            // 
            this.dtpFechaRetorno.Location = new System.Drawing.Point(225, 414);
            this.dtpFechaRetorno.Name = "dtpFechaRetorno";
            this.dtpFechaRetorno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRetorno.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "dia de reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "devolución";
            // 
            // FormReservas
            // 
            this.ClientSize = new System.Drawing.Size(681, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaRetorno);
            this.Controls.Add(this.dataGridReservas);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.cmbLibros);
            this.Controls.Add(this.cmbUsuarios);
            this.Name = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dataGridReservas;
        private System.Windows.Forms.DateTimePicker dtpFechaRetorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}