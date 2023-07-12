using UnityEngine;

namespace GameForInternship
{
    public class ButtonSkinBone : ButtonSkin
    {
        protected override void RememberSkin()
        {
            for (int i = 0; i < GetSkinManager.BoneSkins.Count; i++)
            {
                if (GetSkinManager.BoneSkins[i] == GetSprite)
                {
                    PlayerPrefs.SetInt(playerPrefsString.BoneSkinSourseId, i);
                    SelectedSkins.BoneSprite = GetSprite;
                    break;
                }
            }
        }
    }
}
