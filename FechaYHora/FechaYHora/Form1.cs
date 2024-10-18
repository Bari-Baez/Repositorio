using System;
using System.Windows.Forms;

namespace FechaYHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configura el Timer
            Timer timer = new Timer();
            timer.Interval = 1000; // Actualiza cada segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualiza la hora y la fecha
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
