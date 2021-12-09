using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrellas : MonoBehaviour
{

    public float velocidadRotacion = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once p er frame
    void Update()
    {
        transform.Rotate(0f, -velocidadRotacion * Time.deltaTime, 0f);
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("COLISION");

            GameObject player = GameObject.Find("Player");
            playerController PlayerController = player.GetComponent<playerController>();
            PlayerController.cantidadEstrellas = PlayerController.cantidadEstrellas + 1;
            

        }




    }

}
