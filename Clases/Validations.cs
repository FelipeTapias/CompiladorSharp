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
            if (this.expression.Length == 0)
            {
                throw new Exception("Warning: The expression is empty");
            }
        }

        public void CharacterValidation() 
        {
            Match match = Regex.Match(expression, regex);
            if (!match.Success)
            {
                throw new Exception("Error: The expression contents invalid characters");
            }
        }

        public void OpenAndClose()
        {
            if (this.expression[0] == '{' || this.expression[this.expression.Length - 1] == '}') {
                if (this.expression[0] != '{' || this.expression[this.expression.Length - 1] != '}')
                {
                    if (this.expression[0] == '{')
                    {
                        throw new Exception("Error: Missing universal closing brace '}'");
                    }
                    else
                    {
                        throw new Exception("Error: Missing universal opening brace '{'");
                    }
                }
            }
        }
    }
}
