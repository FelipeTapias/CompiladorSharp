using Compilador.Clases;


class CompiladorC
{
    public static void Main()
    {
        string pathFile = "C:\\configuration.txt";
        string expression;
        try
        {
            //Console.WriteLine("Welcome to expression compiler");
            //Console.WriteLine("Choose a option:");
            //Console.WriteLine("1 - Obtein expression from your file");
            //Console.WriteLine("2 - Create my own expression");
            FileContent file = new(pathFile);
            expression = file.OrderFile();

            ValidationsExpression validationsExpression = new(expression);
            validationsExpression.isEmptyExpression();
            validationsExpression.CharacterValidation();
            validationsExpression.OpenAndClose();
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}