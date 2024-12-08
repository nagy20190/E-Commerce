using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models;

public partial class ShoppingCart
{
    [Key]
    public int Cartid { get; set; }
    [ForeignKey("Customre")]
    public int? CustomreId { get; set; }
    public virtual List<CartItem>? CartItems { get; set; }
    public virtual Customer? Customre { get; set; }
}
