namespace GameForInternship
{
    public class AnimationDeathPlayback : AnimationPlayback
    {
        public void StartAnimationDeath()
        {
            GetAnimator.SetTrigger(_hashAnimations.Death);
        }
    }
}
