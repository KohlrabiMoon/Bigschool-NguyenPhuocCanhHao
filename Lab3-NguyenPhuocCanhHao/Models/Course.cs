using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_NguyenPhuocCanhHao.Models
{
    public class Course
    {
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        [Required]
        public ApplicationUser Lecturer
        {
            get { return Lecturer; }
            set { Lecturer = value; }
        }

        public string LecturerId { get; set; }
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]

        public byte CategoryId
        {
            get { return CategoryId; }
            set { CategoryId = value; }
        }
    }
}