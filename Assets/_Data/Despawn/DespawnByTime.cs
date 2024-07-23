using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
    // chua xong
    protected override bool CanDespawn()
    {
        return false;
    }
}
