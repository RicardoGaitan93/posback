using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.Business.Models
{
    public class Product
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int TipoProducto { get; set; }
        public bool Estado { get; set; }
        public int CategoriaProducto { get; set; }
        public int CodigoBarras { get; set; }
        public int IdImpuesto { get; set; }
        public int CantidadEnBodega { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadMaxima { get; set; }
        public int UnidadMedida { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
