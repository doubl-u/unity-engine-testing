using Unity.VisualScripting;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] private GameInputs gameInputs;

    private PlayerAnimator animator;
    private Vector3 movementDirection;
    private bool isWalking;
    private float movemnetSpeed = 7f;

    void Update()
    {
        MovePlayer();
        //DetectAhead();
    }
    private void MovePlayer()
    {

        Vector2 inputVector = gameInputs.GetMovementVectorNormalized();
        movementDirection = new Vector3(inputVector.x, 0, inputVector.y);
        transform.position += movementDirection * Time.deltaTime * movemnetSpeed;

        if (inputVector != Vector2.zero)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        rotateplayer();
    }
    private void DetectAhead()
    {
        Vector3 boxCastHalfSize = new Vector3(100, 100, 100);
        bool castHitBool = Physics.BoxCast(transform.position, boxCastHalfSize, Vector3.forward);
        if (castHitBool)
        {
            Debug.Log(castHitBool);
        }
        else
        {
            Debug.Log(castHitBool);
        }
    }
    private void rotateplayer()
    {
        float rotateSpeed = Time.deltaTime * 10f;
        transform.forward = Vector3.Slerp(transform.forward, movementDirection, rotateSpeed);
    }
    public bool IsWalking()
    {
        return isWalking;
    }
}

// when k pressed > switch WASD function from movement to action buttons
// 