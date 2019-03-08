using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fidelitas.NoSql.PrimerEjemplo.Collections
{
    /*
     {
    "_id" : ObjectId("5c81c69d6820d5f11af2e783"),
    "nombre" : "Sebastian",
    "apellido" : "Bermudez Ramirez",
    "telefono" : 22782282,
    "cedula" : 116520010,
    "direccion" : "La Union, Cartago",
    "renta" : [ 
        {
            "fecha_incio" : ISODate("2019-01-01T21:21:20.201Z"),
            "fecha_propuesta" : ISODate("2019-01-01T21:21:20.201Z"),
            "fecha_entrega" : ISODate("2019-01-01T21:21:20.201Z")
        }
    ]
}
         */
    [MetadataType(typeof(PeliculasMetadata))]
    public class Peliculas
    {
        public ObjectId _id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public IList<Renta> renta { get; set; }
    }
    public class PeliculasMetadata
    {
        [DisplayName("Identificador")]
        public object _id { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public object Nombre { get; set; }

        [Required]
        [DisplayName("Apellido")]
        public object Apellido { get; set; }

        [Required]
        [Range(8, 20)]
        [DisplayName("Telefono de cliente")]
        public object Telefono { get; set; }

        [Required]
        [Range(9, 20)]
        [DisplayName("Cedula del cliente")]
        public object Cedula { get; set; }

        
        [DisplayName("Direccion del cliente")]
        public object Direccion { get; set; }

        public IList<Renta> renta { get; set; }
    }

    public class Renta
    {
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Propuesta { get; set; }
        public DateTime Fecha_Entrega { get; set; }
    }
}
