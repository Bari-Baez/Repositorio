using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS02;Database=master;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Libros";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Libros (ISBN, Titulo, Autor, NumeroCopias, Genero, AñoPublicacion, Editorial) VALUES (@ISBN, @Titulo, @Autor, @NumeroCopias, @Genero, @AñoPublicacion, @Editorial)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@Autor", txtAutor.Text);
                    cmd.Parameters.AddWithValue("@NumeroCopias", txtNumeroCopias.Text);
                    cmd.Parameters.AddWithValue("@Genero", txtGenero.Text);
                    cmd.Parameters.AddWithValue("@AñoPublicacion", txtAñoPublicacion.Text);
                    cmd.Parameters.AddWithValue("@Editorial", txtEditorial.Text);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadBooks(); // Recargar la lista de libros para mostrar el nuevo registro
            ClearFields(); // Limpiar los campos de texto
        }

        private void ClearFields()
        {
            txtISBN.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtNumeroCopias.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            {
                // Mostrar valores capturados para asegurarse de que están bien
                MessageBox.Show($"ISBN: {txtISBN.Text}, Titulo: {txtTitulo.Text}, Autor: {txtAutor.Text}, Numero Copias: {txtNumeroCopias.Text}, @Genero: {txtGenero.Text}, @AñoPublicacion: {txtAñoPublicacion.Text}, @Editorial: {txtEditorial.Text}");

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Libros (ISBN, Titulo, Autor, NumeroCopias, Genero, AñoPublicacion, Editorial) VALUES (@ISBN, @Titulo, @Autor, @NumeroCopias,@Genero,@AñoPublicacion,@Editorial)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Asegurarte de que los parámetros se están agregando correctamente
                        cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                        cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                        cmd.Parameters.AddWithValue("@Autor", txtAutor.Text);
                        cmd.Parameters.AddWithValue("@NumeroCopias", txtNumeroCopias.Text);
                        cmd.Parameters.AddWithValue("@Genero", txtGenero.Text);
                        cmd.Parameters.AddWithValue("@AñoPublicacion", txtAñoPublicacion.Text);
                        cmd.Parameters.AddWithValue("@Editorial", txtEditorial.Text);

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery(); // Ejecutar la consulta
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Libro agregado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se ha agregado ningún libro.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
                LoadBooks(); // Recargar la lista de libros para mostrar el nuevo registro
                ClearFields(); // Limpiar los campos de texto
            }

        }

        private void txtAnioPublicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblgenero_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            {
                // Asegúrate de que txtISBN tenga un valor antes de intentar eliminar
                if (string.IsNullOrWhiteSpace(txtISBN.Text))
                {
                    MessageBox.Show("Por favor, ingresa un ISBN para eliminar el libro.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Libros WHERE ISBN = @ISBN";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery(); // Ejecutar la consulta
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Libro eliminado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún libro con el ISBN proporcionado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
                LoadBooks(); // Recargar la lista de libros para mostrar la actualización
            }



        }
    }
}
