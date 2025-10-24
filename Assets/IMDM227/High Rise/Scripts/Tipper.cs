using UnityEngine;
using UnityEngine.InputSystem;

public class Tipper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.uKey.isPressed)
        {
            transform.Rotate(Time.deltaTime * new Vector3(-60, 0, 0));
        }

        if (Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(Time.deltaTime * new Vector3(60, 0, 0));
        }
    }
}
