using UnityEngine;
using UnityEngine.InputSystem;

public class GameInputs : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
    /*
    public bool GetWASDMode()
    {

        Vector2 Mode = playerInputActions.Player.
        return Mode;
    }
    */
}
