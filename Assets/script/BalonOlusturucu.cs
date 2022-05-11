using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi=1f;
    float zamanSayaci = 0f;
    OyunKontrolcu okScript;
    void Start()
    {
        okScript = this.gameObject.GetComponent<OyunKontrolcu>();
    }

   
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0 && okScript.zamanSayaci>0)
        {
            GameObject go= Instantiate(balon, new Vector3(Random.Range(-3.14f, 2.26f), -6f, 0), Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0 , Random.Range(60f, 50f), 0) );
            zamanSayaci = balonOlusturmaSuresi;
        }
    }
}
