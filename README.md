# christmas2022-puzzle

The objective of this puzzle is to open `DistanceFinder.cs` and update the function `FindShortestDistance` to find the shortest distance between any two locations within the `World` instance.
The resultant function should have the following properties:
* The locations are given as two `string`s, and the distance returned is an integer. This should be the shortest possible distance between those locations given the configuration of the `World`.
* If either of the two locations given are not within the `World`, then `-1` should be returned.
* If the same location is given for both inputs, then `0` should be returned. **This should only happen if the given location is in the `World`!**
* *Note: If a location name has one or more spaces in it, e.g. "Al Kharid", replace the spaces with underscores, e.g. `"AL_KHARID"`.*

An example graph is given in this version of the problem (*see `TestWorldBuilder.cs`*), and the correct answer to each distance is similarly defined within the project. The objective is to create the algorithm that gives the correct answers, and theoretically the same algorithm should work correctly with an entirely different `World` configuration.

Input should be given through the command line by entering two words separated by a space. The following single-word commands are also available:
* `ALL` - Runs all cases and outputs the results, regardless of correctness.
* `DIFF`, `DIFFERENCE`, `DF`, `D`, `CHECK` - These commands all do the same thing, which is to run all cases but only output the results where an incorrect answer was detected.
* `QUIT`, `Q`, `EXIT`, `DONE`, `BYE` - These commands all do the same thing, which is to terminate the program.

---

The following data structures may be helpful in completing this task:
* [List](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0)
* [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-7.0)
* [Queue](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-7.0)
* [Stack](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-7.0)

If this syntax `List<int>` is confusing to you, here is the relevant documentation.
* [Type parameters](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-type-parameters)
