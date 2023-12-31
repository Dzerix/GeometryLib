﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Interfaces
{
    internal interface ITriangle : IFigure
    {
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }

        bool GetIsRightTriangle();
    }
}
