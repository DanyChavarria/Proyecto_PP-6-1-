using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBlob : MonoBehaviour
{

    public float cronometro;

    public int rutina;
    public Quaternion angulo;
    public int eleccionDeGrado;
    public int velocidad;
    
    public List<int> gradosRandom;

    public void Comportamiento_Enemigo()
    {
        
        cronometro += 1 * Time.deltaTime;

        if(cronometro >=1)
        {
            eleccionDeGrado = Random.Range(0,360);
            angulo = Quaternion.Euler(0, eleccionDeGrado, 0);

            cronometro = 0;
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        cronometro = 0;
        velocidad = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Comportamiento_Enemigo();
    }
}
