using UnityEngine;

namespace GameForInternship
{
    public class ButtonSkinCat : ButtonSkin
    {
        protected override void RememberSkin()
        {
            for (int i = 0; i < GetSkinManager.CatSkins.Count; i++)
            {
                if (GetSkinManager.CatSkins[i] == GetSprite)
                {
                    PlayerPrefs.SetInt(playerPrefsString.CatSkinSourseId, i);
                    SelectedSkins.CatSprite = GetSprite;
                    SelectedSkins.CatAnimator = GetSkinManager.CatAnimators[GetSprite];
                    break;
                }
            }
        }
    }
}
