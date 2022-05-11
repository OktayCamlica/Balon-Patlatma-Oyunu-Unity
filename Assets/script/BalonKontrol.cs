using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrolcu oyunKontrolcuScripti;

    private void Start()
    {
        oyunKontrolcuScripti = GameObject.Find("script").GetComponent<OyunKontrolcu>();
    }
    private void OnMouseDown()
    {
    GameObject go=    Instantiate(patlama, transform.position, transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        oyunKontrolcuScripti.BalonEkle();
    }
}
