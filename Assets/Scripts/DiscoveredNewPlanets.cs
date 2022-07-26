using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiscoveredNewPlanets : MonoBehaviour
{
    /// <summary>
    /// Количество эффектовVFX
    /// </summary>
    int RandomVFX;

    /// <summary>
    /// ЭффектVFX
    /// </summary>
    public GameObject [] VFXFireWorks;

    /// <summary>
    /// Destroy Time - время, через которое удалится панель об отрытии новой Планеты
    /// </summary>
    float DTime = 6f;

    /// <summary>
    /// Повтор Анимации взрыва
    /// </summary>
    float Repeat = 1f;

    Text T;

    /// <summary>
    /// Панель с надписью об открытии новой планеты
    /// </summary>
    public GameObject PanelONP;
    GameObject K0, K1, K2, K3, K4, K5, K6, K7, K8, K9, K10, K11, K12, K13, K14, K15, K16, K17, K18, K19, K20,
        K21, K22, K23, K24, K25, K26, K27, K28, K29, K30, K31, K32, K33, K34, K35, K36, K37, K38, K39, K40, K41, K42, K43, K44, K45;
   
    
    private void Start()
    {
        //PlayerPrefs.SetInt("FA", 0); //FA- first appearance (первое появление Панели с надписью)
        PanelONP = gameObject.transform.GetChild(0).gameObject;

        T = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Text>();

        PanelONP.SetActive(false);

        CreateArtefacts();

    }

    private void CreateArtefacts()
    {
        for (byte i = 0; i <= 45; i++)
        {
            K(i);
        }
    }

    /// <summary>
    /// Метод создания Камней/Артефактов
    /// </summary>
    /// <param name="i">GetChild(n)</param>
    /// <returns></returns>
    private GameObject K(byte i)
    {
        GameObject GO = gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(i).gameObject;
        return GO;
    }

    private void Update()
    {
        RandomVFX = Random.Range(0, VFXFireWorks.Length);
    }

    //if (PlayerPrefs.GetInt("FA", 0) == 0)

    private void OnTriggerEnter2D (Collider2D collision)
    {
       
        //Проверка для 1 планеты
        if (collision.gameObject.name == "Планета1(Clone)")
            {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K0.SetActive(true);
            Destroy(K0, DTime);
            T.text = "Discovered new planet - CALLIOPE! New artifact:";
            StartCoroutines();
        }

        //Проверка для 2 планеты
        if (collision.gameObject.name == "Планета2(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K1.SetActive(true);
            Destroy(K1, DTime);
            T.text = "Discovered new planet - AARON! New artifact:";
            StartCoroutines();
        }

        //Проверка для 3 планеты
        if (collision.gameObject.name == "Планета3(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K2.SetActive(true);
            Destroy(K2, DTime);
            T.text = "Discovered new planet - HOREA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 4 планеты
        if (collision.gameObject.name == "Планета3(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K3.SetActive(true);
            Destroy(K3, DTime);
            T.text = "Discovered new planet - LEGION! New artifact:";
            StartCoroutines();
        }

        //Проверка для 5 планеты
        if (collision.gameObject.name == "Планета5(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K4.SetActive(true);
            Destroy(K4, DTime);
            T.text = "Discovered new planet - RHODEY! New artifact:";
            StartCoroutines();
        }

        //Проверка для 6 планеты
        if (collision.gameObject.name == "Планета6(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K5.SetActive(true);
            Destroy(K5, DTime);
            T.text = "Discovered new planet - RICTOR! New artifact:";
            StartCoroutines();
        }

        //Проверка для 7 планеты
        if (collision.gameObject.name == "Планета7(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K6.SetActive(true);
            Destroy(K6, DTime);
            T.text = "Discovered new planet - KANG! New artifact:";
            StartCoroutines();
        }

        //Проверка для 8 планеты
        if (collision.gameObject.name == "Планета8(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K7.SetActive(true);
            Destroy(K7, DTime);
            T.text = "Discovered new planet - X-55! New artifact:";
            StartCoroutines();
        }

        //Проверка для 9 планеты
        if (collision.gameObject.name == "Планета9(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K8.SetActive(true);
            Destroy(K8, DTime);
            T.text = "Discovered new planet - MAKKARI! New artifact:";
            StartCoroutines();
        }

        //Проверка для 10 планеты
        if (collision.gameObject.name == "Планета10(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K9.SetActive(true);
            Destroy(K9, DTime);
            T.text = "Discovered new planet - QUEEN! New artifact:";
            StartCoroutines();
        }

        //Проверка для 11 планеты
        if (collision.gameObject.name == "Планета11(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K10.SetActive(true);
            Destroy(K10, DTime);
            T.text = "Discovered new planet - ARANA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 12 планеты
        if (collision.gameObject.name == "Планета12(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K11.SetActive(true);
            Destroy(K11, DTime);
            T.text = "Discovered new planet - EOS-2! New artifact:";
            StartCoroutines();
        }

        //Проверка для 13 планеты
        if (collision.gameObject.name == "Планета13(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K12.SetActive(true);
            Destroy(K12, DTime);
            T.text = "Discovered new planet - VIPER! New artifact:";
            StartCoroutines();
        }

        //Проверка для 14 планеты
        if (collision.gameObject.name == "Планета14(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K13.SetActive(true);
            Destroy(K13, DTime);
            T.text = "Discovered new planet - DIANA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 15 планеты
        if (collision.gameObject.name == "Планета15(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K14.SetActive(true);
            Destroy(K14, DTime);
            T.text = "Discovered new planet - LIANA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 16 планеты
        if (collision.gameObject.name == "Планета16(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K15.SetActive(true);
            Destroy(K15, DTime);
            T.text = "Discovered new planet - ALMAZ! New artifact:";
            StartCoroutines();
        }

        //Проверка для 17 планеты
        if (collision.gameObject.name == "Планета17(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K16.SetActive(true);
            Destroy(K16, DTime);
            T.text = "Discovered new planet - ARMADILLO! New artifact:";
            StartCoroutines();
        }

        //Проверка для 18 планеты
        if (collision.gameObject.name == "Планета18(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K17.SetActive(true);
            Destroy(K17, DTime);
            T.text = "Discovered new planet - UNICORN! New artifact:";
            StartCoroutines();
        }

        //Проверка для 19 планеты
        if (collision.gameObject.name == "Планета19(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K18.SetActive(true);
            Destroy(K18, DTime);
            T.text = "Discovered new planet - SIA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 20 планеты
        if (collision.gameObject.name == "Планета20(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K19.SetActive(true);
            Destroy(K19, DTime);
            T.text = "Discovered new planet - AA-3! New artifact:";
            StartCoroutines();
        }

        //Проверка для 21 планеты
        if (collision.gameObject.name == "Планета21(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K20.SetActive(true);
            Destroy(K20, DTime);
            T.text = "Discovered new planet - EGO. LIVING PLANET! New artifact:";
            StartCoroutines();
        }

        //Проверка для 22 планеты
        if (collision.gameObject.name == "Планета22(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K21.SetActive(true);
            Destroy(K21, DTime);
            T.text = "Discovered new planet - A-15! New artifact:";
            StartCoroutines();
        }

        //Проверка для 23 планеты
        if (collision.gameObject.name == "Планета23(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K22.SetActive(true);
            Destroy(K22, DTime);
            T.text = "Discovered new planet - A-16! New artifact:";
            StartCoroutines();
        }

        //Проверка для 24 планеты
        if (collision.gameObject.name == "Планета24(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K23.SetActive(true);
            Destroy(K23, DTime);
            T.text = "Discovered new planet - ZARDA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 25 планеты
        if (collision.gameObject.name == "Планета25(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K24.SetActive(true);
            Destroy(K24, DTime);
            T.text = "Discovered new planet - CABLE! New artifact:";
            StartCoroutines();
        }

        //Проверка для 26 планеты
        if (collision.gameObject.name == "Планета26(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K25.SetActive(true);
            Destroy(K25, DTime);
            T.text = "Discovered new planet - PERIT-1! New artifact:";
            StartCoroutines();
        }

        //Проверка для 27 планеты
        if (collision.gameObject.name == "Планета27(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K26.SetActive(true);
            Destroy(K26, DTime);
            T.text = "Discovered new planet - LEECH! New artifact:";
            StartCoroutines();
        }

        //Проверка для 28 планеты
        if (collision.gameObject.name == "Планета28(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K25.SetActive(true);
            Destroy(K27, DTime);
            T.text = "Discovered new planet - JETSTREAM! New artifact:";
            StartCoroutines();
        }

        //Проверка для 29 планеты
        if (collision.gameObject.name == "Планета29(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K28.SetActive(true);
            Destroy(K28, DTime);
            T.text = "Discovered new planet - B-34! New artifact:";
            StartCoroutines();
        }

        //Проверка для 30 планеты
        if (collision.gameObject.name == "Планета30(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K29.SetActive(true);
            Destroy(K29, DTime);
            T.text = "Discovered new planet - AURORA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 31 планеты
        if (collision.gameObject.name == "Планета31(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K30.SetActive(true);
            Destroy(K30, DTime);
            T.text = "Discovered new planet - AVALANCHE! New artifact:";
            StartCoroutines();
        }

        //Проверка для 32 планеты
        if (collision.gameObject.name == "Планета32(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K31.SetActive(true);
            Destroy(K31, DTime);
            T.text = "Discovered new planet - IRON PLANET! New artifact:";
            StartCoroutines();
        }

        //Проверка для 33 планеты
        if (collision.gameObject.name == "Планета33(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K32.SetActive(true);
            Destroy(K32, DTime);
            T.text = "Discovered new planet - M.A.! New artifact:";
            StartCoroutines();
        }

        //Проверка для 34 планеты
        if (collision.gameObject.name == "Планета34(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K33.SetActive(true);
            Destroy(K33, DTime);
            T.text = "Discovered new planet - DEVOS! New artifact:";
            StartCoroutines();
        }

        //Проверка для 35 планеты
        if (collision.gameObject.name == "Планета35(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K34.SetActive(true);
            Destroy(K34, DTime);
            T.text = "Discovered new planet - TUTU-1! New artifact:";
            StartCoroutines();
        }

        //Проверка для 36 планеты
        if (collision.gameObject.name == "Планета36(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K35.SetActive(true);
            Destroy(K35, DTime);
            T.text = "Discovered new planet - MORDO! New artifact:";
            StartCoroutines();
        }

        //Проверка для 37 планеты
        if (collision.gameObject.name == "Планета37(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K36.SetActive(true);
            Destroy(K36, DTime);
            T.text = "Discovered new planet - HELL! New artifact:";
            StartCoroutines();
        }

        //Проверка для 38 планеты
        if (collision.gameObject.name == "Планета38(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K37.SetActive(true);
            Destroy(K37, DTime);
            T.text = "Discovered new planet - PRIZM! New artifact:";
            StartCoroutines();
        }

        //Проверка для 39 планеты
        if (collision.gameObject.name == "Планета39(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K38.SetActive(true);
            Destroy(K38, DTime);
            T.text = "Discovered new planet - PRIDE! New artifact:";
            StartCoroutines();
        }

        //Проверка для 40 планеты
        if (collision.gameObject.name == "Планета40(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K39.SetActive(true);
            Destroy(K39, DTime);
            T.text = "Discovered new planet - Z-101! New artifact:";
            StartCoroutines();
        }

        //Проверка для 41 планеты
        if (collision.gameObject.name == "Планета41(Прототип Земли, но не Земля)(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K40.SetActive(true);
            Destroy(K40, DTime);
            T.text = "Discovered new planet - EARTH-2! New artifact:";
            StartCoroutines();
        }

        //Проверка для 42 планеты
        if (collision.gameObject.name == "Планета42(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K41.SetActive(true);
            Destroy(K41, DTime);
            T.text = "Discovered new planet - NOVA! New artifact:";
            StartCoroutines();
        }

        //Проверка для 43 планеты
        if (collision.gameObject.name == "Планета43(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K42.SetActive(true);
            Destroy(K42, DTime);
            T.text = "Discovered new planet - GRAVITY! New artifact:";
            StartCoroutines();
        }

        //Проверка для 44 планеты
        if (collision.gameObject.name == "Планета44(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K43.SetActive(true);
            Destroy(K43, DTime);
            T.text = "Discovered new planet - FIRE PLANET! New artifact:";
            StartCoroutines();
        }

        //Проверка для 45 планеты
        if (collision.gameObject.name == "Планета45(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K44.SetActive(true);
            Destroy(K44, DTime);
            T.text = "Discovered new planet - UHP-1! New artifact:";
            StartCoroutines();
        }

        //Проверка для 46 планеты
        if (collision.gameObject.name == "Планета46(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            K45.SetActive(true);
            Destroy(K45, DTime);
            T.text = "Discovered new planet - UHP-2! New artifact:";
            StartCoroutines();
        }

        //Проверка для 47 планеты
        if (collision.gameObject.name == "Плутон(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - PLUTO! BUT IS IT A PLANET?";
            StartCoroutines();
        }

        //Проверка для 48 планеты
        if (collision.gameObject.name == "Нептун(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - NEPTUNE!";
            StartCoroutines();
        }

        //Проверка для 49 планеты
        if (collision.gameObject.name == "Уран(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - URANUS!";
            StartCoroutines();
        }

        //Проверка для Сатурна
        if (collision.gameObject.name == "Сатурн(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - SATURN!";
            StartCoroutines();
        }

        //Проверка для Юпитера
        if (collision.gameObject.name == "Юпитер(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - JUPITER!";
            StartCoroutines();
        }

        //Проверка для Марса
        if (collision.gameObject.name == "Марс(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - MARS!";
            StartCoroutines();
        }

        //Проверка для ЗЕМЛИ
        if (collision.gameObject.name == "Планета Земля(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - EARTH!";
            StartCoroutines();
        }

        //Проверка для Венеры
        if (collision.gameObject.name == "Венера(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - VENUS!";
            StartCoroutines();
        }

        //Проверка для 52 планеты
        if (collision.gameObject.name == "Меркурий(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "Discovered new planet - MERCURY!";
            StartCoroutines();
        }

        //Проверка для Солнца
        if (collision.gameObject.name == "Солнце(Clone)")
        {
            Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
            PanelONP.SetActive(true);
            T.text = "HOT.STOP NOW!";

            StartCoroutine(SET_ACTIVE_FALSE()); //старт Coroutine для скрытия Панели с текстом об открытии Новой планеты
        }
    }

    private void StartCoroutines()
    {
        StartCoroutine(SET_ACTIVE_FALSE()); //старт Coroutine для скрытия Панели с текстом об открытии Новой планеты
        StartCoroutine(BooomAnim());
        StartCoroutine(BooomAnim2());
        StartCoroutine(BooomAnim3());
    }

IEnumerator SET_ACTIVE_FALSE()
    {
        yield return new WaitForSeconds(DTime);
        PanelONP.SetActive(false);
    }

    IEnumerator BooomAnim()
    {
        yield return new WaitForSeconds(Repeat);
        Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
    }

    IEnumerator BooomAnim2()
    {
        yield return new WaitForSeconds(Repeat);
        Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
    }

    IEnumerator BooomAnim3()
    {
        yield return new WaitForSeconds(Repeat);
        Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
    }
}
