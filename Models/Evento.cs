using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models;

public class Evento
{
     public int? Id { get; set; }
     public string? Nome { get; set; }
     public string? Descrizione { get; set; }
     public string? Img { get; set; }
     [DataType(DataType.Date)]
     public DateTime? DataEvento { get; set; }
     public double? Prezzo { get; set; }

}
