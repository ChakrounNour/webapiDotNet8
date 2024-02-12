using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapiDotNet8.Models
{// one to many 
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
        //Navigation  property for the foreign key (Stock)
        //one  comment can only belong to one stock, so it is a singular relationship
        public Stock? Stock { get; set; }
        //oneToOne
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}