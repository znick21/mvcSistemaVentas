using mvcSistemaVentas.Data.Repository.IRepository;
using mvcSistemaVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mvcSistemaVentas.Data.Repository
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Producto producto)
        {
            var objDesdeDb = _db.Producto.FirstOrDefault(p => p.Id == producto.Id);
            if (objDesdeDb != null)
            {
                objDesdeDb.Codigo = producto.Codigo;
                objDesdeDb.Nombre = producto.Nombre;
                objDesdeDb.Descripcion = producto.Descripcion;
                objDesdeDb.Stock = producto.Stock;
                objDesdeDb.PrecioCompra = producto.PrecioCompra;
                objDesdeDb.PrecioVenta = producto.PrecioVenta;
                objDesdeDb.Estado = producto.Estado;
                objDesdeDb.FechaRegistro = producto.FechaRegistro;
                objDesdeDb.FechaCaducidad = producto.FechaCaducidad;
            }
        }
    }
}