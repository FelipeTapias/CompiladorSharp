using Compilador.Helpers;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Compilador.Clases
{
    public class ValidationsExpression
    {
        string expression;
        string regex = @"(^[0-9(),[\]{} ]*$)";
        public ValidationsExpression(string expression) 
        { 
            this.expression = expression;
        }

        public void isEmptyExpression() 
        {
            if (string.IsNullOrEmpty(expression))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                throw new ExcepcionCompiler(ExceptionMessage.EmptyExpression);
            }
        }

        public void CharacterValidation() 
        {
            Match match = Regex.Match(expression, regex);
            if (!match.Success)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                throw new ExcepcionCompiler(ExceptionMessage.InvalidCharacters);
            }
        }

        public void OpenAndClose()
        {
            if (expression[0] == '{' || expression[expression.Length - 1] == '}') {
                if (expression[0] != '{' || expression[expression.Length - 1] != '}')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (expression[0] == '{')
                    {
                        throw new ExcepcionCompiler(ExceptionMessage.ClosingBrace);
                    }
                    else
                    {
                        throw new ExcepcionCompiler(ExceptionMessage.OpeningBrace);
                    }
                } else if (expression.Length == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    throw new ExcepcionCompiler(ExceptionMessage.OnlyHasBrace);
                }
            }
        }
    }
}
