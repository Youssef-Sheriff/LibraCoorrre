namespace LibraCore.Models;

public class Checkout
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public int BookId { get; set; }
    public DateTime CheckoutDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public Member Member { get; set; } = null!;
    public Book Book { get; set; } = null!;
}

