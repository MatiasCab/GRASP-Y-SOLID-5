using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipe recipe) //FilePrinter ya no depednde de la clase recipe, sino que depednde del tipo IRecipe, esto le da menos limitaciones al programa y sigue el principio DIC
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}