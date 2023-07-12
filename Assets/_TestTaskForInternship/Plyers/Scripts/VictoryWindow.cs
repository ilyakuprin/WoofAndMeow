using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameForInternship
{
    [RequireComponent(typeof(PlayerData))]
    public class VictoryWindow : MonoBehaviour
    {
        [SerializeField] private GameObject _victoryScreen;
        [SerializeField] private GameObject _lastLvlScreen;
        [SerializeField, Range(0, 10)] private float _timeWainting;
        private PlayerData _playerData;
        private float _numberPlayers;
        private int _callCounter = 0;
        private int _numberScene;
        private int _currentSceneNumber;

        private void Awake()
        {
            _playerData = GetComponent<PlayerData>();
            _numberScene = SceneManager.sceneCountInBuildSettings;
            _currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
        }

        private void Win()
        {
            _callCounter += 1;

            if (_callCounter == _numberPlayers)
            {
                StartCoroutine(StartVictoryScreen());
            }
        }

        private IEnumerator StartVictoryScreen()
        {
            int indexActiveScene = SceneManager.GetActiveScene().buildIndex;
            if (indexActiveScene < SceneManager.sceneCountInBuildSettings - 1)
            {
                PlayerPrefs.SetInt(new PlayerPrefsString().LastOpenLevel, indexActiveScene + 1);
            }

            yield return new WaitForSeconds(_timeWainting);

            if (_numberScene - 1 == _currentSceneNumber)
            {
                _lastLvlScreen.SetActive(true);
            }
            else
            {
                _victoryScreen.SetActive(true);
            }
        }

        private void OnEnable()
        {
            _numberPlayers = _playerData.NumberPlayers;

            for (int i = 0; i < _numberPlayers; i++)
            {
                _playerData.LineMovements[i].Won += Win;
            }
        }

        private void OnDisable()
        {
            for (int i = 0; i < _numberPlayers; i++)
            {
                _playerData.LineMovements[i].Won -= Win;
            }
        }
    }
}
