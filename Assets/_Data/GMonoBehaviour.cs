using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadComponents();
    }

    protected virtual void Awake()
    {
        this.LoadComponents() ;
    }

    protected virtual void LoadComponents()
    {
        /* 4 Override */
    }

    protected virtual void Start()
    {
        /* 4 Override */
    }

    
}
