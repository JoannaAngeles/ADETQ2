using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ADETQ2.Models
{
    public class NewStudentInfo
    {
        [Key]
        public int Student_ID { get; set; }
        
        [Required(ErrorMessage ="Enter Student Name")]
        [Display(Name ="Student Name")]
        public string StudName { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Student Cantact Number")]
        [Display(Name = "Student Contact Number")]
        
        public int ContactNum { get; set; }

        [Required(ErrorMessage = "Enter Student Age")]
        [Display(Name = "Age")]
      
        public int Age { get; set; }

        

    }
}
