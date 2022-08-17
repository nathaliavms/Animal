using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha entre Vertebrado ou Invertebrado: ");
            var animal = Console.ReadLine();
            AnimaisVertebrados classe = new AnimaisVertebrados(animal);
            AnimaisInvertebrado classeInvertebrado = new AnimaisInvertebrado(animal);

            if (animal == "Vertebrado" || animal == "vertebrado")
                Console.WriteLine(classe.ImprimirEscolha());
            
            else if (animal == "Invertebrado" || animal == "invertebrado")
                Console.WriteLine(classeInvertebrado.ImprimirEscolha());
            
            else
                Console.WriteLine("Invalido");
        }
    }
}
