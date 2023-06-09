using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._06._23
{
    internal class WrongTotalCountException:Exception
    {
        public WrongTotalCountException(string message) : base(message) { }
    }
}
