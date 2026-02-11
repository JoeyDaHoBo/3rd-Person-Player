using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private CharacterController _characterController;

    private float _rotationY;

    public float MoveSpeed = 10f, RotationSpeed = 5f;

    
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void Move(Vector2 movementVector)
    {
        
        Vector3 move = transform.forward * movementVector.y + transform.right * movementVector.x;
        //Setting Movement based off the speed and game time
        move = move * MoveSpeed * Time.deltaTime;
        _characterController.Move(move);
        
    }

    public void Rotate(Vector2 rotationVector)
    {
        _rotationY += rotationVector.x * RotationSpeed *Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0,_rotationY, 0);
    }



    //ending bracket for class
}
