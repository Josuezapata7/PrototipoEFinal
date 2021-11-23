using Conexion;
using Modelo.DTO;
using System;
using System.Data.Odbc;
using Dapper;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using BitacoraRegistrarLogin.ViewModel;

namespace BitacoraUsuario
{
    public class Bitacora
    {
        private ConexionODBC ODBC = new ConexionODBC(); 

        /// MELANIE REVOLORIO
       /// <summary>
       /// Metodo que almacena en la base de datos el registro para la bitácora
       /// </summary>
       /// <param name="IdUsuario"></param>
       /// <param name="IdModulo"></param>
       /// <param name="IdAplicacion"></param>
       /// <param name="accion"></param>
        public void guardarEnBitacora(string IdUsuario, string IdModulo, string IdAplicacion, string accion) 
        {

        }

        /// JORGE GONZÁLEZ
        /// <summary>
        /// Método que obtiene el ID del Usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>

        /// MELANIE REVOLORIO
        /// <summary>
        /// Obtiene todos los datos de la Bitácora 
        /// </summary>
        /// <returns></returns>
    }
}