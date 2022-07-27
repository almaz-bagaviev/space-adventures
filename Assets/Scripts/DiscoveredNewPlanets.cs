using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiscoveredNewPlanets : MonoBehaviour
{
    int RandomVFX;
    public GameObject[] VFXFireWorks;
    float DestroyTime = 6f;
    float Repeat = 1f;
    Text textInfo;

    public GameObject openNewPlanetPanel;
    GameObject K0, K1, K2, K3, K4, K5, K6, K7, K8, K9, K10, K11, K12, K13, K14, K15, K16, K17, K18, K19, K20,
        K21, K22, K23, K24, K25, K26, K27, K28, K29, K30, K31, K32, K33, K34, K35, K36, K37, K38, K39, K40, K41, K42, K43, K44, K45;


    private void Start()
    {
        openNewPlanetPanel = gameObject.transform.GetChild(0).gameObject;
        textInfo = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Text>();
        openNewPlanetPanel.SetActive(false);
        CreateArtefacts();
    }

    private void CreateArtefacts()
    {
        for (byte i = 0; i <= 45; i++)
        {
            Stones(i);
        }
    }

    /// <summary>
    /// Метод создания Камней/Артефактов
    /// </summary>
    /// <param name="i">GetChild(n)</param>
    /// <returns></returns>
    private GameObject Stones(byte i)
    {
        GameObject GO = gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(i).gameObject;
        return GO;
    }

    private void Update() => RandomVFX = Random.Range(0, VFXFireWorks.Length);

    private void ShowInPanel(string text, GameObject gameObject)
    {
        Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
        openNewPlanetPanel.SetActive(true);
        gameObject.SetActive(true);
        Destroy(gameObject, DestroyTime);
        textInfo.text = $"Discovered new planet - {text}! New artifact:";
        StartCoroutines();
    }

    private void ShowInPanel(string text)
    {
        Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
        openNewPlanetPanel.SetActive(true);
        textInfo.text = $"Discovered new planet - {text}!";
        StartCoroutines();
    }

    private void ShowEnding()
    {
        Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
        openNewPlanetPanel.SetActive(true);
        textInfo.text = "HOT.STOP NOW!";

        StartCoroutine(SetActiveFalse()); //старт Coroutine для скрытия Панели с текстом об открытии Новой планеты
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Планета1(Clone)": ShowInPanel("CALLIOPE", K0); break;
            case "Планета2(Clone)": ShowInPanel("AARON", K1); break;
            case "Планета3(Clone)": ShowInPanel("HOREA", K2); break;
            case "Планета4(Clone)": ShowInPanel("LEGION", K3); break;
            case "Планета5(Clone)": ShowInPanel("RHODEY", K4); break;

            case "Планета6(Clone)": ShowInPanel("RICTOR", K5); break;
            case "Планета7(Clone)": ShowInPanel("KANG", K6); break;
            case "Планета8(Clone)": ShowInPanel("X-55", K7); break;
            case "Планета9(Clone)": ShowInPanel("MAKKARI", K8); break;
            case "Планета10(Clone)": ShowInPanel("QUEEN", K9); break;

            case "Планета11(Clone)": ShowInPanel("ARANA", K10); break;
            case "Планета12(Clone)": ShowInPanel("EOS-2", K11); break;
            case "Планета13(Clone)": ShowInPanel("VIPER", K12); break;
            case "Планета14(Clone)": ShowInPanel("DIANA", K13); break;
            case "Планета15(Clone)": ShowInPanel("LIANA", K14); break;

            case "Планета16(Clone)": ShowInPanel("ALMAZ", K15); break;
            case "Планета17(Clone)": ShowInPanel("ARMADILLO", K16); break;
            case "Планета18(Clone)": ShowInPanel("UNICORN", K17); break;
            case "Планета19(Clone)": ShowInPanel("SIA", K18); break;
            case "Планета20(Clone)": ShowInPanel("AA-3", K19); break;

            case "Планета21(Clone)": ShowInPanel("EGO", K20); break;
            case "Планета22(Clone)": ShowInPanel("A-15", K21); break;
            case "Планета23(Clone)": ShowInPanel("A-16", K22); break;
            case "Планета24(Clone)": ShowInPanel("ZARDA", K23); break;
            case "Планета25(Clone)": ShowInPanel("CABLE", K24); break;

            case "Планета26(Clone)": ShowInPanel("PERIT-1", K25); break;
            case "Планета27(Clone)": ShowInPanel("LEECH", K26); break;
            case "Планета28(Clone)": ShowInPanel("JETSTREAM", K27); break;
            case "Планета29(Clone)": ShowInPanel("B-34", K28); break;
            case "Планета30(Clone)": ShowInPanel("AURORA", K29); break;

            case "Планета31(Clone)": ShowInPanel("AVALANCHE", K30); break;
            case "Планета32(Clone)": ShowInPanel("IRON PLANET", K31); break;
            case "Планета33(Clone)": ShowInPanel("M.A.", K32); break;
            case "Планета34(Clone)": ShowInPanel("DEVOS", K33); break;
            case "Планета35(Clone)": ShowInPanel("TUTU-1", K34); break;

            case "Планета36(Clone)": ShowInPanel("MORDO", K35); break;
            case "Планета37(Clone)": ShowInPanel("HELL", K36); break;
            case "Планета38(Clone)": ShowInPanel("PRIZM", K37); break;
            case "Планета39(Clone)": ShowInPanel("PRIDE", K38); break;
            case "Планета40(Clone)": ShowInPanel("Z-101", K39); break;

            case "Планета41(Clone)": ShowInPanel("EARTH-2", K40); break;
            case "Планета42(Clone)": ShowInPanel("NOVA", K41); break;
            case "Планета43(Clone)": ShowInPanel("GRAVITY", K42); break;
            case "Планета44(Clone)": ShowInPanel("FIRE PLANET", K43); break;
            case "Планета45(Clone)": ShowInPanel("UHP-1", K44); break;
            case "Планета46(Clone)": ShowInPanel("UHP-2", K45); break;

            case "Плутон(Clone)": ShowInPanel("PLUTO! BUT IS IT A PLANET?"); break;
            case "Нептун(Clone)": ShowInPanel("NEPTUNE"); break;
            case "Уран(Clone)": ShowInPanel("URANUS"); break;
            case "Сатурн(Clone)": ShowInPanel("SATURN"); break;
            case "Юпитер(Clone)": ShowInPanel("JUPITER"); break;

            case "Марс(Clone)": ShowInPanel("MARS"); break;
            case "Планета Земля(Clone)": ShowInPanel("EARTH"); break;
            case "Венера(Clone)": ShowInPanel("VENUS"); break;
            case "Меркурий(Clone)": ShowInPanel("MERCURY"); break;
            case "Солнце(Clone)": ShowEnding(); break;
        }
    }

    private void StartCoroutines()
    {
        StartCoroutine(SetActiveFalse()); //старт Coroutine для скрытия Панели с текстом об открытии Новой планеты
        for (int i = 0; i < 3; i++)
        {
            StartCoroutine(BooomAnim());
        }
    }

    private IEnumerator SetActiveFalse()
    {
        yield return new WaitForSeconds(DestroyTime);
        openNewPlanetPanel.SetActive(false);
    }

    private IEnumerator BooomAnim()
    {
        yield return new WaitForSeconds(Repeat);
        Instantiate(VFXFireWorks[RandomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
    }
}
