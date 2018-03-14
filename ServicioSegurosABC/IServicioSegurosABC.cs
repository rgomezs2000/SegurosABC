using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioSegurosABC
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSegurosABC
    {

        [OperationContract]
        List<Clientes> ConsultarPagoClientes(string cedula);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Clientes
    {

        [DataMember]
        public string cedula { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string fecha { get; set; }

        [DataMember]
        public float monto { get; set; }
    }
}
