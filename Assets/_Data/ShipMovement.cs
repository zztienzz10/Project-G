using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected Vector3 worldPosition;
    [SerializeField] protected float Speed = 0.1f;
    protected private void FixedUpdate()
    {
        this.worldPosition = InputManager.Instance.MouseWorldPos;
        this.worldPosition.z = 0;
        Vector3 newPos = Vector3.Lerp(transform.parent.position, worldPosition, this.Speed);
        transform.parent.position = newPos;
    }
}
