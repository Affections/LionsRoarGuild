using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LionsRoarGuild.Models
{
    public class Member
    {
        [Key]
        public string Name { get; set; }
        public string Rank { get; set; }
    }
}