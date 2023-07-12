using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace GameForInternship
{
    public class SkinManager : MonoBehaviour
    {
        [SerializeField] private Sprite[] _cat;
        [SerializeField] private Sprite[] _fish;
        [SerializeField] private Sprite[] _dog;
        [SerializeField] private Sprite[] _bone;
        [SerializeField] private AnimatorController[] _catAnimator;
        [SerializeField] private AnimatorController[] _dogAnimator;

        private Dictionary<int, Sprite> _fishSkins = new();
        private Dictionary<int, Sprite> _boneSkins = new();
        private Dictionary<int, Sprite> _catSkins = new();
        private Dictionary<int, Sprite> _dogSkins = new();
        private Dictionary<Sprite, AnimatorController> _catAnimators = new();
        private Dictionary<Sprite, AnimatorController> _dogAnimators = new();

        public Dictionary<int, Sprite> FishSkins { get => _fishSkins; }
        public Dictionary<int, Sprite> BoneSkins { get => _boneSkins; }
        public Dictionary<int, Sprite> CatSkins { get => _catSkins; }
        public Dictionary<int, Sprite> DogSkins { get => _dogSkins; }
        public Dictionary<Sprite, AnimatorController> CatAnimators { get => _catAnimators; }
        public Dictionary<Sprite, AnimatorController> DogAnimators { get => _dogAnimators; }

        private void Awake()
        {
            for (int i = 0; i < _fish.Length; i++)
            {
                _fishSkins.Add(i, _fish[i]);
            }
            for (int i = 0; i < _bone.Length; i++)
            {
                _boneSkins.Add(i, _bone[i]);
            }
            for (int i = 0; i < _cat.Length; i++)
            {
                _catSkins.Add(i, _cat[i]);
                _catAnimators.Add(_cat[i], _catAnimator[i]);
            }
            for (int i = 0; i < _dog.Length; i++)
            {
                _dogSkins.Add(i, _dog[i]);
                _dogAnimators.Add(_dog[i], _dogAnimator[i]);
            }
        }
    }
}
