using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosABM.Models
{
    internal class Producto
    {
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precio;
        private int _stock;
        private int _idUsuario;

        public Producto() { }

        public Producto(string descripcion, double costo, double precio, int stock, int idUsuario)
        {
            this._descripcion = descripcion;
            this._costo = costo;
            this._precio = precio;
            this._stock = stock;
            this._idUsuario = idUsuario;
        }

        public Producto(int id, string descripcion, double costo, double precio, int stock, int idUsuario): this(descripcion, costo, precio, stock, idUsuario)
        {
            this._id = id;
        }
        
        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

    }
}
