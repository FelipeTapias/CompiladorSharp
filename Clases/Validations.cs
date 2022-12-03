using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Compilador.Clases
{
    public class ValidationsExpression
    {
        string expression;
        string regex = @"([0-9(),[\]{} ])";
        public ValidationsExpression(string expression) { 
            this.expression = expression;
        }

        public void CharacterValidation() {
            Match match = Regex.Match(expression, regex);

            var a = match.Value;

            if (!match.Success)
            {
                throw new Exception("The expression contents invalid characters");
            }

            Console.WriteLine("Es correcta");
        }

        /// <summary>
        /// Determinar si tiene llave de apertura y de cierre
        /// </summary>
        public void OpenAndClose()
        {
            //if (this.expression[0] == "{ ") { 
            //}
            Console.WriteLine($"{this.expression[0]} y {this.expression[this.expression.Length-1]}");
        }
    }
}
