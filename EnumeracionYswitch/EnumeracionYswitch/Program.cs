using System;

class Program
{
    // Enum para representar diferentes estados
    enum Estado
    {
        Estudiante,
        Empleado,
        Desempleado,
        Jubilado
    }

    static void Main(string[] args)
    {
        // Declaramos variables
        string nombre;
        int edad;
        Estado estadoPersona;

        // Solicitar el nombre y la edad de la persona
        Console.Write("Introduce tu nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Introduce tu edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        // Mostrar opciones de estado
        Console.WriteLine("\nSelecciona tu estado:");
        Console.WriteLine("0 - Estudiante");
        Console.WriteLine("1 - Empleado");
        Console.WriteLine("2 - Desempleado");
        Console.WriteLine("3 - Jubilado");

        // Leer y convertir la opción ingresada a un valor del enum
        int opcion = Convert.ToInt32(Console.ReadLine());
        estadoPersona = (Estado)opcion;

        // Usamos un bloque switch para determinar el mensaje según el estado
        switch (estadoPersona)
        {
            case Estado.Estudiante:
                Console.WriteLine($"\nHola {nombre}, tienes {edad} años y eres estudiante. ¡Sigue aprendiendo!");
                break;

            case Estado.Empleado:
                Console.WriteLine($"\nHola {nombre}, tienes {edad} años y estás empleado. ¡Éxito en tu trabajo!");
                break;

            case Estado.Desempleado:
                Console.WriteLine($"\nHola {nombre}, tienes {edad} años y estás desempleado. ¡Ánimo, encontrarás algo pronto!");
                break;

            case Estado.Jubilado:
                Console.WriteLine($"\nHola {nombre}, tienes {edad} años y estás jubilado. ¡Disfruta de tu tiempo libre!");
                break;

            default:
                Console.WriteLine("\nOpción inválida. Por favor selecciona un estado válido.");
                break;
        }

        // Mantener la consola abierta hasta que el usuario presione Enter
        Console.ReadLine();
    }
}
