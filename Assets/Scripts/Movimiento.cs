using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(Transform))]
public class Movimiento : MonoBehaviour
{
    private Transform _transform;

    [SerializeField]
    private float _speed = 10;

    void Awake()
    {
        print("AWAKE");
    }

    void Start()
    {
        Debug.Log("START");
        // NOTAS:
        // - getcomponent es lento, hazlo la menor cantidad de veces posible
        // - con transform ya tenemos referencia (ahorita lo vemos)
        // - esta operación puede regresar nulo
        _transform = GetComponent<Transform>();
        
        // si tienes require esto ya no es necesario
        Assert.IsNotNull(_transform, "ES NECESARIO PARA MOVIMIENTO TENER UN TRANSFORM");
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Z))
        {
            print("KEY DOWN: Z");
        }

        if(Input.GetKey(KeyCode.Z))
        {
            print("KEY: Z");
        }

        if(Input.GetKeyUp(KeyCode.Z))
        {
            print("KEY UP: Z");
        }

        if(Input.GetMouseButtonDown(0))
        {
            print("MOUSE BUTTON DOWN");
        }

        if(Input.GetMouseButton(0))
        {
            print("MOUSE BUTTON");
        }

        if(Input.GetMouseButtonUp(0))
        {
            print("MOUSE BUTTON UP");
        }
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Jump")){
            print("JUMP");
        }

        transform.Translate(_speed * Time.deltaTime, 0, 0, Space.World);
    }

    void FixedUpdate()
    {
        //Debug.LogError("FIXED UPDATE");
    }

    void LateUpdate()
    {
        //print("LATE UPDATE");
    }
}
