using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LionsRoarGuild.Models
{
    public class Post
    {
       
        public string MemberName { get; set; }
        [Key]
        public string Description { get; set; }

    }
}