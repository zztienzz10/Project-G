using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected Vector3 targetPosition;
    [SerializeField] protected float Speed = 0.1f;
    void FixedUpdate()
    {
        this.GetTargetPosition();
        this.LookAtTarget();
        this.Moving();
    }

    protected virtual void GetTargetPosition()
    {
        this.targetPosition = InputManager.Instance.MouseWorldPos;  
        this.targetPosition.z = 0;
    }
    protected virtual void LookAtTarget()
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);
    }
    protected virtual void Moving() {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPosition, this.Speed);
        transform.parent.position = newPos;
    }

}
