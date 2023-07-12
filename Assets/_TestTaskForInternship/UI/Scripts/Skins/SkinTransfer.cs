using UnityEngine;

namespace GameForInternship
{
    public class SkinTransfer : MonoBehaviour
    {
        private SkinManager _skinManager;
        private readonly PlayerPrefsString _playerPrefsString = new();

        private void Start()
        {
            _skinManager = GetComponent<SkinManager>();

            if (!PlayerPrefs.HasKey(_playerPrefsString.CatSkinSourseId))
            {
                PlayerPrefs.SetInt(_playerPrefsString.CatSkinSourseId, 0);
            }
            SelectedSkins.CatSprite = _skinManager.CatSkins[PlayerPrefs.GetInt(_playerPrefsString.CatSkinSourseId)];
            SelectedSkins.CatAnimator = _skinManager.CatAnimators[SelectedSkins.CatSprite];

            if (!PlayerPrefs.HasKey(_playerPrefsString.DogSkinSourseId))
            {
                PlayerPrefs.SetInt(_playerPrefsString.DogSkinSourseId, 0);
            }
            SelectedSkins.DogSprite = _skinManager.DogSkins[PlayerPrefs.GetInt(_playerPrefsString.DogSkinSourseId)];
            SelectedSkins.DogAnimator = _skinManager.DogAnimators[SelectedSkins.DogSprite];

            if (!PlayerPrefs.HasKey(_playerPrefsString.FishSkinSourseId))
            {
                PlayerPrefs.SetInt(_playerPrefsString.FishSkinSourseId, 0);
            }
            SelectedSkins.FishSprite = _skinManager.FishSkins[PlayerPrefs.GetInt(_playerPrefsString.FishSkinSourseId)];
            
            if (!PlayerPrefs.HasKey(_playerPrefsString.BoneSkinSourseId))
            {
                PlayerPrefs.SetInt(_playerPrefsString.BoneSkinSourseId, 0);
            }
            SelectedSkins.BoneSprite = _skinManager.BoneSkins[PlayerPrefs.GetInt(_playerPrefsString.BoneSkinSourseId)];
        }
    }
}
