using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    string[] yazilar = {
        "Aramıza hoş geldin", 
        "Barınağı açabilmek için tüm görevleri tamamla",
        "Hazırsan Devam Et butonuna tıkla",
        "İstenilen şekilleri sağdaki ve aşağıdaki kaydırma butonları ile oluşturmaya çalış",
        "Şimdi bir kare oluşturmalısın", // 4
        "Kareyi oluşturmayı başardın haydi devam et ve bir dikdörtgen oluştur",
        "Son şeklimiz üçgen\n",
        "Başardın!",
        "Kolay bir görevle devam edelim", // 8
        "Şekilleri isimlerine göre duvara as",
        "Hatırlatma: Şekil isimlerini kenar sayıları belirler.",// 10
        "Bravo! Devam etmek için butona tıkla",
        "Şekilleri isimlerine göre duvara as",
        "Karenin her kenarı eşitken dikdörtgenin sadece karşılıklı kenarları eşit",
        "Aferin",
        "Şu ana kadar harika gidiyorsun", // 15
        "Ekrana bazı cisimlerin açılımlarını görüyyorsun. Butonlara basarak açılımı verilen şekilleri elde etmek için devam et",
        "İlk cismimizle başlayalım, elimizde 2 adet kare ve 4 adet dikdörtgen karton var. Haydi dikdörtgenler prizması yap",
        "Bravo şimdi üçgen prizmanın açılımını görmek için butona bas.",
        "Bravo üçgen prizmayı da biliyorsun artık. Şimdi bir sonraki etkinliğe geçelim", //19

        "Ekranda gördüğün kartonları seçerek bir küp oluşturmanı istiyorum",
        "Unutma, seçtiğin kartonları kapatında buna benzeyecek, Haydi başla!", //21
        "Çok iyi gidiyorsun, böyle devam et.",

        "Hadi dışarı çıkıp orada devam edelim",
        "Şimdi günlük hayatta kullandığımız birkaç şekil göreceksin\n", //24
        "Bakalım isimleri doğru seçebilecek misin",
        "Trafik Levhası",
        "Resim Tablosu", // 27
        "Süt Kutusu ", // Kare prizma 2 kare yüze sahip
        "Bal Peteği. (Bal peteğini oluşturan parçaların köşelerini say)",
        "Açık Zarf. (Kapalı zarf bir dörtgen, açılınca bir kenar eklemiş oluyoruz\n)",
        "Parti Şapkası\n", //      Üçgen prizmaların iki adet üçgen yüzü bulunur 
        "Mükemmel, hayvanları gerçekten de seviyor olmasın", 
        "Başardın artık barınakta gönlünce eğlenebilirsin!",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        
    };



    public Animator anim;
    int sayfa = 0;
    public TMP_Text yazi;
    public GameObject[] ogeler;
    public SpriteRenderer ust_kisim;
    public GameObject[] sorular;
    public Toggle[] cevaplar;
    public Slider slider;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Slider slider5;
    public Slider slider6;
    public GameObject[] kenarlar;
    int x = 0;
    int x2 = 0;
    int x3 = 0;
    public TMP_Text[] konumx;
    public TMP_Text[] konumy;
    public GameObject core_button;
    public Toggle[] kup;
    public Animator siyah;
    public Animator sari;
    public Animator sari2;
    public Animator mor;
    public Animator mor2;
    public Animator bir;
    public Animator iki;
    public Animator uc;
    public Animator dort;
    public Animator bes;

    int act = 0; 

    // Start is called before the first frame update
    void Start()
    {
        anim = anim.GetComponent<Animator>();
        yazi = yazi.GetComponent<TMP_Text>();
        yazi.text = yazilar[0];
        anim.Play("karakter_selam");
        ust_kisim = ust_kisim.GetComponent<SpriteRenderer>();
        ust_kisim.color = Color.grey;
        slider.value = -2;
        slider2.value = 2;
        slider3.value = -2;
        slider4.value = 2;

        siyah = siyah.GetComponent<Animator>();
        sari = sari.GetComponent<Animator>();
        sari2 = sari2.GetComponent<Animator>();
        mor = mor.GetComponent<Animator>();
        mor2 = mor2.GetComponent<Animator>();

        bir = bir.GetComponent<Animator>();
        iki = iki.GetComponent<Animator>();
        uc = uc.GetComponent<Animator>();
        dort = dort.GetComponent<Animator>();
        bes = bes.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //********************** - x - *********************************************
        if (x == 0)
        {
            kenarlar[0].transform.position = new Vector3(slider.value, slider2.value, -0.03481258f);
            konumx[0].text = Mathf.RoundToInt(kenarlar[0].transform.position.x).ToString();
            konumy[0].text = Mathf.RoundToInt(kenarlar[0].transform.position.y).ToString();
            
        }
        if (x == 1)
        {
            kenarlar[1].transform.position = new Vector3(slider.value, slider2.value, -0.03481258f);
            konumx[1].text = Mathf.RoundToInt(kenarlar[1].transform.position.x).ToString();
            konumy[1].text = Mathf.RoundToInt(kenarlar[1].transform.position.y).ToString();
        }
        if (x == 2)
        {
            kenarlar[2].transform.position = new Vector3(slider.value, slider2.value, -0.03481258f);
            konumx[2].text = Mathf.RoundToInt(kenarlar[2].transform.position.x).ToString();
            konumy[2].text = Mathf.RoundToInt(kenarlar[2].transform.position.y).ToString();
        }
        if (x == 3)
        {
            kenarlar[3].transform.position = new Vector3(slider.value, slider2.value, -0.03481258f);
            konumx[3].text = Mathf.RoundToInt(kenarlar[3].transform.position.x).ToString();
            konumy[3].text = Mathf.RoundToInt(kenarlar[3].transform.position.y).ToString();
        }
        if (x > 3)
        {
            x = 0;
        }
        if (x < 0)
        {
            x = 3;
        }
        //********************** - x2 - *********************************************
        if (x2 > 3)
        {
            x2 = 0;
        }
        if (x2 < 0)
        {
            x2 = 3;
        }

        if (x2 == 0)
        {
            kenarlar[4].transform.position = new Vector3(slider3.value, slider4.value, -0.03481258f);

        }
        if (x2 == 1)
        {
            kenarlar[5].transform.position = new Vector3(slider3.value, slider4.value, -0.03481258f);
        }
        if (x2 == 2)
        {
            kenarlar[6].transform.position = new Vector3(slider3.value, slider4.value, -0.03481258f);
        }
        if (x2 == 3)
        {
            kenarlar[7].transform.position = new Vector3(slider3.value, slider4.value, -0.03481258f);
        }
        //********************** - x3 - *********************************************
        if (x3 == 0)
        {
            kenarlar[8].transform.position = new Vector3(slider5.value, slider6.value, -0.03481258f);

        }
        if (x3 == 1)
        {
            kenarlar[9].transform.position = new Vector3(slider5.value, slider6.value, -0.03481258f);
        }
        if (x3 == 2)
        {
            kenarlar[10].transform.position = new Vector3(slider5.value, slider6.value, -0.03481258f);
        }
        if (x3 > 2)
        {
            x3 = 0;
        }
        if (x3 < 0)
        {
            x3 = 2;
        }

    }

    public void devam_et()
    {
        sayfa += 1;
        yazi.text = yazilar[sayfa];
        Debug.Log(sayfa);

        if (sayfa == 4) // şekilleri çizecek
        {
            ogeler[0].SetActive(true); // kafayı açtım
            ogeler[1].SetActive(false); // ilk bg kapat
            ogeler[10].SetActive(true); // ilk soru aç
            ogeler[3].SetActive(false); //kadın kapat
            core_button.SetActive(false); // devam et i kapat
        }






        
        if (sayfa == 8) // kolay bir görevle başla 3
        {
            ogeler[0].SetActive(true); // kafayı açtım
            ogeler[8].SetActive(true); // ilk soru aç
            ust_kisim.color = Color.grey; 
        }
        
        if (sayfa == 11)
        {
            if (besgen.isinside && sekizgen.isinside && ucgen.isinside)
            {
                yazi.text = yazilar[sayfa]; // bravo devam et
                ust_kisim.color = Color.green;

            }
            else
            {
                ust_kisim.color = Color.red;
                sayfa -= 1;
                yazi.text = "Örnek: Eğer şeklin üç kenarı varsa adı üçgendir. Tekrar dene";
            }
        }
        if (sayfa == 12)
        {
            ogeler[2].SetActive(false); // ilk soru kapat
            ogeler[4].SetActive(true); // ikinci soruyu aç
            ust_kisim.color = Color.grey;
        }
        if (sayfa == 13)
        {
            ogeler[9].SetActive(true);
        }
        if (sayfa == 14)
        {
            if (kare.isinside && altıgen.isinside && dikdörtgen.isinside)
            {
                yazi.text = yazilar[sayfa]; // bravo devam et
                ust_kisim.color = Color.green;
            }
            else
            {
                ust_kisim.color = Color.red;
                sayfa -= 1;
                yazi.text = "Örnek: 6 kenarı olan şeklin adı altıgen olmalı. Tekrar dene";
            }

        }
        if (sayfa == 15)
        {
            ust_kisim.color = Color.grey;
            ogeler[4].SetActive(false);
            ogeler[16].SetActive(true);

        }
        if (sayfa == 17)
        {
            ogeler[17].SetActive(true);
            core_button.SetActive(false);

        }
        if (sayfa == 18)
        {
            ogeler[16].SetActive(false);
            ogeler[18].SetActive(true);
            core_button.SetActive(false);

        }
        if (sayfa == 19)
        {
            
            ogeler[18].SetActive(false);
            ogeler[4].SetActive(false);
            ogeler[13].SetActive(true);

        }
        
        if(sayfa == 21)
        {
            ogeler[14].SetActive(true);
        }
        if (sayfa == 22)
        {
            if (kup[0].isOn && kup[1].isOn && kup[2].isOn && kup[3].isOn)
            {
                if ((kup[4].isOn && !kup[5].isOn && !kup[6].isOn && !kup[7].isOn) || (!kup[4].isOn && kup[5].isOn && !kup[6].isOn && !kup[7].isOn) || (!kup[4].isOn && !kup[5].isOn && kup[6].isOn && !kup[7].isOn)|| (!kup[4].isOn && !kup[5].isOn && !kup[6].isOn && kup[7].isOn))
                {
                    if ((kup[8].isOn && !kup[9].isOn && !kup[10].isOn && !kup[11].isOn) || (!kup[8].isOn && kup[9].isOn && !kup[10].isOn && !kup[11].isOn) || (!kup[8].isOn && !kup[9].isOn && kup[10].isOn && !kup[11].isOn) || (!kup[8].isOn && !kup[9].isOn && !kup[10].isOn && kup[11].isOn))
                    {
                        yazi.text = yazilar[sayfa]; // bravo devam et
                        ust_kisim.color = Color.green;
                        ogeler[14].SetActive(false);
                    }
                    else
                    {
                        sayfa -= 1;
                        ust_kisim.color = Color.red;
                        yazi.text = "Küpün açık hali buna benziyor.";
                        ogeler[14].SetActive(false);
                        ogeler[15].SetActive(true);

                    }
                }
                else
                {
                    sayfa -= 1;
                    ust_kisim.color = Color.red;
                    yazi.text = "Küpün açık hali buna benziyor.";
                    ogeler[14].SetActive(false);
                    ogeler[15].SetActive(true);

                }

            }
            else
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Küpün açık hali buna benziyor.";
                ogeler[14].SetActive(false);
                ogeler[15].SetActive(true);

            }

        }
        if (sayfa == 23)
        {
            ust_kisim.color = Color.green;
        }

        
        if (sayfa == 23) // 15 di 24 oldu
        {
            ust_kisim.color = Color.grey;
            ogeler[13].SetActive(false);
            ogeler[5].SetActive(true);
        }

        if (sayfa == 24)
        {
            ogeler[5].SetActive(false);
            ogeler[6].SetActive(true);
            ogeler[7].SetActive(true);

        }
        if (sayfa == 26)
        {
            sorular[0].SetActive(true);
        }


        if(sayfa == 27)
        {
            if (cevaplar[0].isOn) // toggle doğruysa
            {

                yazi.text = yazilar[sayfa];
                sorular[0].SetActive(false);
                sorular[1].SetActive(true);
                ust_kisim.color = Color.grey;
            }
            else if (cevaplar[1].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
            else if (cevaplar[2].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
            else
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
        } 
        if (sayfa == 28)
        {


            if (cevaplar[5].isOn) // toggle doğruysa
            {

                yazi.text = yazilar[sayfa];
                ust_kisim.color = Color.grey;
                sorular[1].SetActive(false);
                sorular[2].SetActive(true);
            }
            else if (cevaplar[4].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Karenin 4 eşit kenarı var. Bu şekilde yalnızca karşılıklı olanlar eşit";
            }
            else if (cevaplar[3].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
            else
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
        }
        if (sayfa == 29)
        {

            if (cevaplar[6].isOn) // toggle doğruysa
            {
                yazi.text = yazilar[sayfa];
                ust_kisim.color = Color.grey;
                sorular[2].SetActive(false);
                sorular[3].SetActive(true);
            }
            else if (cevaplar[7].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
            else if (cevaplar[8].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kare prizma 2 kare yüze sahip";
            }
            else
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
        }
        if (sayfa == 30)
        {

            if (cevaplar[10].isOn) // toggle doğruysa
            {
                yazi.text = yazilar[sayfa];
                ust_kisim.color = Color.grey;
                sorular[3].SetActive(false);
                sorular[4].SetActive(true);
            }
            else if (cevaplar[9].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Bal peteğini oluşturan parçaların köşelerini say\n";
            }
            else if (cevaplar[11].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Bal peteğini oluşturan parçaların köşelerini say\n";
            }
            else
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
        }
        if (sayfa == 31)
        {

            if (cevaplar[13].isOn) // toggle doğruysa
            {
                yazi.text = yazilar[sayfa];
                ust_kisim.color = Color.grey;
                sorular[4].SetActive(false);
                sorular[5].SetActive(true);
            }
            else if (cevaplar[12].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kapalı zarf bir dörtgen, açılınca bir kenar eklemiş oluyoruz\n";
            }
            else if (cevaplar[14].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kapalı zarf bir dörtgen, açılınca bir kenar eklemiş oluyoruz\n";
            }
            else
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
        }
        if (sayfa == 32)
        {

            if (cevaplar[17].isOn) // toggle doğruysa
            {
                yazi.text = yazilar[sayfa];
                ust_kisim.color = Color.grey;
                sorular[5].SetActive(false);
                sorular[6].SetActive(true);
            }
            else if (cevaplar[15].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Görsel düğün davullarına benzeseydi silindir diyebilirdik\n";
            }
            else if (cevaplar[16].isOn)
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Üçgen prizmaların iki adet üçgen yüzü bulunur\n";
            }
            else
            {
                sayfa -= 1;
                ust_kisim.color = Color.red;
                yazi.text = "Kenarları saymayı unutma";
            }
        }
        if (sayfa == 33)
        {
            core_button.gameObject.SetActive(false);
            ogeler[20].SetActive(true);
        }


        }
    //********************** - x - *********************************************
    public void sonrakine_gec()
    {
        x += 1;
    }
    public void oncekine_gec()
    {
        x -= 1;
    }
    public void bitti()
    {
        if(Mathf.RoundToInt(kenarlar[0].transform.position.x) == Mathf.RoundToInt(kenarlar[2].transform.position.x) && Mathf.RoundToInt(kenarlar[1].transform.position.y) == Mathf.RoundToInt(kenarlar[3].transform.position.y))
        {
            if (Mathf.RoundToInt(kenarlar[0].transform.position.x) + Mathf.RoundToInt(kenarlar[0].transform.position.y) + Mathf.RoundToInt(kenarlar[2].transform.position.x) + Mathf.RoundToInt(kenarlar[2].transform.position.y) == Mathf.RoundToInt(kenarlar[1].transform.position.x) + Mathf.RoundToInt(kenarlar[1].transform.position.y) + Mathf.RoundToInt(kenarlar[3].transform.position.x) + Mathf.RoundToInt(kenarlar[3].transform.position.y))
            {
                sayfa += 1;
                yazi.text = yazilar[sayfa];
                ogeler[10].SetActive(false);
                ogeler[11].SetActive(true);
                ust_kisim.color = Color.grey;
            }
        }
        else
        {
            yazi.text = "Unutma, kare 4 eşit kenardan oluşur";
            ust_kisim.color = Color.red;
        }
        
    }
    //********************** - x2 - *********************************************
    public void sonrakine_gec2()
    {
        x2 += 1;
    }
    public void oncekine_gec2()
    {
        x2 -= 1;
    }
    public void bitti2()
    {
            if ( (Mathf.RoundToInt(kenarlar[4].transform.position.x) + Mathf.RoundToInt(kenarlar[4].transform.position.y) + Mathf.RoundToInt(kenarlar[6].transform.position.x) + Mathf.RoundToInt(kenarlar[6].transform.position.y))  - ( Mathf.RoundToInt(kenarlar[5].transform.position.x) + Mathf.RoundToInt(kenarlar[5].transform.position.y) + Mathf.RoundToInt(kenarlar[7].transform.position.x) + Mathf.RoundToInt(kenarlar[7].transform.position.y)) < 3
            && (Mathf.RoundToInt(kenarlar[4].transform.position.x) + Mathf.RoundToInt(kenarlar[4].transform.position.y) + Mathf.RoundToInt(kenarlar[6].transform.position.x) + Mathf.RoundToInt(kenarlar[6].transform.position.y)) - (Mathf.RoundToInt(kenarlar[5].transform.position.x) + Mathf.RoundToInt(kenarlar[5].transform.position.y) + Mathf.RoundToInt(kenarlar[7].transform.position.x) + Mathf.RoundToInt(kenarlar[7].transform.position.y)) >-1)
            {
                sayfa += 1;
                yazi.text = yazilar[sayfa];
                ogeler[11].SetActive(false);
                ogeler[12].SetActive(true);
                ust_kisim.color = Color.grey;
            }
        
        else
        {
            yazi.text = "Dikdörtgen karşılıklı kenarları eşit olan 4 kenardan oluşur\n";
            ust_kisim.color = Color.red;
        }

    }
    public void sonrakine_gec3()
    {
        x3 += 1;
    }
    public void oncekine_gec3()
    {
        x3 -= 1;
    }
    public void bitti3()
    {
        if ((Mathf.RoundToInt(kenarlar[8].transform.position.x) + Mathf.RoundToInt(kenarlar[9].transform.position.x) + Mathf.RoundToInt(kenarlar[10].transform.position.x)) /  3 == Mathf.RoundToInt(kenarlar[9].transform.position.x) )
        {
            
            sayfa += 1;
            yazi.text = yazilar[sayfa];
            ogeler[12].SetActive(false);
            ust_kisim.color = Color.green;
            core_button.SetActive(true);
            ogeler[2].SetActive(true);

        }
        else
        {
            yazi.text = "Üçgen için üç ayrıtı birleştirmen gerek\n";
            ust_kisim.color = Color.red;
        }

    }





    public void olustur()
    {
        ogeler[17].SetActive(false);
        core_button.SetActive(true);
        siyah.Play("siyah");
        mor.Play("mor");
        mor2.Play("mor2");
        sari.Play("sari");
        sari2.Play("sari2");
    }
    public void olustur2()
    {
        ogeler[19].SetActive(false);
        core_button.SetActive(true);
        bir.Play("bir");
        iki.Play("iki");
        uc.Play("uc");
        dort.Play("dort");
        bes.Play("bes");
    }
    public void kapat()
    {
        Application.Quit();
    }

    public void sonraki()
    {
        act += 1;
        if (act == 1)
        {
            ogeler[0].SetActive(true); // kafayı açtım
            ogeler[8].SetActive(true); // ilk soru aç
            ust_kisim.color = Color.grey;
            ogeler[12].SetActive(false);
            ogeler[10].SetActive(false);
            core_button.SetActive(true);
            ogeler[2].SetActive(true);
            sayfa = 8;
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";

        }
       
        if (act == 2)
        {
            ust_kisim.color = Color.grey;
            ogeler[4].SetActive(false);
            ogeler[2].SetActive(false);
            ogeler[16].SetActive(true);
            sayfa = 14;
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";
            core_button.SetActive(true);
        }
        
        if (act == 3)
        {
            ust_kisim.color = Color.grey;
            sayfa = 19;
            ogeler[17].SetActive(true);
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";
            ogeler[18].SetActive(false);
            ogeler[16].SetActive(false);
            ogeler[4].SetActive(false);
            ogeler[13].SetActive(true);
            core_button.SetActive(true);
        }
        if (act == 4)
        {
            ust_kisim.color = Color.grey;
            sayfa = 22;
            ogeler[17].SetActive(true);
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";
            ust_kisim.color = Color.grey;
            ogeler[13].SetActive(false);
            ogeler[5].SetActive(true);
            core_button.SetActive(true);
        }
    }

    public void önceki()
    {
        act -= 1;
        if (act == 0)
        {
            core_button.SetActive(false);
            ogeler[2].SetActive(false);
            ogeler[10].SetActive(true);
            ust_kisim.color = Color.grey;
            sayfa = 3;
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";

        }

        if (act == 1)
        {
            ust_kisim.color = Color.grey;
            sayfa = 8;
            ogeler[2].SetActive(true);
            ogeler[16].SetActive(false);
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";
            core_button.SetActive(true);
        }

        if (act == 2)
        {
            ust_kisim.color = Color.grey;
            sayfa = 14;
            ogeler[16].SetActive(true);
            ogeler[13].SetActive(false);
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";
            core_button.SetActive(true);
        }
        if (act == 3)
        {
            ogeler[13].SetActive(true);
            ogeler[6].SetActive(false);
            ogeler[7].SetActive(false);
            ogeler[5].SetActive(false);
            sayfa = 19;
            yazi.text = "Sonraki aktiviteye geçmek için devam et butonuna bas";
            ust_kisim.color = Color.grey;
            core_button.SetActive(true);
        }
    }


}

