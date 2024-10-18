using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormLibros : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=localhost\\SQLEXPRESS02;Database=master;Trusted_Connection=True;";

        public FormUsuarios()
        {
            InitializeComponent();
            CargarUsuarios(); // Cargar los usuarios al iniciar el formulario
        }

        // Método para cargar los usuarios desde la base de datos al DataGridView
        private void CargarUsuarios()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridViewUsuarios.Rows.Clear(); // Limpiar el DataGridView antes de llenarlo

                while (reader.Read())
                {
                    dataGridViewUsuarios.Rows.Add(reader["IdUsuario"], reader["Nombre"], reader["Apellido"], reader["Email"], reader["Telefono"]);
                }
            }
        }

        // Método para agregar un nuevo usuario
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombr.Text;
            string apellido = txtApellid.Text;
            string email = txtEmai.Text;
            string telefono = txtTelefon.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Usuarios (Nombre, Apellido, Email, Telefono) VALUES (@Nombre, @Apellido, @Email, @Telefono)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefono", telefono);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado con éxito.");
                CargarUsuarios();  // Refrescar la lista de usuarios
                LimpiarCampos();   // Limpiar los campos del formulario
            }
        }

        // Método para editar un usuario existente
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtIdUsuario.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono WHERE IdUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefono", telefono);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado con éxito.");
                CargarUsuarios();  // Refrescar la lista de usuarios
                LimpiarCampos();   // Limpiar los campos del formulario
            }
        }

        // Método para eliminar un usuario
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtIdUsuario.Text);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado con éxito.");
                CargarUsuarios();  // Refrescar la lista de usuarios
                LimpiarCampos();   // Limpiar los campos del formulario
            }
        }

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }

        // Evento al seleccionar una fila en el DataGridView para mostrar los datos en los TextBox
        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewUsuarios.Rows[e.RowIndex];
                txtIdUsuario.Text = row.Cells["IdUsuario"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}