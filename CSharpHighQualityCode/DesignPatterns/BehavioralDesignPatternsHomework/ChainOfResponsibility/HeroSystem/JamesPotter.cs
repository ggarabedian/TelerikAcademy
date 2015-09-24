namespace ChainOfResponsibility.HeroSystem
{
    using System;

    using ChainOfResponsibility.ItemSystem;

    public class JamesPotter : HeroHandlerBase
    {
        public JamesPotter()
        {
            this.Name = "James Potter";
            this.MagicSkill = 55;
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
