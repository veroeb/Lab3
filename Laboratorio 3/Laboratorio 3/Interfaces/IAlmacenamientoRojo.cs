﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Interfaces
{
    interface IAlmacenamientoRojo
    {
        int GuardarElixirRojo(int g);
        int CapacidadActualElixirRojo { get; set; }
        int CapacidadAlmacenamientoElixirRojo { get; set; }
    }
}
