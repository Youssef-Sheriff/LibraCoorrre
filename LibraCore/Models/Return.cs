using System.ComponentModel.DataAnnotations;

namespace LibraCore.Models;

public class Return
{
    public int Id { get; set; }
    public int CheckoutId { get; set; }
    public DateTime ReturnDate { get; set; }

    [Range(0, int.MaxValue)]
    public int PenaltyAmount { get; set; }

    public Checkout Checkout { get; set; }
}

