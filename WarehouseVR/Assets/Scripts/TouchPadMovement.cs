using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class TouchPadMovement : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;

    void Update()
    {
        Vector3 direction = Player.instance.hmdTransform.TransformVector(input.axis.x, 0, input.axis.y);
        transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
    }
}
