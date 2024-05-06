using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class SimpleBodyControl : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject head;
    [SerializeField] private GameObject leftHand;
    [SerializeField] private GameObject rightHand;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHeadOrientation(InputAction.CallbackContext context)
    {
        Debug.Log("Head");
        Quaternion inputVector = context.ReadValue<Quaternion>();
        head.transform.rotation = inputVector;
    }

    public void SetPlayerPose(InputAction.CallbackContext context)
    {
        // Vector3 direction = context.ReadValue<Vector3>();
        // player.transform.position += direction;

    }

    public void SetLeftHandPose(InputAction.CallbackContext context)
    {
        Debug.Log("Left");
        Vector3 inputVector = context.ReadValue<Vector3>();
        leftHand.transform.position = inputVector;

    }

    public void SetRightHandPose(InputAction.CallbackContext context)
    {
        Debug.Log("Right");
        Vector3 inputVector = context.ReadValue<Vector3>();
        rightHand.transform.position = inputVector;
    }
}
