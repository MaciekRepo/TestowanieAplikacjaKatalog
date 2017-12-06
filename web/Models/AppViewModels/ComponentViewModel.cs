using System.Collections.Generic;
using ef.Models.App;
using AutoMapper;

namespace web.Models.AppViewModels
{
    public class ComponentViewModel : EntityViewModel
    {
        public int ComponentId { get; set; }
        public string ComponentName { get; set; }
        public static List<ComponentViewModel> GetComponentsViewModelsList()
        {
            return Mapper.Map<List<ComponentViewModel>>(Component.GetComponentsList());
        }
    }
}
