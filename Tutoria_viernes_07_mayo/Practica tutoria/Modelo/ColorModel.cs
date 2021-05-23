using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Practica_tutoria.Modelo
{
    class ColorModel
    {
        public string ColorName { get; }
        public Color Color { get; }
        public ColorModel(string name, Color color)
        {
            this.ColorName = name;
            this.Color = color;
        }


    }
}
