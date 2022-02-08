using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    public float baslangicbekleme;
    public float olusturmabekleme;
    public float dongubekleme;
    public Text text;
    public Text OyunBittiText;
    public Text YenidenBaslaText;
    int score;
    bool oyunBittiKontrol = false;
    bool yenidenBaslatmaKontrol = false;
    void Start()
    {
        
        score = 0;
        text.text = "score = " + score;
        StartCoroutine (olustur());
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R) && yenidenBaslatmaKontrol)
        {
            SceneManager.LoadScene("SampleScene");

        }



    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(baslangicbekleme);
        while(true)
        {
            for(int i= 0;i<10;i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(olusturmabekleme);
            }

            if (oyunBittiKontrol == false)
            {
                YenidenBaslaText.text = "Yeniden Başlatmak İçin R Tuşuna Basınız";
                yenidenBaslatmaKontrol = true;
                break;
                yield return new WaitForSeconds(dongubekleme);

            }
        }
        }

    public void scorearttır(int gelenScore)
    {
        score += gelenScore;
        text.text = "score = " + score;
        Debug.Log(score);

    }


    public void oyunBitti()
    {
        OyunBittiText.text = "GAME OVER";
        oyunBittiKontrol = false;

    }


    

}
