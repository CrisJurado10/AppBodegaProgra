using appBodega.Models;
namespace appBodega.Services
{
    public interface IAPIService
    {
        public Task<List<Producto>> GetProductos();
        public Task<Producto> GetProducto(int ProveedorId);
        public Task<Producto> PostProducto(Producto producto);
        public Task<Producto> PutProducto(int ProductoId, Producto producto);
        public Task<Boolean> DeleteProducto(int ProductoId);

        public Task<List<Empresa>> GetEmpresas();
        public Task<Empresa> GetEmpresa(int EmpresaID);
        public Task<Empresa> PostEmpresa(Empresa empresas);
        public Task<Empresa> PutEmpresa(int EmpresaID, Empresa empresa);
        public Task<Boolean> DeleteEmpresa(int EmpresaID);

        public Task<List<User>> GetUsers();
        public Task<User> GetUser(int IdUser);
        //public Task<User> PostUsuarios(User userToValidate);
        public Task<User> PostUser(User newUser);

    }
}
