﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string Name { get; set; }

        [Column("password")]
        public string Password { get; set; }
    }
}
