using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TuNombreDeEspacio
{
    public partial class FormReservas : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS02;Database=master;Trusted_Connection=True;"; // Asegúrate de reemplazar esto con tu cadena de conexión

        public FormReservas()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarLibros();
            CargarReservas();
        }

        // Cargar los usuarios en el ComboBox
        private void CargarUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdUsuario, Nombre FROM Usuarios", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbUsuarios.Items.Add(new
                    {
                        Text = reader["Nombre"].ToString(),
                        Value = reader["IdUsuario"]
                    });
                }

                cmbUsuarios.DisplayMember = "Text";
                cmbUsuarios.ValueMember = "Value";
            }
        }

        // Cargar los libros en el ComboBox
        private void CargarLibros()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ISBN, Titulo FROM Libros", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbLibros.Items.Add(new
                    {
                        Text = reader["Titulo"].ToString(),
                        Value = reader["ISBN"]
                    });
                }

                cmbLibros.DisplayMember = "Text";
                cmbLibros.ValueMember = "Value";
            }
        }

        // Cargar las reservas actuales en el DataGridView
        private void CargarReservas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT r.IdReserva, u.Nombre, l.Titulo, r.FechaReserva, r.FechaRetorno FROM Reservas r JOIN Usuarios u ON r.IdUsuario = u.IdUsuario JOIN Libros l ON r.ISBN = l.ISBN", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                btnReservar.DataSource = dt;
            }
        }

        // Evento para realizar la reserva
        private void btnReservar_Click(object sender, EventArgs e)
        {
            int idUsuario = (int)((dynamic)cmbUsuarios.SelectedItem).Value;
            string isbn = ((dynamic)cmbLibros.SelectedItem).Value.ToString();
            DateTime fechaReserva = dtpFechaReserva.Value;
            DateTime fechaRetorno = dtpFechaRetorno.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservas (IdUsuario, ISBN, FechaReserva, FechaRetorno) VALUES (@IdUsuario, @ISBN, @FechaReserva, @FechaRetorno)", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@FechaReserva", fechaReserva);
                cmd.Parameters.AddWithValue("@FechaRetorno", fechaRetorno);

                cmd.ExecuteNonQuery();
            }

            // Actualiza el DataGridView
            CargarReservas();
            MessageBox.Show("Reserva realizada con éxito.");
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {

        }
    }
}
