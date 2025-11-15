using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.InputSystem;

public class ThirdPersonCamControls : MonoBehaviour
{
    public InputActionAsset InputActions;
    private InputAction p_Look;
    private Vector2 p_LookAmt;

    public CinemachineCamera cam;
    private CinemachineOrbitalFollow orbital;
}
