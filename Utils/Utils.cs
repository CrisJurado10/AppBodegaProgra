using appBodega.Models;


namespace appBodega.Utils
{
    public class Utils
    {
        static public List<Empresa> ListaEmpresas = new List<Empresa>()
        {
            new Empresa{
                EmpresaID=1,
                NombreEmpresa="Supermaxi",
                Resumen="Tienda de Viveres"},
            new Empresa{
                EmpresaID=2,
                NombreEmpresa = "TecniEC",
                Resumen="Electronica" },
            new Empresa{
                EmpresaID = 3,
                NombreEmpresa = "Tuti",
                Resumen="Tienda de Viveres" },
            new Empresa{
                EmpresaID=4,
                NombreEmpresa = "Newbie",
                Resumen="Servicios de reparación" }
        };
        static public List<Producto> ListaProductos = new List<Producto>() { 
            new Producto{
                ProductoId = 1,
                Nombre = "Procan",
                Descripcion = "Comida para perros",
                Precio = 54.99,
                CtdenStock=45,
                ProveedorId=1 },
            new Producto{
                ProductoId=2,
                Nombre="Manicris",
                Descripcion="Mani",
                Precio=4.90,
                CtdenStock=435,
                ProveedorId=1 },
            new Producto{
                ProductoId=3,
                Nombre = "Contact Cleaner",
                Descripcion = "Limpia Contactos",
                Precio = 10.20,
                CtdenStock = 5,
                ProveedorId = 2},
            new Producto{
                ProductoId=4,
                Nombre = "Pasta Térmica", 
                Descripcion = "Pasta para componentes", 
                Precio = 4.99, 
                CtdenStock = 20, 
                ProveedorId = 2 }

        };
    }
}
