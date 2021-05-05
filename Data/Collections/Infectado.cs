using System;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.localizacao = GeoJsonGeographicCoordinates(longitude, latitude);

        }

        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; } 
        public GeoJsonGeographicCoordinates Localizacao { get; set; }       
    }
}