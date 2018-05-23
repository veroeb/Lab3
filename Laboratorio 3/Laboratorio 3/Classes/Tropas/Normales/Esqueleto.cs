﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Esqueleto : TropaNormal
    {
        public Esqueleto()
        {
            Nombre = "Esqueleto";
            Nivel = 1;
            Vida = 40;
            Daño = 25;
            Velocidad = 24;
            Espacio = 2;
            ConsumoRojo = 1000;
        }
    }
}
