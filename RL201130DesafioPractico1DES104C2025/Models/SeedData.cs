using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RL201130DesafioPractico1DES104C2025.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BodegaDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<BodegaDBContext>>()))
            {
                if (context.Categorias.Any() || context.Proveedores.Any() || context.Productos.Any())
                {
                    return; 
                }
                context.Categorias.AddRange(
                    new Categoria { Nombre = "Electronicos" },
                    new Categoria { Nombre = "Ropa" },
                    new Categoria { Nombre = "Alimentos" },
                    new Categoria { Nombre = "Muebles" },
                    new Categoria { Nombre = "Juguetes" },
                    new Categoria { Nombre = "Libros" },
                    new Categoria { Nombre = "Deportes" },
                    new Categoria { Nombre = "Hogar" },
                    new Categoria { Nombre = "Belleza" },
                    new Categoria { Nombre = "Herramientas" }
                );
                context.SaveChanges();
                context.Proveedores.AddRange(
                    new Proveedor { Empresa = "TechCorp", Contacto = "Juan Pérez", Direccion = "Calle 123", Telefono = "12345678", Email = "juan@techcorp.com" },
                    new Proveedor { Empresa = "ModaStyle", Contacto = "María López", Direccion = "Avenida 456", Telefono = "87654321", Email = "maria@modastyle.com" },
                    new Proveedor { Empresa = "FoodDist", Contacto = "Carlos Ramírez", Direccion = "Boulevard 789", Telefono = "56781234", Email = "carlos@fooddist.com" },
                    new Proveedor { Empresa = "MueblesFinos", Contacto = "Ana Martínez", Direccion = "Callejón 321", Telefono = "43218765", Email = "ana@mueblesfinos.com" },
                    new Proveedor { Empresa = "ToyLand", Contacto = "Luis García", Direccion = "Pasaje 654", Telefono = "98765432", Email = "luis@toyland.com" },
                    new Proveedor { Empresa = "BookWorld", Contacto = "Sofía Herrera", Direccion = "Avenida 987", Telefono = "34567812", Email = "sofia@bookworld.com" },
                    new Proveedor { Empresa = "SportLife", Contacto = "Pedro Castro", Direccion = "Calle 567", Telefono = "65432187", Email = "pedro@sportlife.com" },
                    new Proveedor { Empresa = "HomeDecor", Contacto = "Laura Morales", Direccion = "Boulevard 234", Telefono = "78912345", Email = "laura@homedecor.com" },
                    new Proveedor { Empresa = "BeautyCare", Contacto = "Roberto Jiménez", Direccion = "Pasaje 876", Telefono = "12378945", Email = "roberto@beautycare.com" },
                    new Proveedor { Empresa = "ToolMaster", Contacto = "Elena Ruiz", Direccion = "Callejón 543", Telefono = "45612378", Email = "elena@toolmaster.com" }
                );
                context.SaveChanges();

 
                context.Productos.AddRange(
                    new Producto { Nombre = "Laptop", Descripcion = "Laptop de última generación", CategoriaID = 1, ProveedorID = 1, Precio = 1500.99m, Existencia = 10 },
                    new Producto { Nombre = "Camiseta", Descripcion = "Camiseta de algodón", CategoriaID = 2, ProveedorID = 2, Precio = 19.99m, Existencia = 50 },
                    new Producto { Nombre = "Arroz", Descripcion = "Arroz premium 1kg", CategoriaID = 3, ProveedorID = 3, Precio = 2.50m, Existencia = 100 },
                    new Producto { Nombre = "Silla", Descripcion = "Silla ergonómica", CategoriaID = 4, ProveedorID = 4, Precio = 89.99m, Existencia = 15 },
                    new Producto { Nombre = "Muñeca", Descripcion = "Muñeca de colección", CategoriaID = 5, ProveedorID = 5, Precio = 29.99m, Existencia = 30 },
                    new Producto { Nombre = "Novela", Descripcion = "Novela bestseller", CategoriaID = 6, ProveedorID = 6, Precio = 12.99m, Existencia = 40 },
                    new Producto { Nombre = "Balón", Descripcion = "Balón de fútbol", CategoriaID = 7, ProveedorID = 7, Precio = 24.99m, Existencia = 25 },
                    new Producto { Nombre = "Lámpara", Descripcion = "Lámpara LED", CategoriaID = 8, ProveedorID = 8, Precio = 34.99m, Existencia = 20 },
                    new Producto { Nombre = "Crema", Descripcion = "Crema facial", CategoriaID = 9, ProveedorID = 9, Precio = 14.99m, Existencia = 35 },
                    new Producto { Nombre = "Taladro", Descripcion = "Taladro inalámbrico", CategoriaID = 10, ProveedorID = 10, Precio = 79.99m, Existencia = 12 }
                );



                context.SaveChanges();
            }
        }
    }
}
