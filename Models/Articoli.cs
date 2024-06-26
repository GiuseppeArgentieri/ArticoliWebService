using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArticoliWebService.Models
{
    public class Articoli
    {
        [Key]
        [MinLength(5, ErrorMessage = "Il numero minimo di caratteri è 5")]
        [MaxLength(30, ErrorMessage = "Il numero massimo di caratteri è 5")]
        public string? CodArt { get; set; }

        [MinLength(5, ErrorMessage = "Il numero minimo di caratteri è 5")]
        [MaxLength(80, ErrorMessage = "Il numero massimo di caratteri è 80")]
        public string? Descrizione { get; set; }
        public string? Um { get; set; }
        public string? CodStat { get; set; }

        [Range(0,100, ErrorMessage ="I pezzi per cartone devono essere compresi tra 0 e 100")]
        public Int16? PzCart { get; set; }

        [Range(0.01,100, ErrorMessage ="Il peso deve essere compreso tra 0.01 e 100")]
        public double? PesoNetto { get; set; }
        public int? IdIva { get; set; }
        public int? IdFamAss { get; set; }
        public string? IdStatoArt { get; set; }
        public DateTime? DataCreazione { get; set; }

        //proprietà di collegamento classi models
        //relazione 1 a molti articoli(1) - barcode (*)
        public virtual ICollection<Ean>? Barcode {get; set;}
        public virtual Ingredienti? ingredienti {get; set;}
        public virtual Iva? iva {get; set;}
        public virtual FamAssort? famAssort {get; set;}
    }
}