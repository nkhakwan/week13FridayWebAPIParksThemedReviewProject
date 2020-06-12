// using System.ComponentModel; // required for [DefaultValue(whatever)]
using System.ComponentModel.DataAnnotations;

namespace StateNationalPks.Models
{
  public class Place
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(50)]
    public string Type { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [StringLength(500, ErrorMessage = "Description must be less than 500 characters")]
    public string Description { get; set; }
    [Required]
    public int Rating { get; set; }
    public string ImageUrl { get; set; }
    
  }
}