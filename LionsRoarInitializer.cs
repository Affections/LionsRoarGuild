using LionsRoarGuild.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LionsRoarGuild
{
    public class LionsRoarInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LionsRoarContext>
    {
        protected override void Seed(LionsRoarContext context)
        {
            var members = new List<Member>
            {
            new Member{Name="Stan",Rank="SHEFA NA GUILDA"},
           new Member{Name="Blago",Rank="BRATA  NA SHEFA NA GUILDA"},
            };

            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();
            var achievments = new List<Achievment>
            {
            new Achievment{Nickname="Stan",Description="POKORIL SVETA"},
           new Achievment{Nickname="BLAGO",Description="1 milion za 2 meseca :OOOOOOOOO"},
            };
            achievments.ForEach(s => context.Achievments.Add(s));
            context.SaveChanges();
            
        }
    }
}
