using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class TurretPoint : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 aimPos;
    private Vector2 mousePos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = Camera.main;
    }

    void OnLook(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            mousePos = ctx.ReadValue<Vector2>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        aimPos = mainCam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y));
        transform.LookAt(aimPos); //SHOULD take the game object and sets its rotation to match world point
    }
}
