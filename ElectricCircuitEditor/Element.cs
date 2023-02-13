using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCircuitEditor
{
    public class Element
    {
        public string Img { get; private set; }
        public string Name { get; private set; }

        public Element(string img, string name)
        {
            Img = img;
            Name = name;
        }
    }
}
