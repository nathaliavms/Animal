using System;

namespace Animal
{
    class AnimaisInvertebrado
    {
        public string Animal { get; set; }
        public AnimaisInvertebrado(string animal)
        {
            Animal = animal;
        }
        public string ImprimirEscolha()
        {
            Console.WriteLine("Escolha entre Inseto ou Anelideo: ");
            var escolha = Console.ReadLine();

            if (escolha == "Inseto" || escolha == "inseto")
            {
                Console.WriteLine("Escolha entre Hematofago ou Herbivoro: ");
                var resultado = Console.ReadLine();

                if (resultado == "Hematofago" || resultado == "hematofago")
                    return "pulga";
                
                else if (resultado == "Herbivoro" || resultado == "herbivoro")
                    return "lagarta";
                
                else
                    return "Invalido"; 
            }
            else if (escolha == "Anelideo" || escolha == "anelideo")
            {
                Console.WriteLine("Escolha entre Hematofago ou Onivoro: ");
                var resultado = Console.ReadLine();

                if (resultado == "Hematofago" || resultado == "hematofago")
                    return "sanguessuga";
                
                else if (resultado == "Onivoro" || resultado == "onivoro")
                    return "minhoca";
                
                else
                    return "Invalido";
            }
            else
                return "Invalido";
            
        }
    }
}

    
