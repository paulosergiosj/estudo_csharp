﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos_ClasseAbstrata.Entities.Enums;

namespace Estudos_ClasseAbstrata.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius,Color color) :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
