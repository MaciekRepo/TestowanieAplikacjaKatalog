using System.ComponentModel.DataAnnotations;

namespace web.Models.AppViewModels
{
    public class PostViewModel : EntityViewModel
    {
        [Display(Name = "Zawarto��")]
        public string Content { get; set; }
        [Display(Name = "Autor")]
        public int AuthorId { get; set; }
    }
}