using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webapiDotNet8.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title  must be 5 characters")]
        [MaxLength(280, ErrorMessage = "The title cannot exceed 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content  must be 5 characters")]
        [MaxLength(280, ErrorMessage = "The Content cannot exceed 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}