using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(LineMovement))]
    public class AnimationVictoryPlayback : AnimationPlayback
    {
        private LineMovement _lineMovement;

        protected override void Awake()
        {
            base.Awake();

            _lineMovement = GetComponent<LineMovement>();
        }

        private void OnStartAnimationVictory()
        {
            GetAnimator.SetTrigger(_hashAnimations.Win);
        }

        private void OnEnable()
        {
            _lineMovement.Won += OnStartAnimationVictory;
        }

        private void OnDisable()
        {
            _lineMovement.Won -= OnStartAnimationVictory;
        }
    }
}
