using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models;
public enum OrderStatus
{
    Binding,
    Delivered,
    Received
}

public partial class Order
{
    public int Id { get; set; }
    public int? CustomerId { get; set; }
    public DateOnly? OrderDate { get; set; }
    [Display(Name = "Total Amount")]
    public decimal TotalAmount { get; set; }
    public OrderStatus? Status { get; set; }
    [Required(ErrorMessage = "Shiping Address is requierd .")]
    [Display(Name = "Shiping Address")]
    public string ShipingAddress { get; set; }
    public virtual List<OrderItem>? Items { get; set; }
    public virtual List<Payment>? Payment { get; set; }
    public virtual Customer? Customer { get; set; }
}
