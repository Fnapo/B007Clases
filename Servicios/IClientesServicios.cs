using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B007Clases.Servicios
{
    public interface IClientesServicios
    {
        Task<bool> InsertarCliente(Models.Cliente cliente);
    }
}
