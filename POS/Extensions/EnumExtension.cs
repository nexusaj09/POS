using System;
using System.ComponentModel;

namespace POS.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)            
                return attribute.Description;
            
            throw new ArgumentException("Item not found.", nameof(value));
        }
    }
}
