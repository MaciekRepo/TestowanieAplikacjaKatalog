using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace web.Models.AppViewModels
{
    public class AuthorViewModel : EntityViewModel
    {
        [Display(Name = "Nazwisko")]
        public string FirstName { get; set; }
        [Display(Name = "Imiê")]
        public string LastName { get; set; }
        [Display(Name = "Posty autora")]
        public virtual ICollection<PostViewModel> Posts { get; set; }
    }
}