﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.Models
{
    public class BlogLikes
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int UserId { get; set; }
    }
}
