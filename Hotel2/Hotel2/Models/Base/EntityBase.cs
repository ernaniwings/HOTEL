﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel2.Models.Base
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}