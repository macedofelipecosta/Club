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
                AgeValidation(value);
                _data = value;
            }
        }

        public Edad(int data)
        {
            Data = data;
        }

        private void AgeValidation(int age)
        {
            try
            {
                if (age > 110)
                {
                    throw new AgeVOExeption("La edad no es válida, debe ser menor a 110 años!");
                }
                if (age < 1)
                {
                    throw new AgeVOExeption("La edad no es válida, debe ser mayor a 1 año!");
                }
            }
            catch (AgeVOExeption e)
            {
                throw new AgeVOExeption(e.Message);
            }
        }


        

    }
}
