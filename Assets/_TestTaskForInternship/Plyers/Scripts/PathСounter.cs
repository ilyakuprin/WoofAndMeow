using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(PlayerData))]
    public class PathСounter : MonoBehaviour
    {
        private PlayerData _playerData;
        private int _currentNumberPaths = 0;
        private int _finalNumberPath;

        private void Awake()
        {
            _playerData = GetComponent<PlayerData>();
        }

        private void Start()
        {
            _finalNumberPath = _playerData.NumberPlayers;

            for (int i = 0; i < _finalNumberPath; i++)
            {
                _playerData.DrawnLines[i].ReachedZone += OnCountPath;
            }
        }

        public void OnCountPath()
        {
            _currentNumberPaths += 1;

            if (_currentNumberPaths == _finalNumberPath)
            {
                for (int i = 0; _finalNumberPath > i; i++)
                {
                    _playerData.LineMovements[i].StartMove();
                }
            }
        }

        private void OnDisable()
        {
            for (int i = 0; i < _finalNumberPath; i++)
            {
                _playerData.DrawnLines[i].ReachedZone -= OnCountPath;
            }
        }
    }
}
