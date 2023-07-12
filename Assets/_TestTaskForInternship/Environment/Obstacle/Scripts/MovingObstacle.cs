using System.Collections;
using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class MovingObstacle : MonoBehaviour
    {
        [SerializeField, Range(0.5f, 5)] private float _speed;
        [SerializeField, Range(0.5f, 5)] private float _timeWait;
        [SerializeField] private Transform _startPoint;
        [SerializeField] private Transform _finishPoint;
        private Rigidbody2D _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            StartCoroutine(MoveObstacle());
        }

        private IEnumerator MoveObstacle()
        {
            Vector2 finish = _finishPoint.position;

            while (_rigidbody.position != finish)
            {
                _rigidbody.position = Vector2.MoveTowards(_rigidbody.position, _finishPoint.position, _speed * Time.deltaTime);
                finish = _finishPoint.position;
                yield return null;
            }

            yield return new WaitForSeconds(_timeWait);

            Instantiate(gameObject, _startPoint.position, Quaternion.identity, transform.parent);
            Destroy(gameObject);
        }
    }
}
