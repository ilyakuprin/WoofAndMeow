using System.Collections;
using UnityEngine;

namespace GameForInternship
{
    public class CollisionDetection : MonoBehaviour
    {
        [SerializeField] CollisionHandler _collisionHandler;
        private readonly HashLayers _hashLayers = new HashLayers();

        private IEnumerator HandleCollision(Collider2D collision)
        {
            int layerCollision = collision.gameObject.layer;

            if (layerCollision == _hashLayers.Player)
            {
                _collisionHandler.CollisionPlayers();
                GetComponent<AnimationDeathPlayback>().StartAnimationDeath();
            }
            else if (layerCollision == _hashLayers.Obstacle)
            {
                _collisionHandler.CollisionWithObstacle();
                GetComponent<AnimationDeathPlayback>().StartAnimationDeath();
            }
            yield return null;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            StartCoroutine(HandleCollision(collision));
        }
    }
}
