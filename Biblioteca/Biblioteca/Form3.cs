using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TuNombreDeEspacio // Cambia esto por el espacio de nombres de tu proyecto
{
    public partial class FormConsultas : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS02;Database=master;Trusted_Connection=True;"; // Reemplaza esto con tu cadena de conexión a la base de datos

        public FormConsultas()
        {
            InitializeComponent();
            CargarGeneros();
        }

        // Cargar géneros en el ComboBox
        private void CargarGeneros()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Genero FROM Libros", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbGenero.Items.Add(reader["Genero"].ToString());
                }
            }
        }

        // Consultar libros disponibles por género
        private void btnConsultarLibros_Click(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un género.");
                return;
            }

            string generoSeleccionado = cmbGenero.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Libros WHERE Genero = @Genero AND NumeroCopias > 0", conn);
                da.SelectCommand.Parameters.AddWithValue("@Genero", generoSeleccionado);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridLibros.DataSource = dt;
            }
        }

        // Reporte de libros más reservados
        private void btnLibrosMasReservados_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT l.Titulo, COUNT(r.IdReserva) AS TotalReservas 
                    FROM Reservas r 
                    JOIN Libros l ON r.ISBN = l.ISBN 
                    GROUP BY l.Titulo 
                    ORDER BY TotalReservas DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridLibros.DataSource = dt;
            }
        }

        // Reporte de usuarios más activos
        private void btnUsuariosMasActivos_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT u.Nombre, u.Apellido, COUNT(r.IdReserva) AS TotalReservas 
                    FROM Reservas r 
                    JOIN Usuarios u ON r.IdUsuario = u.IdUsuario 
                    GROUP BY u.Nombre, u.Apellido 
                    ORDER BY TotalReservas DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridLibros.DataSource = dt;
            }
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
