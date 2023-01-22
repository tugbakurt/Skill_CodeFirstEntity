using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.sınıflar
{
    public class Context:DbContext
    {
        public DbSet<yetenekler> yeteneklers { get; set; }
       
    }
}