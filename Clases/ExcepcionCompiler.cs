using Compilador.Helpers;

namespace Compilador.Clases
{
    class ExcepcionCompiler: Exception
    {
        public ExcepcionCompiler(ExceptionMessage message): base(message.GetEnumDescription())
        {

        }
          
    }
}
