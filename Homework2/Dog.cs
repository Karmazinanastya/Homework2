using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public struct Dog
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Mark: {Mark}, Age: {Age}";
        }
    }
}
