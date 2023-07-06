using LogicaNegocio.ValueObject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject
{
    public class Email
    {
        private string _data;
        public string Data { get { return _data; } private set { _data = value; } }

        public Email(string data)
        {
            EmailValidation(data);
            Data = data;
        }
        static void EmailValidation(string data)
        {
            try
            {
                string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

                Regex regex = new Regex(patron);

                if (!regex.IsMatch(data)) { throw new EmailVOException("El email no es válido!"); }
            }
            catch (EmailVOException e) { throw new EmailVOException(e.Message); }
            catch (Exception){throw new EmailVOException("Ha ocurrido un error inesperado!");}

        }

    }
}
