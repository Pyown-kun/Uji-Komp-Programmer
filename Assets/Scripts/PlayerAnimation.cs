using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;

    public void Idle()
    {
        animator.SetBool("idle", true);
        animator.SetBool("walkLeft", false);
        animator.SetBool("walkRight", false);
    }
    
    public void Left()
    {
        animator.SetBool("idle", false);
        animator.SetBool("walkLeft", true);
        animator.SetBool("walkRight", false);
    }
    
    public void Right()
    {
        animator.SetBool("idle", false);
        animator.SetBool("walkLeft", false);
        animator.SetBool("walkRight", true);
    }
    
    public void Victory()
    {
        animator.SetBool("idle", false);
        animator.SetBool("walkLeft", false);
        animator.SetBool("walkRight", true);
    }
}
