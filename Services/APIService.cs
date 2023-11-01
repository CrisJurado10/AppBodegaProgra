using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using appBodega.Models;
using System.Net;



namespace appBodega.Services
{
    public class APIService : IAPIService
    {
        public static string _baseUrl;
        public HttpClient _httpClient;

        public APIService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            _baseUrl = builder.GetSection("ApiSettings:BaseUrl").Value;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }
        public async Task<bool> DeleteProducto(int ProductoId)
        {
            var response = await _httpClient.DeleteAsync($"/api/Producto/{ProductoId}");
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        public async Task<Producto> GetProducto(int ProveedorId)
        {
            var response = await _httpClient.GetAsync($"/api/Producto/{ProveedorId}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto;
            }
            return new Producto();
        }
        public async Task<List<Producto>> GetProductos()
        {
            var response = await _httpClient.GetAsync("/api/Producto");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(json_response);
                return productos;
            }
            return new List<Producto>();

        }

        public async Task<Producto> PostProducto(Producto producto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/Producto/", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto2 = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto2;
            }
            return new Producto();
        }

        public async Task<Producto> PutProducto(int ProductoId, Producto producto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/Producto/{ProductoId}", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto2 = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto2;
            }
            return new Producto();
        }

        public async Task<bool> DeleteEmpresa(int EmpresaID)
        {
            var response = await _httpClient.DeleteAsync($"/api/Empresa/{EmpresaID}");
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        public async Task<Empresa> GetEmpresa(int EmpresaID)
        {
            var response = await _httpClient.GetAsync($"/api/Empresa/{EmpresaID}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Empresa empresa = JsonConvert.DeserializeObject<Empresa>(json_response);
                return empresa;
            }
            return new Empresa();
        }

        public async Task<List<Empresa>> GetEmpresas()
        {
            var response = await _httpClient.GetAsync("/api/Empresa");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Empresa> empresas = JsonConvert.DeserializeObject<List<Empresa>>(json_response);
                return empresas;
            }
            return new List<Empresa>();

        }
         public async Task<Empresa> PostEmpresa(Empresa empresas)
         {
             var content = new StringContent(JsonConvert.SerializeObject(empresas), Encoding.UTF8, "application/json");
             var response = await _httpClient.PostAsync("/api/Empresa/", content);
             if (response.IsSuccessStatusCode)
             {
                 var json_response = await response.Content.ReadAsStringAsync();
                 Empresa empresa2 = JsonConvert.DeserializeObject<Empresa>(json_response);
                 return empresa2;
             }
             return new Empresa();
         }

        public async Task<Empresa> PutEmpresa(int EmpresaID, Empresa empresa)
        {
            var content = new StringContent(JsonConvert.SerializeObject(empresa), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/Empresa/{EmpresaID}", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Empresa empresa2 = JsonConvert.DeserializeObject<Empresa>(json_response);
                return empresa2;
            }
            return new Empresa();
        }

        public async Task<List<User>> GetUsers()
        {
            var response = await _httpClient.GetAsync("/api/User");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<User> usuarios = JsonConvert.DeserializeObject<List<User>>(json_response);
                return usuarios;
            }
            return new List<User>();

        }

        public async Task<User> GetUser(int IdUser)
        {
            var response = await _httpClient.GetAsync($"/api/User/{IdUser}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                User usuario = JsonConvert.DeserializeObject<User>(json_response);
                return usuario;
            }
            return new User();
        }
        public async Task<User> PostUser(User newUser)
        {
            var content = new StringContent(JsonConvert.SerializeObject(newUser), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/User/create", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                User usuario2 = JsonConvert.DeserializeObject<User>(json_response);
                return usuario2;
            }
            return new User();
        }
    }
}
    
