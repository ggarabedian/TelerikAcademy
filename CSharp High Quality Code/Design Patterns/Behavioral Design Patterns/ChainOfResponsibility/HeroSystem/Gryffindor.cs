namespace ChainOfResponsibility.HeroSystem
{
    using System;

    using ChainOfResponsibility.ItemSystem;

    public class Gryffindor : HeroHandlerBase
    {
        public Gryffindor()
        {
            this.Name = "Gryffindor";
            this.MagicSkill = 101;
        }

        public string Name { get; set; }

        public int MagicSkill { get; set; }

        public override EquipmentEvaluationResult EvaluateEquipment(Equipment equipment)
        {
            if (equipment.MinMagicSkillRequiredToUse < this.MagicSkill)
            {
                Console.WriteLine(this.Name + " successfully equiped " + equipment.Name + "!");
                return EquipmentEvaluationResult.CanEquipItem;
            }
            if (successor != null)
            {
                return successor.EvaluateEquipment(equipment);
            }
            return EquipmentEvaluationResult.CannotEquipItem;
        }
    }
}
