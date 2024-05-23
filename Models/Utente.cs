using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models;

public class Utente
{
     public int Id { get; set; }
     public string? Nome { get; set; }
     public string? Cognome { get; set; }

     [DataType(DataType.Date)]
     public DateTime DataNascita { get; set; }
     public string? Email { get; set; }
     public string? User { get; set; }
     public string? Password { get; set; }
}