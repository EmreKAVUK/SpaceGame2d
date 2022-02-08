using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemaslaYokol : MonoBehaviour
{
    public GameObject Patlama;
    public GameObject PlayerPatlama;
    GameObject oyunkontrol;
    oyunkontrol kontrol;

    void Start()
    {
        oyunkontrol = GameObject.FindGameObjectWithTag ("oyunkontrol");
        kontrol = oyunkontrol.GetComponent<oyunkontrol>();


    }














    void OnTriggerEnter(Collider col)
    {
        if(col.tag!="Sınır")
        {

            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(Patlama, transform.position, transform.rotation);
            kontrol.scorearttır(10);

        }



       if(col.tag == "Player")
        {
            Instantiate(PlayerPatlama, col.transform.position, col.transform.rotation);
            kontrol.oyunBitti();
        }




    }
}