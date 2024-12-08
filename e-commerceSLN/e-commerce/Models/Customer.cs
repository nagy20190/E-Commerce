using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models;

public partial class Customer
{
    public int Id { get; set; }
    [Display(Name = "First Name")]
    [StringLength(20, ErrorMessage = "First Name Should Not be More Than 20")]
    [Required(ErrorMessage = "First Name is required.")]
    public string FirstName { get; set; }
    [Display(Name = "Last Name")]
    [StringLength(20, ErrorMessage = "First Name Should Not be More Than 20")]
    [Required(ErrorMessage = "Last Name is required .")]
    public string LastName { get; set; }
    [StringLength(100, ErrorMessage = " Not More Than 100")]
    [Required(ErrorMessage = "Address is required .")]
    public string Address { get; set; }
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Mail { get; set; }
    [Required(ErrorMessage = "Phone number is required.")]
    [Phone(ErrorMessage = "Invalid Phone Number format")]
    public string Phone { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string PasswordHash { get; set; }

    // Relations
    public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
    public virtual ICollection<Review>? Reviews { get; set; } = new List<Review>();
    public virtual ICollection<ShoppingCart>? ShoppingCarts { get; set; } = new List<ShoppingCart>();
}
