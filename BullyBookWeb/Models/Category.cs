﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BullyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="This field must be between 1 and 100 characters only.")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}