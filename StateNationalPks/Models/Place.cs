// using System.ComponentModel; // required for [DefaultValue(whatever)]
using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Place
  {
    public int PlaceId { get; set; }
    [Required]
    [StringLength(50)]
    public string City { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    [StringLength(500, ErrorMessage = "Description must be less than 500 characters")]
    public string Description { get; set; }
    [Required]
    public int Rating { get; set; }
    public string ImageUrl { get; set; }
    
  }
}