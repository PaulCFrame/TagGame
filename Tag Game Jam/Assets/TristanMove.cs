using UnityEngine;
using System.Collections;

public class TristanMove : MonoBehaviour
{

    public float walkSpeed;
    Rigidbody playerRigidBody;
    Transform playerTransform;
    public Transform playerPivot;
    Vector3 inputMovement;

    // Use this for initialization
    void Awake()
    {
        playerRigidBody = this.GetComponent<Rigidbody>(); //just caching the rigidbody for speed reasons, rather than calling rigidbody.velocity later, which is much slower.
        playerTransform = this.transform; //same with the transform, caching it for performance reasons
    }

    // Update is called once per frame
    void Update()
    {

        playerPivot.position = new Vector3(playerPivot.position.x, playerTransform.position.y, playerPivot.position.z); //make the pivot object the same y height as the player, so it doesn't stay down on the ground

        playerPivot.LookAt(playerTransform, Vector3.up); //make the pivot look at the player

        Quaternion pivotRotation = playerPivot.localRotation; //get the rotation of the pivot, so that we can adjust the inputs below to be relative to that

        inputMovement = Vector3.zero; //resetting the inputMovement vector which will hold all our input information


        if (Input.GetKey(KeyCode.L))
        {
            inputMovement += pivotRotation * Vector3.right;
        }
        if (Input.GetKey(KeyCode.K))
        {
            inputMovement += pivotRotation * Vector3.left;
        }

        inputMovement = inputMovement.normalized * walkSpeed; //normalising the inputMovement vector so it's not too large and then we can cleanly multiply it by whatever walk speed we desire

        playerRigidBody.velocity = new Vector3(inputMovement.x, playerRigidBody.velocity.y, inputMovement.z); //apply the inputMovement vector to the players velocity, but not on the y axis otherwise it will overwrite gravity.
        playerTransform.localRotation = pivotRotation; //keep the player rotated the same as the pivot so it doesn't start walking backwards

    }
}