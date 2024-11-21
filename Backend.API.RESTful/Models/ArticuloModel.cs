﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.API.RESTful.Models
{
    [Table("Articulos")]
    public class ArticuloModel
    {
        [Key]
        public int Id_Articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public string Descripcion_Articulo { get; set; }
        public bool Activo {  get; set; }
    }
}
