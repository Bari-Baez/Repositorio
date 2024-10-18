using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(54);
            Circulo c2 = new Circulo(88);

            c1.CirculoCambio += ManejadorCirculoCambio;
            c2.CirculoCambio += ManejadorCirculoCambio;

            c1.Dibujar();
            c2.Dibujar();

            c1.Actualizar(57);
            c2.Actualizar(98);

            Console.ReadKey();
        }

        private static void ManejadorCirculoCambio(object sender, CirculoEventArgs AreaCambio)
        {
            Circulo s = (Circulo)sender;
            Console.WriteLine($"Nuevo evento. El área del círculo ahora es {AreaCambio.NuevaArea}");
            s.Dibujar();
        }
    }

    public class CirculoEventArgs : EventArgs
    {
        public double NuevaArea { get; private set; }

        public CirculoEventArgs(double nuevaArea)
        {
            NuevaArea = nuevaArea;
        }
    }

    public class Circulo
    {
        public event EventHandler<CirculoEventArgs> CirculoCambio;
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public void Dibujar()
        {
            Console.WriteLine($"Dibujando círculo con radio: {radio}");
        }

        public void Actualizar(double nuevoRadio)
        {
            radio = nuevoRadio;
            OnCirculoCambio();
        }

        protected virtual void OnCirculoCambio()
        {
            double nuevaArea = Math.PI * Math.Pow(radio, 2);
            CirculoCambio?.Invoke(this, new CirculoEventArgs(nuevaArea));
        }
    }
}