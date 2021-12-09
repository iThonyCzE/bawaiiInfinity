using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float velocidadJugador = 3f;
    public float fuerzaSalto = 5;
    public bool tocaPiso = true;
    public Rigidbody rb;
    
    public int cantidadEstrellas = 0;
    public Text txtCantidadEstrellas;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

       moveMobile();
       //movePc();
       txtCantidadEstrellas.text = cantidadEstrellas+ "";
        
    }


    public void movePc(){

    //transform.Translate(Vector3.right * velocidadJugador * Time.deltaTime);

       // GIRAR IZQUIERDA | PRESIONANDO A
        if (Input.GetKey(KeyCode.A))
        {
           transform.Translate(Vector3.left * velocidadJugador  * Time.deltaTime) ;
          
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            
           transform.Translate(Vector3.right * +velocidadJugador * Time.deltaTime);
           
        }

        //SALTAR PRESIONANDO ESPACIO  
        if (Input.GetButton("Jump") && tocaPiso)
        {
            rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            tocaPiso = false;
        }
    

    }


    public void moveMobile(){
          transform.Translate(Vector3.right * +velocidadJugador * Time.deltaTime);

            if (Input.GetButton("Jump") && tocaPiso){

            rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            tocaPiso = false;
            }
    }
    


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Piso")
        {
            tocaPiso = true;
        }

        if (collision.gameObject.tag == "ColorBall")
        {
            transform.position = new Vector3(3.06100011f ,1.93200004f ,0f);
       
        }



    }



}
