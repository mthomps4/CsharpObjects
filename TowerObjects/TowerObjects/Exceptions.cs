using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense 
{
    class TowerDefenseExceptions : System.Exception
    {
        public TowerDefenseExceptions() { } //Default Constructor 
        public TowerDefenseExceptions(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : TowerDefenseExceptions
    {
        public OutOfBoundsException() { } //Default Constructor 
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
