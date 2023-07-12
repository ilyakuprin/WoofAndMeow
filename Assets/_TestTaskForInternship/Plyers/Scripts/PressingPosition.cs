using UnityEngine;

namespace GameForInternship
{
    public class PressingPosition : MonoBehaviour
    {
        private bool _pressingInZone = false;

        public bool PressingInZone { get => _pressingInZone; }

        private void OnMouseEnter()
        {
            _pressingInZone = true;
        }

        private void OnMouseExit()
        {
            _pressingInZone = false;
        }
    }
}
