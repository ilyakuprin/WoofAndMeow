using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(LineMovement))]
    public class AnimationWalkPlayback : AnimationPlayback
    {
        private LineMovement _lineMovement;

        protected override void Awake()
        {
            base.Awake();

            _lineMovement = GetComponent<LineMovement>();
        }

        private void OnStartAnimationWalk()
        {
            GetAnimator.SetTrigger(_hashAnimations.Walk);
        }

        private void OnEnable()
        {
            _lineMovement.Moved += OnStartAnimationWalk;
        }

        private void OnDisable()
        {
            _lineMovement.Moved -= OnStartAnimationWalk;
        }
    }
}
