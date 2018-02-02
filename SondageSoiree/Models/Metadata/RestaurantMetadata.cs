using System;
using System.ComponentModel.DataAnnotations;

namespace SondageSoiree.Models.Metadata
{
    public class RestaurantMetadata
    {
        [Required]
        [StringLength(100)]
        public string Nom;

        [Required]
        [EmailAddress]
        [StringLength(150)]
        [Display(Name = "Email")]
        public string Email;

        [Required]
        [StringLength(250)]
        public string Adresse;

		[Phone]
        [RegularExpression(@"^0[0-9]{9}$")]
        [StringLength(20)]
        [Display(Name ="Téléphone")] 
        public string Telephone;
    }
}