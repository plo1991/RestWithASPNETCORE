﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model.Context.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
