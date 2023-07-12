using UnityEngine;

sealed public class HashAnimations
{
    public int Walk { get => Animator.StringToHash("Walk"); }
    public int Death { get => Animator.StringToHash("Death"); }
    public int Win { get => Animator.StringToHash("Win"); }
}
