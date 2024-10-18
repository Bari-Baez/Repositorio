using Biblioteca;
using System;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace TuNombreDeEspacio
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Abrir el formulario de usuarios primero
            FormUsuarios formUsuarios = new FormUsuarios();
            // Si quieres asegurarte de que solo se cierre el formulario de usuarios antes de abrir el siguiente, usa ShowDialog
            formUsuarios.ShowDialog();

            // Una vez que se cierra el formulario de usuarios, abre el formulario de la biblioteca
            FormBiblioteca formBiblioteca = new FormBiblioteca();
            Application.Run(formBiblioteca);
        }
    }
}