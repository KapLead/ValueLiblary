using System;

namespace ValueLiblary
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyChangingAttribute : Attribute
    {
        public string ValueName { get; private set; }
        public PropertyChangingAttribute(string valueName, PropertyChangingDelegate eventChange)
        {
            ValueName = valueName;
        }
    }


}
