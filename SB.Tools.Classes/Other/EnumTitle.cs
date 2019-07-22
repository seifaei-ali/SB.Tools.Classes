
// ReSharper disable once CheckNamespace
namespace System
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumTitle : Attribute
    {
        public string Name { get; set; }
        public Type ResourceType { get; set; }

        public EnumTitle(Type resourceType, string name)
        {
            this.Name = name;
            this.ResourceType = resourceType;
        }
    }
}