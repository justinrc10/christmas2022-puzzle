using System.Collections.Generic;

namespace Path {
    public class World {
        protected int[,] _distances;
        protected string[] _namesByIndex;
        protected Dictionary<string, int> _indiciesByName;

        public World() {
            _distances = new int[,] { };
            _namesByIndex = Array.Empty<string>();
            _indiciesByName = new Dictionary<string, int> { };
        }

        public World(IEnumerable<string> locations) {
            _namesByIndex = locations.ToArray();
            int length = _namesByIndex.Length;
            _distances = new int[length, length];
            _indiciesByName = new();

            for(int i = 0; i < length; i++) {
                _indiciesByName.Add(_namesByIndex[i], i);

                for (int j = 0; j < length; j++) {
                    _distances[i,j] = -1;
                }
            }
        }

        private World(int[,] distances, IEnumerable<string> locations) {
            _namesByIndex = locations.ToArray();
            int length = _namesByIndex.Length;
            _distances = new int[length, length];
            _indiciesByName = new();

            for(int i = 0; i < length; i++) {
                _indiciesByName.Add(_namesByIndex[i], i);

                for (int j = 0; j < length; j++) {
                    _distances[i,j] = distances[i,j];
                }
            }
        }

        protected World CreateCopy() => new(_distances, _namesByIndex);

        /// <returns>The name of the location with the given index. If no such location exists, an empty string is returned.</returns>
        public string GetLocationName(int index) => (index >= 0 && index < _namesByIndex.Length) ? _namesByIndex[index] : "";
        /// <returns>The index of the location with the given name. If no such location exists, -1 is returned.</returns>
        public int GetLocationIndex(string name) => _indiciesByName.TryGetValue(name, out int index) ? index : -1;

        /// <returns>An enumerable which allows iteration across all location names in this world.</returns>
        public IEnumerable<string> GetLocationNames() {
            var names = new string[_namesByIndex.Length];
            Array.Copy(_namesByIndex, names, names.Length);
            return names;
        }

        /// <returns>
        /// The neighbors of the given locations and the distances to those neighbors.
        /// This is the least efficient version of this function since the neighbors are returned with their names, which takes an extra step to retrieve.
        /// The more efficient version of this function is FindNeighborIndicies, which skips that step.
        /// </returns>
        public Dictionary<string, int> FindNeighbors(string location) =>
            _indiciesByName.ContainsKey(location) ? FindNeighbors(GetLocationIndex(location)) : new();
        /// <returns>
        /// The neighbors of the given locations and the distances to those neighbors.
        /// The more efficient version of this function is FindNeighborIndicies.
        /// </returns>
        public Dictionary<string, int> FindNeighbors(int location) {
            var neighbors = new Dictionary<string, int>();

            if (location >= 0 && location < _namesByIndex.Length) {
                for (int i = 0; i < _distances.GetLength(1); i++) {
                    var distance = _distances[location, i];
                    if (distance > 0) {
                        neighbors.Add(GetLocationName(i), distance);
                    }
                }
            }

            return neighbors;
        }

        /// <returns>
        /// The indicies of the neighbors of the given locations and the distances to those neighbors.
        /// To maximize efficiency, use the version of this function which takes a location index as a parameter.
        /// </returns>
        public Dictionary<int, int> FindNeighborIndicies(string location) =>
            _indiciesByName.ContainsKey(location) ? FindNeighborIndicies(GetLocationIndex(location)) : new();
        /// <returns>
        /// The indicies of the neighbors of the given locations and the distances to those neighbors.
        /// To maximize efficiency, use the version of this function which takes a location index as a parameter.
        /// </returns>
        public Dictionary<int, int> FindNeighborIndicies(int location) {
            var neighbors = new Dictionary<int, int>();

            if (location >= 0 && location < _namesByIndex.Length) {
                for (int i = 0; i < _distances.GetLength(1); i++) {
                    var distance = _distances[location, i];
                    if (distance >= 0) {
                        neighbors.Add(i, distance);
                    }
                }
            }

            return neighbors;
        }
    }

    public class MutableWorld : World {
        public MutableWorld() : base() {}
        public MutableWorld(IEnumerable<string> locations) : base(locations) {}

        public World ToReadOnlyWorld() => CreateCopy();

        public bool TrySetDistance(int distance, string sourceLocation, string destinationLocation, bool isMirroring = true) {
            if (_indiciesByName.TryGetValue(sourceLocation, out int sourceIndex) && _indiciesByName.TryGetValue(destinationLocation, out int destinationIndex)) {
                _distances[sourceIndex, destinationIndex] = distance;

                if (isMirroring) {
                    _distances[destinationIndex, sourceIndex] = distance;
                }

                return true;
            }

            return false;
        }
    }
}
