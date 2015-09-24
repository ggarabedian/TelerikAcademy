namespace ChainOfResponsibility
{
    using ChainOfResponsibility.ItemSystem;

    public abstract class HeroHandlerBase
    {
        protected HeroHandlerBase successor;

        public void SetSuccessor(HeroHandlerBase successor)
        {
            this.successor = successor;
        }

        public abstract EquipmentEvaluationResult EvaluateEquipment(Equipment equipment);
    }
}
