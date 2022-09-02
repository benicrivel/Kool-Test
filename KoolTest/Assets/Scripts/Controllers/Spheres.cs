using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour
{
    public Animator anim;

    public void PlayPop()
    {
        anim.SetTrigger("Start");
    }

    public void DeleteGO()
    {
        Destroy(this);
    }
}
