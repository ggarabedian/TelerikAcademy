namespace LinearDataStructures.Utilities
{
    using System;
    using System.Collections.Generic;

    public static class InputGenerator
    {
        public static List<int> GetInputAsList()
        {
            var inputs = new List<int>();
            var userInput = Console.ReadLine();

            while (!string.IsNullOrEmpty(userInput))
            {
                var userInputAsNumber = int.Parse(userInput);
                inputs.Add(userInputAsNumber);

                userInput = Console.ReadLine();
            }

            return inputs;
        }

        public static Stack<int> GetInputAsStack()
        {
            var inputs = new Stack<int>();
            var userInput = Console.ReadLine();

            while (!string.IsNullOrEmpty(userInput))
            {
                var userInputAsNumber = int.Parse(userInput);
                inputs.Push(userInputAsNumber);

                userInput = Console.ReadLine();
            }

            return inputs;
        }

        public static List<int> GetListOfRandomNumbers(int min, int max)
        {
            var numbers = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(min, max));
            }

            return numbers;
        }
    }
}
