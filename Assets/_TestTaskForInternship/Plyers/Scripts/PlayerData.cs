using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GameForInternship
{
    public class PlayerData : MonoBehaviour
    {
        [SerializeField] private GameObject[] _players;

        private LineMovement[] _lineMovements;
        private DrawnLine[] _drawnLine;
        private int _numberPlayers;

        public LineMovement[] LineMovements { get => _lineMovements; }
        public DrawnLine[] DrawnLines { get => _drawnLine; }
        public int NumberPlayers { get => _numberPlayers; }

        private void Awake()
        {
            _numberPlayers = _players.Length;

            _lineMovements = new LineMovement[_numberPlayers];
            _drawnLine = new DrawnLine[_numberPlayers];

            for (int i = 0; i < _players.Length; i++)
            {
                _lineMovements[i] = _players[i].GetComponent<LineMovement>();
                _drawnLine[i] = _players[i].GetComponent<DrawnLine>();
            }
        }

        private void OnValidate()
        {
            _players = _players.Distinct().ToArray();

            List<GameObject> playersCloneArray = new List<GameObject>();
            foreach (var i in _players)
            {
                if (i.TryGetComponent<LineMovement>(out _) &&
                    i.TryGetComponent<DrawnLine>(out _))
                {
                    playersCloneArray.Add(i);
                }
            }

            _players = playersCloneArray.ToArray();
        }
    }
}
