using UnityEngine;

namespace GameForInternship
{
    [RequireComponent(typeof(Animator))]
    public abstract class AnimationPlayback : MonoBehaviour
    {
        protected readonly HashAnimations _hashAnimations = new HashAnimations();
        private Animator _animator;

        protected Animator GetAnimator { get => _animator; }

        protected virtual void Awake()
        {
            _animator = GetComponent<Animator>();
        }
    }
}
