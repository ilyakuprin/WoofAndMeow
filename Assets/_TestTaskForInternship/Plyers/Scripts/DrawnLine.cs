using System.Collections;
using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(LineRenderer))]
    public class DrawnLine : MonoBehaviour
    {
        public delegate void ReachZone();
        public event ReachZone ReachedZone;

        [SerializeField] private PressingPosition[] _finish;
        [SerializeField, Range(0.001f, 1f)] private float _width = 0.1f;
        [SerializeField] private GameObject _clueGameObj;

        private LineRenderer _lineRenderer;
        private bool _mouseDownOnPlayer = false;
        private bool _pathBuilt;

        private void Awake()
        {
            _lineRenderer = GetComponent<LineRenderer>();

            _lineRenderer.startWidth = _width;
            _lineRenderer.endWidth = _width;
            _lineRenderer.positionCount = 0;
        }

        private IEnumerator TrackMovements()
        {
            Vector3 currentPosition = GetWorldCoordinate(Input.mousePosition);
            AddCoordinateToLine(currentPosition);

            while (_mouseDownOnPlayer)
            {
                currentPosition = GetWorldCoordinate(Input.mousePosition);

                if (currentPosition != _lineRenderer.GetPosition(_lineRenderer.positionCount - 1))
                {
                    AddCoordinateToLine(currentPosition);
                }

                yield return null;
            }
        }

        private void AddCoordinateToLine(Vector3 currentPosition)
        {
            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, currentPosition);
        }

        private Vector3 GetWorldCoordinate(Vector3 mousePosition)
        {
            Vector3 mousePoint = new Vector3(mousePosition.x, mousePosition.y, 1);
            return Camera.main.ScreenToWorldPoint(mousePoint);
        }

        private void FinalPathCheck()
        {
            for (int i = 0; i < _finish.Length; i++)
            {
                if (_finish[i].PressingInZone)
                {
                    _finish[i].GetComponent<Collider2D>().enabled = false;
                    ReachedZone?.Invoke();
                    _pathBuilt = true;
                    break;
                }
            }

            if (!_pathBuilt)
            {
                _lineRenderer.positionCount = 0;
                _mouseDownOnPlayer = false;
            }
        }

        private void OnMouseDown()
        {
            if (!_pathBuilt)
            {
                _mouseDownOnPlayer = true;
                StartCoroutine(TrackMovements());
            }

            if (_clueGameObj.activeInHierarchy)
            {
                _clueGameObj.SetActive(false);
            }
        }

        private void OnMouseUp()
        {
            if (!_pathBuilt)
            {
                _mouseDownOnPlayer = false;
                FinalPathCheck();
            }
        }
    }
}
