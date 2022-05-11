using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrolcu : MonoBehaviour
{
    public Text zamanText, patlayanBalonText;
    public GameObject patlama;
   public  float zamanSayaci = 60f;
    int patlayanBalon = 0;
    
   
    void Start()
    {
        patlayanBalonText.text = "balon" + patlayanBalon;
    }

   
    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Zaman : " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i=0; i<go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }


    }
    public void BalonEkle()
    {
        patlayanBalon += 1;
        patlayanBalonText.text = "Balon : " + patlayanBalon;


    }
}
