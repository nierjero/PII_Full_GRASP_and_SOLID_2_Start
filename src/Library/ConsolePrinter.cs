using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter // Se sigue el método SRP, separando la impresora del recibo ya que este no tiene porqué tener la información de como imprimir, se debe limitar a una sola responsabilidad.
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} minutos");
            }
            
        }
    }
}
