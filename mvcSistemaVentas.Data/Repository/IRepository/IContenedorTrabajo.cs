using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcSistemaVentas.Data.Repository.IRepository
{
    public interface IContenedorTrabajo
    {
       
        ISliderRepository Slider { get; }
        ICategoriaRepository Categoria { get; }
        IProductoRepository Producto { get; }
        IProveedorRepository Proveedor { get; }
        void Save();
    }
}
