using UnityEngine;

namespace GameForInternship
{
    public class ButtonSkinDog : ButtonSkin
    {
        protected override void RememberSkin()
        {
            for (int i = 0; i < GetSkinManager.DogSkins.Count; i++)
            {
                if (GetSkinManager.DogSkins[i] == GetSprite)
                {
                    PlayerPrefs.SetInt(playerPrefsString.DogSkinSourseId, i);
                    SelectedSkins.DogSprite = GetSprite;
                    SelectedSkins.DogAnimator = GetSkinManager.DogAnimators[GetSprite];
                    break;
                }
            }
        }
    }
}
