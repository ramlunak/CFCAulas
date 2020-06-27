using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFCAulas.Models
{
    public class Regla
    {
        public int IdInfraccion { get; set; }
        public string Infraccion
        {
            get
            {
                return Data.DataSource.Infracciones.Where(x => x.Id == IdInfraccion).First().Nombre;
            }
        }
        public int IdPenalidad { get; set; }
        public string Penalidad
        {
            get
            {
                return Data.DataSource.Penalidades.Where(x => x.Id == IdPenalidad).First().Nombre;
            }
        }
        public int IdMedidaAdministrativa { get; set; }
        public string MedidaAdministrativa
        {
            get
            {
                return Data.DataSource.MedidaAdministrativas.Where(x => x.Id == IdMedidaAdministrativa).First().Nombre;
            }
        }
        public int IdMultiplicador { get; set; }
        public string Multiplicador
        {
            get
            {
                return Data.DataSource.Multiplicadores.Where(x => x.Id == IdMultiplicador).First().Nombre;
            }
        }
        public int IdObservacion { get; set; }
        public string Observacion
        {
            get
            {
                return Data.DataSource.Observacions.Where(x => x.Id == IdObservacion).First().Nombre;
            }
        }
    }
}
