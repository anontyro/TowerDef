using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefOOP.exceptions
{
    class OutOfBoundsException : Exception
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
