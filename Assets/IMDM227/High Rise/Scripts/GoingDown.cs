using System;
using UnityEngine;

public class GoingDown : MonoBehaviour
{
    private Boolean goDown = false;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cube.transform.position.x <= 5.5 && cube.transform.position.x >= 4.5
         && cube.transform.position.z <= -4.5 && cube.transform.position.z >= -5.5)
        {
            goDown = true;

        }

        if (goDown == true)
        {
            Down();
        }
    }
    void Down()
    {
        if (cube.transform.position.y > 1)
        {
            cube.transform.Translate(Time.deltaTime * new Vector3(0, -1, 0));
        }
        else
        {
            goDown = false;
        }
    }
}
