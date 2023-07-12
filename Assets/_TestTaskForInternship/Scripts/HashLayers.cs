using UnityEngine;

namespace GameForInternship
{
    sealed public class HashLayers
    {
        public int Player { get => LayerMask.NameToLayer("Player"); }
        public int Obstacle { get => LayerMask.NameToLayer("Obstacle"); }
    }
}
