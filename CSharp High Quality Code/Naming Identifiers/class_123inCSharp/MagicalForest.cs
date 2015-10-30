/* The Original

class class_123
{
  const int max_count=6;
  class InClass_class_123
  {
    void Метод_нА_class_InClass_class_123(bool promenliva)
    {
      string promenlivaKatoString=promenliva.ToString();
      Console.WriteLine(promenlivaKatoString);
      }
  }       
  public static void Метод_За_Вход()
  {
    class_123.InClass_class_123 инстанция =
      new class_123.InClass_class_123();
    инстанция.Метод_нА_class_InClass_class_123(true); 
  }
}

*/

namespace class_123inCSharp
{
    using System;

    public class MagicalForest
    {
        private const int MAGIC_CREATURES_MAX_COUNT = 6;

        public static void EntryToTheForest()
        {
            MagicalForest.DeeperIntoTheMagicalForest magicalForest = new MagicalForest.DeeperIntoTheMagicalForest();
            magicalForest.EnchantingTheForest(true);
        }

        public class DeeperIntoTheMagicalForest
        {
            public void EnchantingTheForest(bool isEnchantable)
            {
                string isMagicalAsString = isEnchantable.ToString();
                Console.WriteLine(isMagicalAsString);
            }
        }       
    }
}

// I know i can separate the classes... but i don't want to ruin the magic!