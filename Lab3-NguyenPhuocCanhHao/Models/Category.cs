using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_NguyenPhuocCanhHao.Models
{
    public class Category
    {
        public byte Id
        {
            get { return Id; }
            set { Id = value; }
        }
        [Required]
        [StringLength(255)]
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
    }
}