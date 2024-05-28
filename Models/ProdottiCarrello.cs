using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models;

public class ProdottiCarrello
{
    public int IdProdotto {get;set;}
    public string? NomeProdotto {get;set;}
    public int Quantità {get;set;}
    public decimal Prezzo {get;set;}
}