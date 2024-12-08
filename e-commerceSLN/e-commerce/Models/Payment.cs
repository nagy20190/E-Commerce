using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models;

public partial class Payment
{
    public int Id { get; set; }
    [ForeignKey(nameof(Order))]
    public int OrderId { get; set; }
    [ForeignKey("Customer")]
    public int? customerId { get; set; }
    [Display(Name = "Payment Date")]
    public DateTime? PaymentDate { get; set; }
    public decimal Amount { get; set; }
    [Display(Name = "Payment Method")]
    public string PaymentMethod { get; set; }
    public string? Status { get; set; }
    public virtual Order? Order { get; set; }
    public virtual Customer? Customer { get; set; }
}
