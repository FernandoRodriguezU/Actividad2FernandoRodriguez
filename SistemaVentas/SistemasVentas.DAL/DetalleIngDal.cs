using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable LIstarDetalleIngDal()
        {
            string consulta = "select * from DetalleIng";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }

        public DataTable DetalleingDatosDal()
        {
            string consulta = " SELECT PROVEEDOR.NOMBRE, PROVEEDOR.TELEFONO, PRODUCTO.NOMBRE AS DAl1, MARCA.NOMBRE AS DAL2, " +
                               " TIPOPROD.NOMBRE AS DAl3, INGRESO.TOTAL, DETALLEING.FECHAVENC, DETALLEING.CANTIDAD, " +
                               " DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL" +
                               " FROM DETALLEING INNER JOIN" +
                               " INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO INNER JOIN" +
                               " PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN" +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN" +
                               " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN" +
                               " PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }

    }
}
