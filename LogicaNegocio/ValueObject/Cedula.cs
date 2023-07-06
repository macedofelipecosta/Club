using LogicaNegocio.ValueObject.Exceptions;

namespace LogicaNegocio.ValueObject
{
    public class Cedula
    {
        private string _data;
        public string Data { get { return _data; } set { _data = value; } }

        public Cedula(string data)
        {
            CIValidate(data);
            _data = data;
        }



        private void CIValidate(string inputString)
        {
            try
            {
                string regexPattern = @"^\d{1}\.\d{1,3}\.\d{1,3}-\d{1}$";
                bool isValid = System.Text.RegularExpressions.Regex.IsMatch(inputString, regexPattern);
                if (!isValid) { throw new CedulaVOException($"La cédula {inputString} no es válida!"); }
            }
            catch (CedulaVOException e){throw new CedulaVOException(e.Message); ;}
            catch (Exception) { throw new CedulaVOException("Ha ocurrido un error inesperado!"); }

        }



    }
}
