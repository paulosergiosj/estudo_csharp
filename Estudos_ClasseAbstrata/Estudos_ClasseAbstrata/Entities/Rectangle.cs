﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos_ClasseAbstrata.Entities.Enums;

namespace Estudos_ClasseAbstrata.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height,Color color):base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width* Height;
        }
    }
}
