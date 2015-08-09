/* The Original

class Hauptklasse
{
  enum Пол { ултра_Батка, Яка_Мацка };
  class чуек
  {
    public Пол пол { get; set; }
    public string име_на_Чуека { get; set; }
    public int Възраст { get; set; }
  }       
  public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
  {
    чуек new_Чуек = new чуек();
    new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
    if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
    {
      new_Чуек.име_на_Чуека = "Батката";
      new_Чуек.пол = Пол.ултра_Батка;
    }
    else
    {
      new_Чуек.име_на_Чуека = "Мацето";
      new_Чуек.пол = Пол.Яка_Мацка;
    }
  }
}

*/

namespace Make_ЧуекInCSharp
{
    public class CreateHuman
    {
        public enum Gender 
        { 
            Male, 
            Female 
        }

        public void CreateNewHuman(int humanID)
        {
            Human newHuman = new Human();
            newHuman.Age = humanID;
            if (humanID % 2 == 0)
            {
                newHuman.Name = "The Macho";
                newHuman.Gender = Gender.Male;
            }
            else
            {
                newHuman.Name = "The Babe";
                newHuman.Gender = Gender.Female;
            }
        }

        // Not doing new file for 5 rows! :P
        public class Human
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
