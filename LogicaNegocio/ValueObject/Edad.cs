using LogicaNegocio.Excepciones;
using LogicaNegocio.ValueObject.Exceptions;

namespace LogicaNegocio.ValueObject
{
    public class Edad
    {
        private int _data;

        public int Data
        {
            get { return _data; }
            set
            {
                BirthValidation();
                _data = value;
            }
        }

        private void BirthValidation()
        {
            try
            {
                DateTime today = DateTime.Now;
                int age = today.Year - _data;
                if (age <= 0 || age > 100) throw new AgeVOExeption("El socio debe ser mayor de 0 años y menor de 101 años!");
            }
            catch (AgeVOExeption e) { throw new AgeVOExeption(e.Message); }
            catch (Exception) { throw new AgeVOExeption("Ha ocurrido un error inesperado!"); };
        }

    }
}
