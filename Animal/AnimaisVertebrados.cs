using System;

namespace Animal
{
    class AnimaisVertebrados
    {
        public string Animal { get; set; }
        public AnimaisVertebrados(string animal)
        {
            Animal = animal;
        }
        public string ImprimirEscolha()
        {
            Console.WriteLine("Escolha entre Ave ou Mamifero: ");
            var escolha = Console.ReadLine();

            if (escolha == "Ave" || escolha == "ave")
            {
                Console.WriteLine("Escolha entre Carnivoro ou Onivoro: ");
                var resultado = Console.ReadLine();

                if (resultado == "Carnivoro" || resultado == "carnivoro")
                    return "aguia"; 
                
                else if (resultado == "Onivoro" || resultado == "onivoro")
                    return "pomba";
                
                else
                    return "Invalido"; 
            }
            else if (escolha == "Mamifero" || escolha == "mamifero")
            {
                Console.WriteLine("Escolha entre Onivoro ou Herbivoro: ");
                var resultado = Console.ReadLine();
                
                if (resultado == "Onivoro" || resultado == "onivoro")
                    return "homem";
                
                else if (resultado == "Herbivoro" || resultado == "herbivoro")
                    return "vaca";
                
                else
                    return "Invalido";
            }
            else
                return "Invalido";
        }
    }
}
