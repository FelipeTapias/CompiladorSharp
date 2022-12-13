using System.ComponentModel;
using System.Linq.Expressions;

namespace Compilador.Helpers
{
    public enum ExceptionMessage
    {
        [Description("[CPL-000] Excepction not controlled")]
        ExceptionNotControlled = 000,

        [Description("[CPL-001] File couldn't find, verify the path")]
        FileNotFound = 001,
        
        [Description("[CPL-002] Warning: The expression is empty")]
        EmptyExpression = 002, 
        
        [Description("[CPL-003] Error: The expression contents invalid characters")]
        InvalidCharacters = 003,
        
        [Description("[CPL-004] Error: Missing universal closing brace '}'")]
        ClosingBrace = 004,
        
        [Description("[CPL-005] Error: Missing universal opening brace '{'")]
        OpeningBrace = 005,
        
        [Description("[CPL-006] Warning: The expression is incorrect, it's only has '{}'")]
        OnlyHasBrace = 006,

    }
}



    
