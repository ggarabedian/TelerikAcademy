namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public VersionAttribute(string name, string version)
        {
            this.Name = name;
            this.Version = version;
        }
    }
}
