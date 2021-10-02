using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 1.0f;
    public float RotationSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //deja el mouse
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //recibe si esta presionada la tecla asignada a 'Horizontal' y 'Vertical'
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
       
        //recibe si esta presionada la tecla asignada a 'Horizontal' y 'Vertical'
        float rotationY = Input.GetAxis("Mouse X");
        float rotationX = Input.GetAxis("Mouse Y");

        //Mueve la camara
        transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * Speed);

        //Rota la camara
        transform.Rotate(new Vector4(0, rotationY, 0) * Time.deltaTime * RotationSpeed, Space.World);
        transform.Rotate(new Vector4(-rotationX, 0, 0) * Time.deltaTime * RotationSpeed, Space.Self);

    }
}
