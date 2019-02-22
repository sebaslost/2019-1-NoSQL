using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fidelitas.NoSQL.PrimerEjemplo.Connections
{
    /*
        {
            "_id" : 1,
            "nombre" : "Firulays",
            "fecha" : ISODate("2019-01-01T21:21:20.201Z"),
            "tipo" : "Perro",
            "dueno" : "Pepito",
            "tratamiento" : [
                {
                    "tipo" : "Operación",
                    "fecha" : ISODate("2019-02-01T22:21:20.201Z"),
                    "precio" : 500
                }
            ]
        }


    */



    public class Animales
    {
        ObjectId _id;
        string Nombre;
        DateTime fecha;
        string tipo;
        string Dueno;
        IList<Tratamiento> tratamiento;
    }

    public class Tratamiento
    {
        string Tipo;
        DateTime Fecha;
        decimal precio;
    }
}