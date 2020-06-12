using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class ExceptionNullValue: Exception
    {
        public ExceptionNullValue() { }
        public ExceptionNullValue(string text): base(text) { }
    }
}
