using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models;

public partial class Product
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage ="Name is required .")]
    [StringLength(50, ErrorMessage = "Not More Than 50")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Descriton is required")]
    [StringLength(200, ErrorMessage = "Not More than 200")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Price is requied .")]
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
    public virtual List<OrderItem>? OrderItems { get; set; }
    public List<Review>? Reviews { get; set; }
    public List<CartItem>? CartItems { get; set; }

}
