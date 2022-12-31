namespace Path {
    public class Program {
        public static void Main(string[] args) {
            var worldbuilder = new TestWorldBuilder();
            var world = worldbuilder.QuestionWorld;
            var finder = new DistanceFinder(world);

            bool running = true;

            do {
                Console.WriteLine("Enter two location names separated by a space to find the distance, \"ALL\" to test all cases, \"DIFF\" to output differences, or \"QUIT\" to quit:");
                var input = (Console.ReadLine() ?? "").ToUpper().Split(' ');

                if (input.Length > 1) {
                    Console.WriteLine($"\nCalculated shortest distance between {input[0]} and {input[1]}: {finder.FindShortestDistance(input[0], input[1])}");
                    Console.WriteLine($"Answer key for shortest distance: {worldbuilder.CheckAnswer(input[0], input[1])}\n\n");
                } else {
                    IEnumerable<string> names;

                    switch(input[0]) {

                        case "QUIT":
                        case "Q":
                        case "EXIT":
                        case "BYE":
                        case "DONE":
                            running = false;
                        break;

                        case "ALL":
                            names = world.GetLocationNames();

                            foreach(var start in names) {
                                foreach(var end in names) {
                                    Console.WriteLine($"\n{start} to {end}\nCalculated: {finder.FindShortestDistance(start, end)}\n    Answer: {worldbuilder.CheckAnswer(start, end)}");
                                }
                            }

                            Console.WriteLine("\n");
                        break;

                        case "DIFF":
                        case "DIFFERENCE":
                        case "D":
                        case "CHECK":
                        case "DF":
                        case "aye?":
                            names = world.GetLocationNames();
                            bool differenceFound = false;

                            foreach(var start in names) {
                                foreach(var end in names) {
                                    var calculated = finder.FindShortestDistance(start, end);
                                    var answer = worldbuilder.CheckAnswer(start, end);
                                    if (calculated != answer) {
                                        differenceFound = true;
                                        Console.WriteLine($"\nDifference found!\n{start} to {end}\nCalculated: {calculated}\n    Answer: {answer}");
                                    }
                                }
                            }

                            Console.WriteLine(differenceFound ? "\n" : "\nNo differences were found. Good job!\n\n");
                        break;

                        default:
                            Console.WriteLine($"\nInvalid single word: {input[0]}\n\n");
                        break;

                    }
                }
            } while (running);
        }
    }
}
