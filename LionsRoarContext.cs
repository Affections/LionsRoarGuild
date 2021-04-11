using LionsRoarGuild.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LionsRoarGuild
{
    public class LionsRoarContext : DbContext
    {
        public LionsRoarContext() : base("LionsRoarContext")
        {

        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Achievment> Achievments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<LionsRoarGuild.Models.Post> Posts { get; set; }
    }
}