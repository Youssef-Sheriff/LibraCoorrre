using System.ComponentModel.DataAnnotations;

namespace LibraCore.Models;

public class Member
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    [EmailAddress]
    public string Email { get; set; } = null!;

    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$")]
    public string Password { get; set; } = null!;

    [RegularExpression(@"^(010|011|012|015)\d{8}$")]
    public string PhoneNumber { get; set; } = null!;

    public string Role { get; set; } // e.g., "Librarian", "Member"

    public IEnumerable<Checkout> Checkouts { get; set; } = new List<Checkout>();
}



