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
            return -1;
        }
    }
}
