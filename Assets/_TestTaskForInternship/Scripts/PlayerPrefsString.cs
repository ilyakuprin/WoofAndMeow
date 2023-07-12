namespace GameForInternship
{
    sealed public class PlayerPrefsString
    {
        private readonly string _lastOpenLevel = "LastOpenLevel";
        
        private readonly string _catSkinSourseId = "CatSkinSourseId";
        private readonly string _dogSkinSourseId = "DogSkinSourseId";
        private readonly string _boneSkinSourseId = "BoneSkinSourseId";
        private readonly string _fishSkinSourseId = "FishSkinSourseId";

        public string LastOpenLevel { get => _lastOpenLevel; }
        public string CatSkinSourseId { get => _catSkinSourseId; }
        public string DogSkinSourseId { get => _dogSkinSourseId; }
        public string BoneSkinSourseId { get => _boneSkinSourseId; }
        public string FishSkinSourseId { get => _fishSkinSourseId; }
    }
}
