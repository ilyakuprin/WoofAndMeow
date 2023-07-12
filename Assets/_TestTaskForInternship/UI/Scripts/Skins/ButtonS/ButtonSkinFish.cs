using UnityEngine;

namespace GameForInternship
{
    public class ButtonSkinFish : ButtonSkin
    {
        protected override void RememberSkin()
        {
            for (int i = 0; i < GetSkinManager.FishSkins.Count; i++)
            {
                if (GetSkinManager.FishSkins[i] == GetSprite)
                {
                    PlayerPrefs.SetInt(playerPrefsString.FishSkinSourseId, i);
                    SelectedSkins.FishSprite = GetSprite;
                    break;
                }
            }
        }
    }
}
