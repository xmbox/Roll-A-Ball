using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour {

    //degiskeni burada olusturuyoruz ki buradan erisilebilsin
    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    //panelden toplanilacak bonus sayisini gircegimiz icin public tanimladik
    public int toplamBonus;

    public Text SayacText;
    public Text FinishText;

	void Start () {

        fizik = GetComponent<Rigidbody>();
	}

    // Fiziksel islemlerde FixedUpdate kullancaz
    void FixedUpdate () {

        //mousun sag ve sol tiklarini ayarlayip yonleri belirliyoruz
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay,0,dikey);

        fizik.AddForce(vec*hiz);
		
	}

    // Nesneye dokunma işlevi OnTriggerEnter
    //OnTriggerEnter - bir defa dokunur dokunmaz teması belirtiyor
    //OnTriggerStay - Temas olduğu sürece bizi uyarıyor
    //OnTriggerExit - Temastan çıkıldıktan sonra yazdırıyor
    private void OnTriggerEnter(Collider other)
    {
        //Destroy kaldırma- silme
        //Destroy(other.gameObject);

        if (other.gameObject.tag == "Bonus")
        {
            // Destroy(other.gameObject);

            // Bu kodla aktifliğini kapatıypruz
            other.gameObject.SetActive(false);
            sayac++;
            SayacText.text = "Sayac = " + sayac;

            if (sayac==toplamBonus)
            {
                FinishText.text = "GAME OVER";
            }
        }
    }

}
