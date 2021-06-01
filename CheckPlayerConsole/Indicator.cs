using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPlayerConsole
{
    abstract class Indicator<T> 
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
