namespace Act._2___U._4
{
    internal class Program
    {
         class Animal
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        
            public Animal(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            public void Comer()
            {
                Console.WriteLine("El animal está comiendo.");
            }
        }
    
        class Perro : Animal
        {
            public string Raza { get; set; }

            public Perro(string nombre, int edad, string raza) : base(nombre, edad)
            {
                Raza = raza;
            }

            public void Ladrar()
            {
                Console.WriteLine("El perro está ladrando.");
            }
        }
        
        class Programa
        {
            static void Main(string[] args)
            {
                Perro miPerro = new Perro("Maverick", 6, "Labrador");

                Console.WriteLine("Nombre del perro: " + miPerro.Nombre);
                Console.WriteLine("Edad del perro: " + miPerro.Edad);
                Console.WriteLine("Raza del perro: " + miPerro.Raza);

                miPerro.Comer();
                miPerro.Ladrar();
            }
        }

    }
}
