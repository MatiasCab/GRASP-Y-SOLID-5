using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipe recipe) //ConsolePrinter ya no depednde de la clase recipe, sino que depednde del tipo IRecipe, esto le da menos limitaciones al programa y sigue el principio DIC
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}