using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    // Величина смещения. -1.0 = максимально влево,
    // +1.0 = максимально вправо
    private float _sidewaysMotion = 0.0f;


    public float sidewaysMotion 
    {
        get 
        {
            return _sidewaysMotion;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 accel = Input.acceleration; // Vector3 в книге

        _sidewaysMotion = accel.x;
    }
}
