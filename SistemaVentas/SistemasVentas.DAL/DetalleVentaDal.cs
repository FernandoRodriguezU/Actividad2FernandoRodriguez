using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable LIstarDetalleVentaDal()
        {
            string consulta = "select * from DetalleVenta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public DataTable DetalleVentaDatosDal()
        {
            string consulta = " SELECT PRODUCTO.NOMBRE, TIPOPROD.NOMBRE AS Dal1, MARCA.NOMBRE AS Dal2, PROVEEDOR.NOMBRE AS DAl3, PROVEEDOR.TELEFONO, PROVEE.FECHA, PROVEE.PRECIO " +
                               "FROM PROVEE INNER JOIN " +
                               " PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN" +
                               " PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN" +
                               " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN " +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD";

            return conexion.EjecutarDataTabla(consulta, "hola");

        }
    }
}
