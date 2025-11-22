using B007Clases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B007Clases.Repositorio
{
    public interface IClientesRepositorio
    {
        Task<bool> InsertarCliente(Cliente cliente);
    }
}
