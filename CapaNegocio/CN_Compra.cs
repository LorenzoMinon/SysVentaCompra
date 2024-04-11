using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Compra
    {

        private CD_Compra objcd_Compra = new CD_Compra();


        public int ObtenerCorrelativo()
        {
            return objcd_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj,DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_Compra.Registrar(obj,DetalleCompra, out Mensaje);
        }



    }
}
