namespace Composite
{
    public class EntryPoint
    {
        public static void Main()
        {
            var castleFaction = new Faction("Castle");

            var adelaHero = new Hero("Adela", 10);

            castleFaction.Add(adelaHero);

            var pikemans = new Creature("Pikemans", 1000);
            var archers = new Creature("Archers", 400);
            var griffins = new Creature("Griffins", 300);
            var swordsmans = new Creature("Swordsmans", 200);
            var monks = new Creature("Monks", 100);

            adelaHero.Add(pikemans);
            adelaHero.Add(archers);
            adelaHero.Add(griffins);
            adelaHero.Add(swordsmans);
            adelaHero.Add(monks);

            castleFaction.Display(0);

            var rampartFaction = new Faction("Rampart");

            var geluHero = new Hero("Gelu", 15);

            rampartFaction.Add(geluHero);

            var centaurs = new Creature("Centaurs", 1500);
            var dwarves = new Creature("Dwarves", 700);
            var elves = new Creature("Elves", 400);
            var pegasus = new Creature("Pegasus", 250);
            var unicorns = new Creature("Unicorns", 150);
            var greenDragons = new Creature("Green Dragons", 25);

            geluHero.Add(centaurs);
            geluHero.Add(dwarves);
            geluHero.Add(elves);
            geluHero.Add(pegasus);
            geluHero.Add(unicorns);
            geluHero.Add(greenDragons);

            rampartFaction.Display(0);
        }
    }
}
