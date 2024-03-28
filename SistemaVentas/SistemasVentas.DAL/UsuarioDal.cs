using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class UsuarioDal
    {
        public DataTable LIstarUsuarioDal()
        {
            string consulta = "SELECT        USUARIO.IDUSUARIO, PERSONA.NOMBRE, USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIO.FECHAREG\r\nFROM            USUARIO INNER JOIN\r\n                         PERSONA ON USUARIO.IDPERSONA = PERSONA.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "INSERT INTO USUARIO VALUES (" + usuario.IdPersona + " , " +
                                                            " '" + usuario.NombreUser + "' , " +
                                                            " '" + usuario.Contraseña + "' , " +
                                                            " '" + usuario.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }
    }
}
