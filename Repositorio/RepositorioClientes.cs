using B007Clases.Data;
using B007Clases.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B007Clases.Repositorio
{
    public class RepositorioClientes : IClientesRepositorio
    {
        private readonly B007CrudContext _dbContexto;

        public RepositorioClientes(B007CrudContext crudContext)
        {
            _dbContexto = crudContext;
        }

        public async Task<bool> InsertarCliente(Cliente cliente)
        {
            bool clienteInsertado = false;

            try
            {
                await _dbContexto.Clientes.AddAsync(cliente);
                clienteInsertado = true;
                await _dbContexto.SaveChangesAsync();
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error al insertar el cliente en la base de datos.", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error inesperado al insertar el cliente.", ex);
            }

            return clienteInsertado;
        }
    }
}
