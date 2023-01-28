using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyHand : MonoBehaviour
{
    [SerializeField] private float offsetZ;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Vector3 centerPosition;
    private Vector3 myPosition;
    private Vector3 screenMousePosition;
    private Vector3 worldMousePosition;

    void FixedUpdate()
    {
        MoveHandOnMouse();
    }

    private void MoveHandOnMouse()
    {
        transform.position = myPosition;
        screenMousePosition = Input.mousePosition;
        screenMousePosition.z = Camera.main.nearClipPlane;
        worldMousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition) - centerPosition;
        myPosition.z = offsetZ;
        myPosition.x = worldMousePosition.x * offsetX;
        myPosition.y = worldMousePosition.y * offsetY;
    }
}
