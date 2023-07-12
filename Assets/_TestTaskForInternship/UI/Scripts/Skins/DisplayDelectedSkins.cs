using UnityEngine;
using UnityEngine.UI;

namespace GameForInternship
{
    public class DisplayDelectedSkins : MonoBehaviour
    {
        [SerializeField] private Image _cat;
        [SerializeField] private Image _dog;
        [SerializeField] private Image _bone;
        [SerializeField] private Image _fish;

        private void Start()
        {
            _cat.sprite = SelectedSkins.CatSprite;
            _dog.sprite = SelectedSkins.DogSprite;
            _bone.sprite = SelectedSkins.BoneSprite;
            _fish.sprite = SelectedSkins.FishSprite;
        }
    }
}
