using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models;

public partial class Category
{
    public int Id { get; set; }
    [Display(Name = "Category Name")]
    [StringLength(60, ErrorMessage = "Name Cannot be more than 60")]
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    [StringLength(300, ErrorMessage = "Not more than 300")]
    public string? Description { get; set; }
    public int? ParentCategoryId { get; set; }
    public virtual ICollection<Product>? Products { get; set; } = new List<Product>();
}
