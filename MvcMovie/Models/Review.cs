using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Review")]
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        // A drawback of my implementation is that
        // validation must be performed on the text boxes' input
        // and not on the model itself
        public string Name { get; set; }
        [Display(Name = "Review")]
        public string WrittenReview { get; set; }

        [Display(Name = "Review Date"), DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
