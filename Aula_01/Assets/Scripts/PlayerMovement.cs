using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    // Public variable to set the speed of the gameobject
    public float movement = 0f;

    private float minPosition = -3.5f;
    private float maxPosition = 3.5f;

    public InputActionProperty movementAction;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        MoveZAxis();
    }
    
    public void MoveZAxis()
    {
        movement = movementAction.action.ReadValue<float>() / 10;
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z + movement, minPosition, maxPosition));
    }
   

}
