using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace ServicioSegurosABC
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioSegurosABC : IServicioSegurosABC
    {
        string strConn;
        public ServicioSegurosABC()
        {
            strConn = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ToString();
        }

        public List<Clientes> ConsultarPagoClientes(string cedula)
        {
            try
            {
                string strQuery = "EXEC ConsultarPagoClientes '" + cedula + "'";

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(strQuery, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    List<Clientes> clientes = new List<Clientes>();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            Clientes cli = new Clientes()
                            {
                                cedula = read["cedula"].ToString(),
                                nombre = read["nombre"].ToString(),
                                fecha = read["fecha"].ToString(),
                                monto = float.Parse(read["monto"].ToString())
                            };
                            clientes.Add(cli);
                        }

                    }
                   

                    return clientes;
                }
            }
            catch
            {
                return null;
            }

        }
    }
}
