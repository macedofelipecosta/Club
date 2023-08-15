using LogicaNegocio.Excepciones;
using LogicaNegocio.ValueObject;
using LogicaNegocio.ValueObject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Socio
    {
        public int Id { get; set; }
        public Cedula Cedula { get; set; }
        public Nombre Nombre { get; set; }
        public Nombre Apellido { get; set; }
        public Fecha Nacimiento { get; set; }
        public Edad Edad { get; private set; }
        public int MutualistaId { get; set; }
        public Domicilio Domicilio { get; set; }
        public Contacto Contacto { get; set; }
        public Fecha Registro { get; set; }
        public Observaciones Observaciones { get; set; }

        public Socio()
        {
            AgeAssign(Nacimiento.Data);
        }


        private void AgeAssign(DateTime nacimiento)
        {
            try
            {
                int age = nacimiento.Year - DateTime.Now.Year;
                if (age > 110)
                {
                    throw new SocioAgeException("La edad no es válida, debe ser menor a 110 años!");
                }
                if (age < 1)
                {
                    throw new SocioAgeException("La edad no es válida, debe ser mayor a 1 año!");
                }
                Edad = new Edad(age);
            }
            catch (AgeVOExeption e) { throw new SocioAgeException(e.Message); }
            catch (SocioAgeException e) { throw new SocioAgeException(e.Message); }
            catch (Exception) { throw new SocioAgeException("Ha ocurrido un error inesperado!"); }
        }


    }

}
