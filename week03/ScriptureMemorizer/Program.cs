using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string texto = "Confía en Jehová con todo tu corazón, y no te apoyes en tu propia prudencia.";

        Reference ref1 = new Reference("Proverbios", 3, 5); // Se puede cambiar a 5-6 para probar múltiples versos
        Scripture scripture = new Scripture(ref1, texto);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPresiona Enter para ocultar palabras o escribe 'quit' para salir.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Oculta 3 palabras por ciclo
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\n¡Todas las palabras han sido ocultadas!");
    }
}