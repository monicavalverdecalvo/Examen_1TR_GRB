using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNave : MonoBehaviour
{
    //Declaramos la velocidad de la nave fuera
    public float speed;

    //Capturo el texto del UI que indicará la distancia recorrida
    [SerializeField] Text TextTiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Método para mover la nave con el joystick
        SpaceshipMove();

        //Corrutina que hace cambiar el texto de tiempo
        IEnumerator Tiempo()
        {
            //Bucle infinito que suma 10 en cada ciclo
            //El segundo parámetro está vacío, por eso es infinito
            for (int n = 0; ; n++)
            {
                //Cambio el texto que aparece en pantalla
                TextTiempo.text = "Tiempo transcurrido: " + n * speed;

                //cada ciclo aumenta la velocidad
                if (speed < 30)
                {
                    speed = speed + 0.1f;
                }

                //Ejecuto cada ciclo esperando 1 segundo
                yield return new WaitForSeconds(0.25f);


            }

    void SpaceshipMove()
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
