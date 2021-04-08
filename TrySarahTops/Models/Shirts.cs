using System.ComponentModel.DataAnnotations;

namespace TrySarahTops.Models
{
    public class Shirt
    {
        //fields and properties
        [Required(ErrorMessage = "Select a color: red, blue, yellow.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Select a color: red, blue, yellow.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Select a size.")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Select a letter.")]
        public char Letter { get; set; }

        [Required(ErrorMessage = "Select the color of you letter")]
        public string ColorofLetter { get; set; }

        [Required(ErrorMessage = "Select a type of shirt.")]
        public string TypeofShirt { get; set; }



        //constructors
        //methods
    }
}
