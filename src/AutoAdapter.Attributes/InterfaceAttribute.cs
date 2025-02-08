using System;

namespace AutoAdapter.Attributes
{
    [System.AttributeUsage(AttributeTargets.Interface)]
    public class InterfaceAttribute : System.Attribute
    {
        private readonly Type type;

        public InterfaceAttribute(Type type)
        {
            this.type = type;
        }

        public InterfaceAttribute(string type)
        { 
            this.type = Type.GetType(type);
        }
    }
}
