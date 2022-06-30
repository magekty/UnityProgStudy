using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;

    public void Kick()
    {
        animator.Play("Kicking");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
