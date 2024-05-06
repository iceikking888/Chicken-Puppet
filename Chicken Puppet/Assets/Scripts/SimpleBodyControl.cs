using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class SimpleBodyControl : MonoBehaviour
{
    // Start is called before the first frame update

    // GameObjects of Interest
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject head;
    [SerializeField] private GameObject leftHand;
    [SerializeField] private GameObject rightHand;
    [SerializeField] private GameObject offset;

    // Offsets
    [SerializeField] private Vector3 positionOffset;
    [SerializeField] private Vector3 rotationalOffset;


    void Start()
    {
        offset.transform.localPosition = positionOffset;
        offset.transform.localRotation = Quaternion.Euler(rotationalOffset);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DebugHead(InputAction.CallbackContext context)
    {
        Debug.Log("Head");
        Vector3 input = context.ReadValue<Vector3>();
        Debug.Log(input);
    }

    public void SetHeadOrientation(InputAction.CallbackContext context)
    {
        Debug.Log("Head");
        Quaternion inputQ = context.ReadValue<Quaternion>();
        Debug.Log(inputQ);
        head.transform.rotation = inputQ;
    }

    public void SetPlayerPose(InputAction.CallbackContext context)
    {
        // Vector3 direction = context.ReadValue<Vector3>();
        // player.transform.position += direction;

    }

    public void SetLeftHandPose(InputAction.CallbackContext context)
    {
        // Debug.Log("Left");
        Vector3 inputVector = context.ReadValue<Vector3>();
        leftHand.transform.localPosition = inputVector + new Vector3(0,1f, 0);

    }

    public void SetRightHandPose(InputAction.CallbackContext context)
    {
        // Debug.Log("Right");
        Vector3 inputVector = context.ReadValue<Vector3>();
        rightHand.transform.localPosition = inputVector + new Vector3(0,1f, 0);
    }
}
