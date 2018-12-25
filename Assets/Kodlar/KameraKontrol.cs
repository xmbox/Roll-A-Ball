using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour {

    //topuma ulasabilmek icin public tanimlayip unity panelinden topu tasidik.
    public GameObject top;

    //aradaki mesafeyi bulmak icin degisken
    Vector3 mesafe;

	void Start () {

        //aradaki mesafeyi bulmak icin degisken kameramin pozisyonundan topunkini cikariyoruz.
        mesafe = transform.position - top.transform.position;
		
	}
	

	void LateUpdate () {

        transform.position = top.transform.position + mesafe;
		
	}
}
