﻿namespace School.Src.Infrastructure.MySqlDb.Entities
{
    public class DbAlumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
