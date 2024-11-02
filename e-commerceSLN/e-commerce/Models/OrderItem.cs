using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models;

public partial class OrderItem
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    [Display(Name = "Unit Price")]
    public decimal? UnitPrice { get; set; }
    [Display(Name = "Total Price")]
    public decimal TotalPrice { get; set; }
    public virtual Order? Order { get; set; }
    public virtual Product? Product { get; set; }
}
