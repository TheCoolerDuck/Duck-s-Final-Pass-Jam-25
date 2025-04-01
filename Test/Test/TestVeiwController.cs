using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVeiwController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of player movement
    public float mouseSensitivity = 100f; // Sensitivity of mouse movement

    private float rotationX = 0f; // Vertical camera rotation
    private float rotationY = 0f; // Horizontal camera rotation

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Handle mouse movement (camera rotation)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationY += mouseX;

        // Clamp vertical rotation to avoid flipping over
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        // Apply camera rotation
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);

        // Handle WASD movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        float moveY = (Input.GetKey(KeyCode.Q) ? -1 : 0) + (Input.GetKey(KeyCode.E) ? 1 : 0);

        Vector3 move = transform.right * moveX + transform.forward * moveZ + transform.up * moveY;

        // Apply movement without gravity
        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
