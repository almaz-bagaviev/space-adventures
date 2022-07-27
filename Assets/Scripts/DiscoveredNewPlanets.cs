using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiscoveredNewPlanets : MonoBehaviour
{
    int randomVFX;
    public GameObject[] VFXFireWorks;
    float destroyTime = 6f;
    float repeat = 1f;
    Text textInfo;

    public GameObject openNewPlanetPanel;
    GameObject stone0, stone1, stone2, stone3, stone4, stone5, stone6, stone7, stone8,
        stone9, stone10, stone11, stone12, stone13, stone14, stone15, stone16, stone17,
        stone18, stone19, stone20, stone21, stone22, stone23, stone24, stone25, stone26,
        stone27, stone28, stone29, stone30, stone31, stone32, stone33, stone34, stone35,
        stone36, stone37, stone38, stone39, stone40, stone41, stone42, stone43, stone44, stone45;

    GameObject[] stones;


    private void Awake()
    {
        stones = new GameObject[46] {stone0, stone1, stone2, stone3, stone4, stone5, stone6, stone7, stone8, stone9, stone10,
            stone11, stone12, stone13, stone14, stone15, stone16, stone17, stone18, stone19, stone20,
            stone21, stone22, stone23, stone24, stone25, stone26, stone27, stone28, stone29, stone30,
            stone31, stone32, stone33, stone34, stone35, stone36, stone37, stone38, stone39, stone40,
            stone41, stone42, stone43, stone44, stone45};
    }

    private void Start()
    {
        openNewPlanetPanel = gameObject.transform.GetChild(0).gameObject;
        textInfo = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Text>();
        openNewPlanetPanel.SetActive(false);
        InitializeStones();
    }

    private void InitializeStones()
    {
        for (byte i = 0; i < 46; i++)
        {
            Stones(i);
        }
    }

    private GameObject Stones(byte i)
    {
        GameObject GO = gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(i).gameObject;
        stones[i] = GO;
        return stones[i];
    }

    private void Update() => randomVFX = Random.Range(0, VFXFireWorks.Length);

    private void ShowInPanel(string text, GameObject gameObject)
    {
        Instantiate(VFXFireWorks[randomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
        openNewPlanetPanel.SetActive(true);
        gameObject.SetActive(true);
        Destroy(gameObject, destroyTime);
        textInfo.text = $"Discovered new planet - {text}! New artifact:";
        StartCoroutines();
    }

    private void ShowInPanel(string text)
    {
        Instantiate(VFXFireWorks[randomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
        openNewPlanetPanel.SetActive(true);
        textInfo.text = $"Discovered new planet - {text}!";
        StartCoroutines();
    }

    private void ShowEnding()
    {
        Instantiate(VFXFireWorks[randomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
        openNewPlanetPanel.SetActive(true);
        textInfo.text = "HOT.STOP NOW!";

        StartCoroutine(SetActiveFalse());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Planet1(Clone)": ShowInPanel("CALLIOPE", stones[0]); break;
            case "Planet2(Clone)": ShowInPanel("AARON", stones[1]); break;
            case "Planet3(Clone)": ShowInPanel("HOREA", stones[2]); break;
            case "Planet4(Clone)": ShowInPanel("LEGION", stones[3]); break;
            case "Planet5(Clone)": ShowInPanel("RHODEY", stones[4]); break;

            case "Planet6(Clone)": ShowInPanel("RICTOR", stones[5]); break;
            case "Planet7(Clone)": ShowInPanel("KANG", stones[6]); break;
            case "Planet8(Clone)": ShowInPanel("X-55", stones[7]); break;
            case "Planet9(Clone)": ShowInPanel("MAKKARI", stones[8]); break;
            case "Planet10(Clone)": ShowInPanel("QUEEN", stones[9]); break;

            case "Planet11(Clone)": ShowInPanel("ARANA", stones[10]); break;
            case "Planet12(Clone)": ShowInPanel("EOS-2", stones[11]); break;
            case "Planet13(Clone)": ShowInPanel("VIPER", stones[12]); break;
            case "Planet14(Clone)": ShowInPanel("DIANA", stones[13]); break;
            case "Planet15(Clone)": ShowInPanel("LIANA", stones[14]); break;

            case "Planet16(Clone)": ShowInPanel("ALMAZ", stones[15]); break;
            case "Planet17(Clone)": ShowInPanel("ARMADILLO", stones[16]); break;
            case "Planet18(Clone)": ShowInPanel("UNICORN", stones[17]); break;
            case "Planet19(Clone)": ShowInPanel("SIA", stones[18]); break;
            case "Planet20(Clone)": ShowInPanel("AA-3", stones[19]); break;

            case "Planet21(Clone)": ShowInPanel("EGO", stones[20]); break;
            case "Planet22(Clone)": ShowInPanel("A-15", stones[21]); break;
            case "Planet23(Clone)": ShowInPanel("A-16", stones[22]); break;
            case "Planet24(Clone)": ShowInPanel("ZARDA", stones[23]); break;
            case "Planet25(Clone)": ShowInPanel("CABLE", stones[24]); break;

            case "Planet26(Clone)": ShowInPanel("PERIT-1", stones[25]); break;
            case "Planet27(Clone)": ShowInPanel("LEECH", stones[26]); break;
            case "Planet28(Clone)": ShowInPanel("JETSTREAM", stones[27]); break;
            case "Planet29(Clone)": ShowInPanel("B-34", stones[28]); break;
            case "Planet30(Clone)": ShowInPanel("AURORA", stones[29]); break;

            case "Planet31(Clone)": ShowInPanel("AVALANCHE", stones[30]); break;
            case "Planet32(Clone)": ShowInPanel("IRON PLANET", stones[31]); break;
            case "Planet33(Clone)": ShowInPanel("M.A.", stones[32]); break;
            case "Planet34(Clone)": ShowInPanel("DEVOS", stones[33]); break;
            case "Planet35(Clone)": ShowInPanel("TUTU-1", stones[34]); break;

            case "Planet36(Clone)": ShowInPanel("MORDO", stones[35]); break;
            case "Planet37(Clone)": ShowInPanel("HELL", stones[36]); break;
            case "Planet38(Clone)": ShowInPanel("PRIZM", stones[37]); break;
            case "Planet39(Clone)": ShowInPanel("PRIDE", stones[38]); break;
            case "Planet40(Clone)": ShowInPanel("Z-101", stones[39]); break;

            case "Planet41-NotEarth(Clone)": ShowInPanel("EARTH-2", stones[40]); break;
            case "Planet42(Clone)": ShowInPanel("NOVA", stones[41]); break;
            case "Planet43(Clone)": ShowInPanel("GRAVITY", stones[42]); break;
            case "Planet44(Clone)": ShowInPanel("FIRE PLANET", stones[43]); break;
            case "Planet45(Clone)": ShowInPanel("UHP-1", stones[44]); break;
            case "Planet46(Clone)": ShowInPanel("UHP-2", stones[45]); break;

            case "Pluto(Clone)": ShowInPanel("PLUTO! BUT IS IT A PLANET?"); break;
            case "Neptune(Clone)": ShowInPanel("NEPTUNE"); break;
            case "Uranus(Clone)": ShowInPanel("URANUS"); break;
            case "Saturn(Clone)": ShowInPanel("SATURN"); break;
            case "Jupiter(Clone)": ShowInPanel("JUPITER"); break;

            case "Mars(Clone)": ShowInPanel("MARS"); break;
            case "Earth(Clone)": ShowInPanel("EARTH"); break;
            case "Venus(Clone)": ShowInPanel("VENUS"); break;
            case "Mercury(Clone)": ShowInPanel("MERCURY"); break;
            case "Sun(Clone)": ShowEnding(); break;
        }
    }

    private void StartCoroutines()
    {
        StartCoroutine(SetActiveFalse());
        for (int i = 0; i < 3; i++)
        {
            StartCoroutine(BooomAnim());
        }
    }

    private IEnumerator SetActiveFalse()
    {
        yield return new WaitForSeconds(destroyTime);
        openNewPlanetPanel.SetActive(false);
    }

    private IEnumerator BooomAnim()
    {
        yield return new WaitForSeconds(repeat);
        Instantiate(VFXFireWorks[randomVFX], new Vector2(1f, 17.88f), Quaternion.identity);
    }
}
