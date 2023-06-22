using LogicaNegocio.ValueObject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject
{
    public class Nombre
    {
        private string _data;

        public string Data { get { return _data; } set { _data = value; } }

        public Nombre(string data)
        {
            NameValidation(data);
            _data = data;
        }


        private void NameValidation(string data)
        {
            string regexPattern = @"^[^\d]*$";
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(data, regexPattern);
            if (!isValid) { throw new NameVOException($"El nombre {data} no es válido!"); }
        }

    }
}
