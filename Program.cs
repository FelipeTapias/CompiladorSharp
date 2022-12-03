using Compilador.Clases;


class CompiladorC
{
    public static void Main()
    {
        string pathFile = "C:\\Compilador\\configuration.txt";
        string expression;
        try
        {
            FileContent file = new(pathFile);
            expression = file.OrderFile();

            ValidationsExpression validationsExpression = new(expression);
            validationsExpression.CharacterValidation();
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}