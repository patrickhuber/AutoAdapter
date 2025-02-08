using System;

namespace AutoAdapter.Attributes
{
    [System.AttributeUsage(AttributeTargets.Class)]
    public class AdapterAttribute : System.Attribute
    {
        private readonly Type type;

        public AdapterAttribute(Type type) 
        {
            this.type = type;
        }
    }
}
