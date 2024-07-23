namespace Zoologico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nombre del estudiante: Stephanny Sophia Moralé González
            //Grupo: 213022
            //Número y texto del programa: Ingeniería de sistemas
            //Código Fuente: autoría propia.
            //Breve Explicación del uso de la/ las función(es) utilizada: En el código se hace un uso del ciclo for en dos ocaciónes, así mismo un arreglo para almacenar 
            //los datos de los animales de una forma más ordenada y estructurada. Esto nos permite al final del código poder mostrar los datos en conjunto almacenados en 
            //las variables declaradas y en uso

            //Definiremos nuestras variables
            int CantidadAnimales;
            string Especie;
            string PaísOrigen;

            Console.WriteLine("Bienvenido al directorio de animales del Zoológico :D");
            Console.WriteLine("Por favor ingrese la cantidad de animales a registrar");
            CantidadAnimales = int.Parse(Console.ReadLine());

            // Arreglos para almacenar los datos de los animales
            string[] especies = new string[CantidadAnimales];
            string[] paisesOrigen = new string[CantidadAnimales];

            //Aplicamos ciclos
            for (int i = 0; i < CantidadAnimales; i++)
            {
                Console.WriteLine("Ingrese los datos del animal");

                Console.WriteLine("Ingrese la especie del animal:");
                Especie = Console.ReadLine();
                especies[i] = Especie;

                Console.WriteLine("Ingrese el país de origen del animal");
                PaísOrigen = Console.ReadLine();
                paisesOrigen[i] = PaísOrigen;


            }

            // Mostrar los datos de los animales
            Console.WriteLine($"Datos de los animales registrados: + {CantidadAnimales}");
            // Mostrar los datos de los animales
            Console.WriteLine("\nDatos de los animales registrados:");
            for (int i = 0; i < CantidadAnimales; i++)
            {
                Console.WriteLine($"Animal {i + 1}: Especie: {especies[i]}, País de Origen: {paisesOrigen[i]}");
            }
        }
    }
}
