using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_HandsOn.Models
{
    public class MovieModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        public string MovieName { get; set; }
        
        public int MovieCount { get; set; }

        public string MovieType { get; set; }

        public DateTime MovieDate { get; set; }

        public int Price { get; set; }
    }
}
