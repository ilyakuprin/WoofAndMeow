using System.Collections;
using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(PlayerData))]
    public class CollisionHandler : MonoBehaviour
    {
        [SerializeField] private GameObject _defeatScreen;
        [SerializeField, Range(0, 10)] private float _timeWainting;
        private PlayerData _playerData;
        private bool _runningState = false;

        private void Awake()
        {
            _playerData = GetComponent<PlayerData>();
        }

        public void CollisionPlayers()
        {
            StartDefeatState();
        }
        public void CollisionWithObstacle()
        {
            StartDefeatState();
        }

        private void StartDefeatState()
        {
            if (!_runningState)
            {
                _runningState = true;

                for (int i = 0; i < _playerData.NumberPlayers; i++)
                {
                    _playerData.LineMovements[i].StopMove();
                }

                StartCoroutine(StartDefeatScreen());
            }
        }

        private IEnumerator StartDefeatScreen()
        {
            yield return new WaitForSeconds(_timeWainting);
            _defeatScreen.SetActive(true);
            yield return null;
        }
    }
}