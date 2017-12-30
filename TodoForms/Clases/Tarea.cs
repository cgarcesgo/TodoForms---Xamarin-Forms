using System;
using SQLite;

namespace TodoForms.Clases
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id
        {
            get;
            set;
        }

        [MaxLength(150)]
        public string Nombre
        {
            get;
            set;
        }

        public DateTime Fecha
        {
            get;
            set;
        }

        public TimeSpan Hora
        {
            get;
            set;
        }

        public bool Completada
        {
            get;
            set;
        }


    }
}
