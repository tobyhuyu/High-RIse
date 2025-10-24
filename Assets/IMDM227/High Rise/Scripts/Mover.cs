using UnityEngine.InputSystem;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(Time.deltaTime * new Vector3(-1, 0, 0));
            transform.Rotate(Time.deltaTime * new Vector3(0, -60, 0));
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(Time.deltaTime * new Vector3(1, 0, 0));
            transform.Rotate(Time.deltaTime * new Vector3(0, 60, 0));
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Time.deltaTime * new Vector3(0, 0, 1));
        }
        
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Time.deltaTime * new Vector3(0,0,-1));
        }
    }
}
