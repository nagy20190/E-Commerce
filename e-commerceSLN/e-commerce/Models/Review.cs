using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models;

public partial class Review
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public double Rating { get; set; }
    [StringLength(130, ErrorMessage = "Comment should not be more than 130 chars !")]
    public string? Comment { get; set; }
    public DateOnly? ReviewDate { get; set; }
    public virtual Customer? Customer { get; set; }
    public virtual Product? Product { get; set; }
}
