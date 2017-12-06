using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.Models.AppViewModels
{
    public class EntityViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Stworzono")]
        public DateTime Created { get; set; }
        [Display(Name = "Zmodyfikowano")]
        public DateTime Modified { get; set; }

        public bool IsNew => Id <= 0;
    }
}