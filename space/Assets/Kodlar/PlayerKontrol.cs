using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKontrol : MonoBehaviour
{
    Rigidbody fizik;
    float horizontal = 0;
    float Vertical = 0;
    public float Karakterhızı;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float egim;
    float Ateszamani = 0;
    public float AtesGecenSure;
    public GameObject Kursun;
    public Transform Kursunneredencıksın;
    AudioSource audioc;
    Vector3 vec;


    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        audioc = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time>Ateszamani)
        {
            Ateszamani = Time.time + AtesGecenSure;
            Instantiate(Kursun, Kursunneredencıksın.position, Quaternion.identity);
            audioc.Play();
        }










    }
  
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        vec = new Vector3 (horizontal,0,Vertical);
        fizik.velocity = vec*Karakterhızı;

        fizik.position = new Vector3(
            Mathf.Clamp(fizik.position.x, minX, maxX),
        0.0f,
           Mathf.Clamp(fizik.position.z, minZ, maxZ)
           );


        fizik.rotation = Quaternion.Euler (0, 0, fizik.velocity.x*-egim);
       
    }
}
