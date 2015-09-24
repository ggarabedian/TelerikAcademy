namespace ChainOfResponsibility.ItemSystem
{
    public abstract class Equipment
    {
        public string Name { get; set; }

        public int MinMagicSkillRequiredToUse { get; set; }
    }
}
