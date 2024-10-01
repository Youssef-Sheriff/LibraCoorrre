using System.ComponentModel.DataAnnotations;

namespace LibraCore.Models;

public class Penalty
{
    public int Id { get; set; }
    public int CheckoutId { get; set; }

    [Range(0, int.MaxValue)] // not allow negative numbers
    public int Amount { get; set; }

    public Checkout Checkout { get; set; }
}

