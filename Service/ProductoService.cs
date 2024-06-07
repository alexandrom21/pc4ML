using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pc4ML.Models;

namespace pc4ML.Service
{
    public class ProductoService
    {
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 3, ProductoNombre = "Smartphone Samsung Galaxy S21" },
                new Producto { ProductoId = 5, ProductoNombre = "Laptop Dell XPS 13" },
                new Producto { ProductoId = 9, ProductoNombre = "Tablet Apple iPad Pro" }
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 1, ProductoNombre = "Smartphone Apple iPhone 12" },
                new Producto { ProductoId = 2, ProductoNombre = "Laptop MacBook Air" },
                new Producto { ProductoId = 3, ProductoNombre = "Smartphone Samsung Galaxy S21" },
                new Producto { ProductoId = 4, ProductoNombre = "Smartwatch Apple Watch Series 6" },
                new Producto { ProductoId = 5, ProductoNombre = "Laptop Dell XPS 13" },
                new Producto { ProductoId = 6, ProductoNombre = "Smart TV Samsung QLED" },
                new Producto { ProductoId = 7, ProductoNombre = "Headphones Bose QuietComfort 35" },
                new Producto { ProductoId = 8, ProductoNombre = "Camera Canon EOS R5" },
                new Producto { ProductoId = 9, ProductoNombre = "Tablet Apple iPad Pro" },
                new Producto { ProductoId = 10, ProductoNombre = "Gaming Console Sony PlayStation 5" }
            };

            return result;
        }
    }
}