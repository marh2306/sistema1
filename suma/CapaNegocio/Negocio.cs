using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class Negocio
    {
        datos dts = new datos();

        public double N_suma(Entidad obj)
        {
            return dts.D_suma(obj);
        }
    }
}
