using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorTexture : MonoBehaviour
{
    [SerializeField] private float conveyorSpeed;
    [SerializeField] private Material conveyorMaterial;

    void FixedUpdate()
    {
        ConveyorShiftTexture();
    }

    private void ConveyorShiftTexture()
    {
        conveyorMaterial.mainTextureOffset = new Vector2 (Time.time * conveyorSpeed * Time.deltaTime, 0f);
    }
}
