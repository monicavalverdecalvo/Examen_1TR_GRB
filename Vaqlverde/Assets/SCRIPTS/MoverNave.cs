using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Método para mover la nave con el joystick
        MoverNave();
    }

    void MoverNave()
    {

        //aqui asignamos el desplazamiento en horizontal
        float desplX = Input.GetAxis("Horizontal");
        //mover en el eje horizontal     
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        //aqui asignamos el desplazamiento a los controles del mando/teclado vertical
        float desplY = Input.GetAxis("Vertical");
        //Esto es para mover la nave de arriba 
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
    }

}
