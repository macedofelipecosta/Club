﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject
{
    public class Domicilio
    {
        private string _data;

        public string Data { get { return _data; } set { _data = value; } }
    }
}
