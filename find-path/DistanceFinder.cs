namespace Path {
    public class DistanceFinder {
        private World _world;

        public World World => _world;

        public DistanceFinder(World world) {
            _world = world;
        }

        /// <summary>
        /// Modify this function such that the distance of the shortest path between "start" and "end" is found.
        /// </summary>
        /// <param name="start">The starting point of the path.</param>
        /// <param name="end">The destination of the path.</param>
        /// <returns>The distance of the shortest path between "start" and "end".</returns>
        public int FindShortestDistance(string start, string end) {
            /// Create a collection listing the locations in the world
            IEnumerable<string> locations = _world.GetLocationNames();

            /// If the starting and ending locations aren't in the world, return -1
            if (!locations.Contains(start) || !locations.Contains(end))
            {
                return -1;
            }

            /// If the starting and ending locations are the same, then the distance is 0
            else if (start == end)
            {
                return 0;
            }

            /// Otherwise, the starting and ending locations are distinct locations in the world
            /// We will assume that furthest distance between any two locations is less than or equal to int.MaxValue

            return FindShortestDistanceHelper(start, end, 0, new string[] {start}, -1);
        }

        private int FindShortestDistanceHelper(string currentLocation, string end, int distanceTraveled, IEnumerable<string> locationsVisited, int shortestDistance) {
            /// If the current location is the end location, then we check if the current path is the shortest path
            if (currentLocation == end)
            {
                /// If the distance traveled for this path is less than the shortest distance traveled, then we update shortestDistance
                if (shortestDistance > distanceTraveled || shortestDistance == -1)
                {
                    shortestDistance = distanceTraveled;
                }
                /// Return the shortest distance traveled
                return shortestDistance;
            }

            /// Create a dictionary listing the neighbors and their distances of the current location
            Dictionary<string, int> neighbors = _world.FindNeighbors(currentLocation);

            /// If all of the neighbors of the current location have already been visited, then we are at a dead end, so do not update shortestDistance
            if (locationsVisited == neighbors.Keys)
            {
                return shortestDistance;
            }
            
            foreach (string neighbor in neighbors.Keys)
            {
                /// If a location has not been visited before, follow this path and track the distance
                if (!locationsVisited.Contains(neighbor))
                {
                    shortestDistance = FindShortestDistanceHelper(neighbor, end, distanceTraveled + neighbors[neighbor], locationsVisited.Append(neighbor), shortestDistance);
                }
            }

            return shortestDistance;
        }
    }
}