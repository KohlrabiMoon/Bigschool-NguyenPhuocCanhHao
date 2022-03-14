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

        public string LecturerId
        {
            get { return LecturerId; }
            set { LecturerId = value; }
        }
        [StringLength(255)]
        public string Place
        {
            get { return Place; }
            set { Place = value; }
        }

        public DateTime DateTime
        {
            get { return DateTime; }
            set { DateTime = value; }
        }

        public Category Category
        {
            get { return Category; }
            set { Category = value; }
        }
        [Required]

        public byte CategoryId
        {
            get { return CategoryId; }
            set { CategoryId = value; }
        }
    }
}