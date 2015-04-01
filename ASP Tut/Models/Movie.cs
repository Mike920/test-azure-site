using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ASP_Tut.Models
{
    public class Movie
    {
        // If you dont want to display a column in a view
        //[ScaffoldColumn(false)]
        public int ID { get; set; }

        [StringLength(60,MinimumLength = 3)]
        public string Title { get; set; }

        [DisplayName("Release date")]
        // TThe DataType attributes do not provide any validation. 
        [DataType(DataType.Date)] //The type is a date so the time is not displayed
        //[DisplayFormat(DataFormatString = "{0:dd.MM.yyy}",ApplyFormatInEditMode = true)]
        //make the date culture specific
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        //must use only  letters (white space, numbers and special characters are not allowed)
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        //Value types (such as decimal, int, float, DateTime)  are inherently required  and don't need the Required attribute. 
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

}