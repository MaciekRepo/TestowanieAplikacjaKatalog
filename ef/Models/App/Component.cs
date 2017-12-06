using System.Collections.Generic;

namespace ef.Models.App
{
    public class Component : Entity
    {
        public int ComponentId { get; set; }
        public string ComponentName { get; set; }
        public static List<Component> GetComponentsList()
        {
            List<Component> component = new List<Component>();
            component.Add(new Component { ComponentName = "Autocomplete", Id = 1 });
            component.Add(new Component { ComponentName = "Accordion", Id = 2 });
            component.Add(new Component { ComponentName = "BulletGraph" });
            component.Add(new Component { ComponentName = "Chart" });
            component.Add(new Component { ComponentName = "DatePicker" });
            component.Add(new Component { ComponentName = "Dialog" });
            component.Add(new Component { ComponentName = "Diagram" });
            component.Add(new Component { ComponentName = "DropDown" });
            component.Add(new Component { ComponentName = "Gauge" });
            component.Add(new Component { ComponentName = "Schedule" });
            component.Add(new Component { ComponentName = "Scrollbar" });
            component.Add(new Component { ComponentName = "Slider" });
            component.Add(new Component { ComponentName = "RangeNavigatior" });
            component.Add(new Component { ComponentName = "Rating" });
            component.Add(new Component { ComponentName = "RichTextEditor" });
            component.Add(new Component { ComponentName = "Tab" });
            component.Add(new Component { ComponentName = "TagCloud" });
            component.Add(new Component { ComponentName = "Toolbar" });
            component.Add(new Component { ComponentName = "TreeView" });
            return component;
        }
    }
}
