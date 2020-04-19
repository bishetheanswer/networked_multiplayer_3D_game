using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputMovement();
    }

    private void InputMovement() {
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W)) {
            moveZ = -1f;
        }
        
        if (Input.GetKey(KeyCode.S)) {
            moveZ = 1f;
        }

        if (Input.GetKey(KeyCode.A)) {
            moveX = 1f;
        }

        if (Input.GetKey(KeyCode.D)) {
            moveX = -1f;
        }
        
        bool isIdle = moveX == 0 && moveZ == 0;
        if (isIdle) {
            //funcion de animacion idle
        } else {
            Vector3 moveDir = new Vector3(moveX, 0, moveZ).normalized;
            //funcion para animacion andar(parametro direccion)
            transform.position += moveDir * speed * Time.deltaTime;
        }
    }
}
