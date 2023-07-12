using System.Collections;
using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(LineRenderer), typeof(Rigidbody2D))]
    public class LineMovement : MonoBehaviour
    {
        public delegate void ToMove();
        public event ToMove Moved;
        
        public delegate void ToWin();
        public event ToMove Won;

        private Rigidbody2D _rigidbody;
        private Coroutine _move;
        private LineRenderer _lineRenderer;
        private readonly float _time = 3;

        private void Awake()
        {
            _lineRenderer = GetComponent<LineRenderer>();
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private IEnumerator Move()
        {
            Vector3[] points = GetArrayLinePoints();
            float speed = GetLength(points) / _time;

            Moved?.Invoke();

            for (int i = 0; i < points.Length; i++)
            {
                while (_rigidbody.position.x != points[i].x &&
                       _rigidbody.position.y != points[i].y)
                {
                    _rigidbody.position = Vector2.MoveTowards(_rigidbody.position, points[i], speed * Time.deltaTime);
                    yield return null;
                }
            }

            Won?.Invoke();
        }

        private Vector3[] GetArrayLinePoints()
        {
            int countPoints = _lineRenderer.positionCount;
            Vector3[] array = new Vector3[countPoints];
            _lineRenderer.GetPositions(array);
            return array;
        }

        private float GetLength(Vector3[] points)
        {
            float lenhthLine = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                lenhthLine += Vector2.Distance(points[i], points[i + 1]);
            }

            return lenhthLine;
        }

        public void StartMove()
        {
            _move = StartCoroutine(Move());
        }

        public void StopMove()
        {
            StopCoroutine(_move);
        }
    }
}
