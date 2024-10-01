using System.ComponentModel.DataAnnotations;

namespace LibraCore.Models;

public class Book
{
    public int Id { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    [StringLength(100)]
    public string Author { get; set; } = null!;
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true; // Default to available

}

