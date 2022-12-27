namespace Path {
    public class TestWorldBuilder {
        private World _questionWorld;
        private World _answerWorld;

        public World QuestionWorld => _questionWorld;

        public TestWorldBuilder() {
            var worldbuilder = new MutableWorld(new string[] {
                "LUMBRIDGE", "DRAYNOR", "AL_KHARID", "VARROCK", "CANIFIS", "FALADOR", "PORT_SARIM", "EDGEVILLE", "BARBARIAN_VILLAGE", "TAVERLY", "BURTHORPE", "CATHERBY", "RIMMINGTON"
            });

            worldbuilder.TrySetDistance(3, "LUMBRIDGE", "AL_KHARID");
            worldbuilder.TrySetDistance(4, "LUMBRIDGE", "DRAYNOR");
            worldbuilder.TrySetDistance(6, "LUMBRIDGE", "VARROCK");
            worldbuilder.TrySetDistance(13, "LUMBRIDGE", "CANIFIS");
            worldbuilder.TrySetDistance(8, "VARROCK", "CANIFIS");
            worldbuilder.TrySetDistance(2, "VARROCK", "BARBARIAN_VILLAGE");
            worldbuilder.TrySetDistance(4, "VARROCK", "DRAYNOR");
            worldbuilder.TrySetDistance(4, "VARROCK", "EDGEVILLE");
            worldbuilder.TrySetDistance(1, "BARBARIAN_VILLAGE", "EDGEVILLE");
            worldbuilder.TrySetDistance(3, "BARBARIAN_VILLAGE", "DRAYNOR");
            worldbuilder.TrySetDistance(3, "BARBARIAN_VILLAGE", "FALADOR");
            worldbuilder.TrySetDistance(4, "BARBARIAN_VILLAGE", "TAVERLY");
            worldbuilder.TrySetDistance(3, "FALADOR", "DRAYNOR");
            worldbuilder.TrySetDistance(2, "FALADOR", "RIMMINGTON");
            worldbuilder.TrySetDistance(2, "FALADOR", "PORT_SARIM");
            worldbuilder.TrySetDistance(3, "FALADOR", "EDGEVILLE");
            worldbuilder.TrySetDistance(3, "FALADOR", "TAVERLY");
            worldbuilder.TrySetDistance(1, "DRAYNOR", "PORT_SARIM");
            worldbuilder.TrySetDistance(3, "DRAYNOR", "RIMMINGTON");
            worldbuilder.TrySetDistance(1, "PORT_SARIM", "RIMMINGTON");
            worldbuilder.TrySetDistance(5, "EDGEVILLE", "TAVERLY");
            worldbuilder.TrySetDistance(2, "TAVERLY", "BURTHORPE");
            worldbuilder.TrySetDistance(2, "TAVERLY", "CATHERBY");
            worldbuilder.TrySetDistance(5, "BURTHORPE", "CATHERBY");

            _questionWorld = worldbuilder.ToReadOnlyWorld();

            worldbuilder.TrySetDistance(7, "LUMBRIDGE", "BARBARIAN_VILLAGE");
            worldbuilder.TrySetDistance(8, "LUMBRIDGE", "EDGEVILLE");
            worldbuilder.TrySetDistance(7, "LUMBRIDGE", "FALADOR");
            worldbuilder.TrySetDistance(5, "LUMBRIDGE", "PORT_SARIM");
            worldbuilder.TrySetDistance(6, "LUMBRIDGE", "RIMMINGTON");
            worldbuilder.TrySetDistance(10, "LUMBRIDGE", "TAVERLY");
            worldbuilder.TrySetDistance(12, "LUMBRIDGE", "BURTHORPE");
            worldbuilder.TrySetDistance(12, "LUMBRIDGE", "CATHERBY");
            worldbuilder.TrySetDistance(9, "AL_KHARID", "VARROCK");
            worldbuilder.TrySetDistance(16, "AL_KHARID", "CANIFIS");
            worldbuilder.TrySetDistance(7, "AL_KHARID", "DRAYNOR");
            worldbuilder.TrySetDistance(10, "AL_KHARID", "BARBARIAN_VILLAGE");
            worldbuilder.TrySetDistance(11, "AL_KHARID", "EDGEVILLE");
            worldbuilder.TrySetDistance(10, "AL_KHARID", "FALADOR");
            worldbuilder.TrySetDistance(8, "AL_KHARID", "PORT_SARIM");
            worldbuilder.TrySetDistance(9, "AL_KHARID", "RIMMINGTON");
            worldbuilder.TrySetDistance(13, "AL_KHARID", "TAVERLY");
            worldbuilder.TrySetDistance(15, "AL_KHARID", "BURTHORPE");
            worldbuilder.TrySetDistance(15, "AL_KHARID", "CATHERBY");
            worldbuilder.TrySetDistance(3, "VARROCK", "EDGEVILLE");
            worldbuilder.TrySetDistance(5, "VARROCK", "FALADOR");
            worldbuilder.TrySetDistance(5, "VARROCK", "PORT_SARIM");
            worldbuilder.TrySetDistance(6, "VARROCK", "RIMMINGTON");
            worldbuilder.TrySetDistance(6, "VARROCK", "TAVERLY");
            worldbuilder.TrySetDistance(8, "VARROCK", "BURTHORPE");
            worldbuilder.TrySetDistance(8, "VARROCK", "CATHERBY");
            worldbuilder.TrySetDistance(12, "CANIFIS", "DRAYNOR");
            worldbuilder.TrySetDistance(10, "CANIFIS", "BARBARIAN_VILLAGE");
            worldbuilder.TrySetDistance(11, "CANIFIS", "EDGEVILLE");
            worldbuilder.TrySetDistance(13, "CANIFIS", "FALADOR");
            worldbuilder.TrySetDistance(13, "CANIFIS", "PORT_SARIM");
            worldbuilder.TrySetDistance(14, "CANIFIS", "RIMMINGTON");
            worldbuilder.TrySetDistance(14, "CANIFIS", "TAVERLY");
            worldbuilder.TrySetDistance(16, "CANIFIS", "BURTHORPE");
            worldbuilder.TrySetDistance(16, "CANIFIS", "CATHERBY");
            worldbuilder.TrySetDistance(4, "DRAYNOR", "EDGEVILLE");
            worldbuilder.TrySetDistance(2, "DRAYNOR", "RIMMINGTON");
            worldbuilder.TrySetDistance(6, "DRAYNOR", "TAVERLY");
            worldbuilder.TrySetDistance(8, "DRAYNOR", "BURTHORPE");
            worldbuilder.TrySetDistance(8, "DRAYNOR", "CATHERBY");
            worldbuilder.TrySetDistance(4, "BARBARIAN_VILLAGE", "PORT_SARIM");
            worldbuilder.TrySetDistance(5, "BARBARIAN_VILLAGE", "RIMMINGTON");
            worldbuilder.TrySetDistance(6, "BARBARIAN_VILLAGE", "BURTHORPE");
            worldbuilder.TrySetDistance(6, "BARBARIAN_VILLAGE", "CATHERBY");
            worldbuilder.TrySetDistance(5, "EDGEVILLE", "PORT_SARIM");
            worldbuilder.TrySetDistance(5, "EDGEVILLE", "RIMMINGTON");
            worldbuilder.TrySetDistance(7, "EDGEVILLE", "BURTHORPE");
            worldbuilder.TrySetDistance(7, "EDGEVILLE", "CATHERBY");
            worldbuilder.TrySetDistance(5, "FALADOR", "BURTHORPE");
            worldbuilder.TrySetDistance(5, "FALADOR", "CATHERBY");
            worldbuilder.TrySetDistance(5, "PORT_SARIM", "TAVERLY");
            worldbuilder.TrySetDistance(7, "PORT_SARIM", "BURTHORPE");
            worldbuilder.TrySetDistance(7, "PORT_SARIM", "CATHERBY");
            worldbuilder.TrySetDistance(5, "RIMMINGTON", "TAVERLY");
            worldbuilder.TrySetDistance(7, "RIMMINGTON", "BURTHORPE");
            worldbuilder.TrySetDistance(7, "RIMMINGTON", "CATHERBY");
            worldbuilder.TrySetDistance(4, "BURTHORPE", "CATHERBY");
            worldbuilder.TrySetDistance(0, "LUMBRIDGE", "LUMBRIDGE");
            worldbuilder.TrySetDistance(0, "AL_KHARID", "AL_KHARID");
            worldbuilder.TrySetDistance(0, "VARROCK", "VARROCK");
            worldbuilder.TrySetDistance(0, "CANIFIS", "CANIFIS");
            worldbuilder.TrySetDistance(0, "DRAYNOR", "DRAYNOR");
            worldbuilder.TrySetDistance(0, "BARBARIAN_VILLAGE", "BARBARIAN_VILLAGE");
            worldbuilder.TrySetDistance(0, "EDGEVILLE", "EDGEVILLE");
            worldbuilder.TrySetDistance(0, "FALADOR", "FALADOR");
            worldbuilder.TrySetDistance(0, "PORT_SARIM", "PORT_SARIM");
            worldbuilder.TrySetDistance(0, "RIMMINGTON", "RIMMINGTON");
            worldbuilder.TrySetDistance(0, "TAVERLY", "TAVERLY");
            worldbuilder.TrySetDistance(0, "BURTHORPE", "BURTHORPE");
            worldbuilder.TrySetDistance(0, "CATHERBY", "CATHERBY");

            _answerWorld = worldbuilder.ToReadOnlyWorld();
        }

        public int CheckAnswer(string start, string end) {
            int startIndex = _answerWorld.GetLocationIndex(start);

            if (startIndex < 0) {
                return -1;
            }

            int endIndex = _answerWorld.GetLocationIndex(end);

            if (endIndex < 0) {
                return -1;
            }

            var answers = _answerWorld.FindNeighborIndicies(startIndex);

            return answers.TryGetValue(endIndex, out int distance) ? distance : -1;
        }
    }
}
