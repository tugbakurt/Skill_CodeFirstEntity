using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.sınıflar
{
    public class yetenekler
    {
        [Key]
        public int id { get; set; }
        public string yetenekaciklama { get; set; }
        public byte deger { get; set; }
    }
}