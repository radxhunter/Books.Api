﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Api.Entites
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2500)]
        public string Description { get; set; }

        public Guid AuthorId { get; set; }
        public Author Author { get; set; }



    }
}
