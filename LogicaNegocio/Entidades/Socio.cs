using LogicaNegocio.Excepciones;
using LogicaNegocio.ValueObject;
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
        public Edad Edad { get; }
        public Mutualista Mutualista { get; set; }
        public Domicilio Domicilio { get; set; }
        public Email Email { get; set; }
        public Contacto Contacto { get; set; }
        public Fecha Registro { get; set; }
        public Observaciones Observaciones { get; set; }

        public Socio()
        {
            ValidarEdad(this.Nacimiento.Data);
        }


        private void ValidarEdad(DateTime nacimiento)
        {
            try
            {
                int edad = nacimiento.Year - DateTime.Now.Year;
                if (edad > 110)
                {
                    throw new Exception("La edad no es válida, debe ser menor a 110 años!");
                }
                if (edad < 1)
                {
                    throw new Exception("La edad no es válida, debe ser mayor a 1 año!");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }

}
