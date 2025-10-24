using System;
using UnityEngine;

public class GoingUp : MonoBehaviour
{
    private Boolean goUp = false;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (cube.transform.position.x <= .5 && cube.transform.position.x >= -.5
         && cube.transform.position.z <= .5 && cube.transform.position.z >= -.5)
        {
            goUp = true;
            
        }
        
        if (goUp == true)
        {
            Up();
        }
    }
    
    void Up()
    {
        if (cube.transform.position.y < 10)
        {
            cube.transform.Translate(Time.deltaTime * new Vector3(0, 1, 0));
        }
        else
        {
            goUp = false;
        }
    }
}
