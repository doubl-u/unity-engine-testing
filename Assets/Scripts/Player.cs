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
    }
    private void MovePlayer()
    {

        Vector2 inputVector = gameInputs.GetMovementVectorNormalized();
        movementDirection = new Vector3(inputVector.x,0,inputVector.y);
        transform.position += movementDirection * Time.deltaTime * movemnetSpeed;
        
        if(inputVector != Vector2.zero)
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
        Vector3 boxCastSize = new Vector3(1,1,1);
        bool castHitBool = Physics.BoxCast(transform.position,boxCastSize,Vector3.zero);
        if(castHitBool)
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
