using UnityEngine;

namespace GameForInternship
{
    public class DisplaySkins : MonoBehaviour
    {
        [SerializeField] private GameObject[] _cat;
        [SerializeField] private GameObject[] _dog;
        [SerializeField] private SpriteRenderer[] _bone;
        [SerializeField] private SpriteRenderer[] _fish;

        private void Awake()
        {
            for (int i = 0; i < _cat.Length; i++)
            {
                _cat[i].GetComponent<SpriteRenderer>().sprite = SelectedSkins.CatSprite;
                _cat[i].GetComponent<Animator>().runtimeAnimatorController = SelectedSkins.CatAnimator;
            }
            for (int i = 0; i < _dog.Length; i++)
            {
                _dog[i].GetComponent<SpriteRenderer>().sprite = SelectedSkins.DogSprite;
                _dog[i].GetComponent<Animator>().runtimeAnimatorController = SelectedSkins.DogAnimator;
            }
            for (var i = 0; i < _bone.Length; i++)
            {
                _bone[i].sprite = SelectedSkins.BoneSprite;
            }
            for (int i = 0; i < _fish.Length; i++)
            {
                _fish[i].sprite = SelectedSkins.FishSprite;
            }
        }
    }
}
