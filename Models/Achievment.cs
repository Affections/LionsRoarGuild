using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LionsRoarGuild.Models
{
    public class Achievment
    {
        [Key]
        public string Nickname { get; set; }
        public string Description { get; set; }
    }
}