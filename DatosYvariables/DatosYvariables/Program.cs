using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaración de variables de diferentes tipos de datos
        int edad;
        double salario;
        char inicialNombre;
        string nombreCompleto;
        bool esEmpleado;

        // Solicitar la edad al usuario (tipo int)
        Console.Write("Introduce tu edad: ");
        edad = Convert.ToInt32(Console.ReadLine());  // Conversión de string a int

        // Solicitar el salario al usuario (tipo double)
        Console.Write("Introduce tu salario (con decimales): ");
        salario = Convert.ToDouble(Console.ReadLine());  // Conversión de string a double

        // Solicitar la inicial del nombre (tipo char)
        Console.Write("Introduce la inicial de tu nombre: ");
        inicialNombre = Convert.ToChar(Console.ReadLine());  // Conversión de string a char

        // Solicitar el nombre completo (tipo string)
        Console.Write("Introduce tu nombre completo: ");
        nombreCompleto = Console.ReadLine();

        // Solicitar si es empleado (tipo bool)
        Console.Write("¿Eres empleado? (escribe true o false): ");
        esEmpleado = Convert.ToBoolean(Console.ReadLine());  // Conversión de string a bool

        // Mostrar los valores ingresados
        Console.WriteLine("\nInformación del usuario:");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Salario: {salario}");
        Console.WriteLine($"Inicial del nombre: {inicialNombre}");
        Console.WriteLine($"Nombre completo: {nombreCompleto}");
        Console.WriteLine($"¿Es empleado?: {esEmpleado}");

        // Realizar una conversión de tipo explícita (casting)
        int salarioEntero = (int)salario;  // Convertir el salario double a un int
        Console.WriteLine($"\nTu salario redondeado (sin decimales) es: {salarioEntero}");

        // Mantener la consola abierta hasta que el usuario presione una tecla
        Console.ReadLine();
    }
}