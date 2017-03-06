using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace XrmTaskHelperWpf.Extensions.Markup
{
    public class DisplayNameExtension : MarkupExtension
    {
        public Type Type { get; set; }

        public string PropertyName { get; set; }

        public DisplayNameExtension() { }
        public DisplayNameExtension(string propertyName, Type type)
        {
            PropertyName = propertyName;
            Type = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Type == null || string.IsNullOrEmpty(PropertyName))
                return "";

            var property = Type.GetProperty(PropertyName);
            var displayAttributes = property.GetCustomAttributes(typeof(DisplayAttribute), true);

            if (displayAttributes.Any())
            {
                var displayAttribute = displayAttributes.First() as DisplayAttribute;
                return displayAttribute != null ? displayAttribute.Name : string.Empty;
            }
            return "";
        }
    }
}
