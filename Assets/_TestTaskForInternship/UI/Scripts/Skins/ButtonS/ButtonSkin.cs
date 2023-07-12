using UnityEngine;
using UnityEngine.UI;

namespace GameForInternship
{
    public abstract class ButtonSkin : MonoBehaviour
    {
        protected readonly PlayerPrefsString playerPrefsString = new();

        [SerializeField] private SkinManager _skinManager;
        [SerializeField] private Image _selectedSkin;
        private Button _button;
        private Image _image;

        protected Sprite GetSprite { get => _image.sprite; }
        protected SkinManager GetSkinManager { get => _skinManager; }

        protected virtual void Awake()
        {
            _button = GetComponent<Button>();
            _image = GetComponent<Image>();
            _button.onClick.AddListener(RememberSkin);
            _button.onClick.AddListener(ChangeSkin);
        }

        protected abstract void RememberSkin();

        private void ChangeSkin()
        {
            _selectedSkin.sprite = GetSprite;
        }
    }
}
