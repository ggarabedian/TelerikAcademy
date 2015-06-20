namespace VersionAttribute
{
    using System;

    [VersionAttribute("Some Game", "2.11")]
    public class VersionAttributeMain
    {
        static void Main()
        {
            var attributes = typeof(VersionMain).GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine("{0}   Version: {1}", attribute.Name, attribute.Version);
            }
        }
    }
}
