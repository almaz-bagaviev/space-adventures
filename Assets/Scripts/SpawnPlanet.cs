using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    public GameObject Planet1, Planet2, Planet3, Planet4, Planet5, Planet6, Planet7, Planet8, Planet9, Planet10,
                      Planet11, Planet12, Planet13, Planet14, Planet15, Planet16, Planet17, Planet18, Planet19, Planet20,
                      Planet21, Planet22, Planet23, Planet24, Planet25, Planet26, Planet27, Planet28, Planet29, Planet30,
                      Planet31, Planet32, Planet33, Planet34, Planet35, Planet36, Planet37, Planet38, Planet39, Planet40,
                      Planet41, Planet42, Planet43, Planet44, Planet45, Planet46,
NeptunePlanet47, UranusPlanet48, SaturnPlanet49, JupiterPlanet50, ПоясАстероидов, MarsPlanet51, EarthPlanet52, VenusPlanet53, MercuryPlanet54, Sun;

    private bool planet_is_spawn;

    private void Update()
    {
        if (StartGame.GameIsStart && !planet_is_spawn)
        {
            planet_is_spawn = true;
            PlanetSpawner();
        }       
       
    }
    private void PlanetSpawner()
    {
        
        Instantiate(Planet1, new Vector2(-1.42f, 25f), Quaternion.identity);
        Instantiate(Planet2, new Vector2(1.24f, 45f), Quaternion.identity);
        Instantiate(Planet3, new Vector2(-1.14f, 65f), Quaternion.identity);
        Instantiate(Planet4, new Vector2(2.72f, 85f), Quaternion.identity);
        Instantiate(Planet5, new Vector2(0f, 105f), Quaternion.identity);
        Instantiate(Planet6, new Vector2(3.5f, 125f), Quaternion.identity);
        Instantiate(Planet7, new Vector2(-2.36f, 145f), Quaternion.identity);
        Instantiate(Planet8, new Vector2(1.05f, 165f), Quaternion.identity);
        Instantiate(Planet9, new Vector2(-1.97f, 185f), Quaternion.identity);
        Instantiate(Planet10, new Vector2(-0.5f, 205f), Quaternion.identity);
        Instantiate(Planet11, new Vector2(3.56f, 225f), Quaternion.identity);
        Instantiate(Planet12, new Vector2(-3.65f, 245f), Quaternion.identity);
        Instantiate(Planet13, new Vector2(1.25f, 265f), Quaternion.identity);
        Instantiate(Planet14, new Vector2(-0.31f, 285f), Quaternion.identity);
        Instantiate(Planet15, new Vector2(-0.63f, 305f), Quaternion.identity);
        Instantiate(Planet16, new Vector2(1.05f, 325f), Quaternion.identity);
        Instantiate(Planet17, new Vector2(-0.88f, 345f), Quaternion.identity);
        Instantiate(Planet18, new Vector2(0.5f, 365f), Quaternion.identity);
        Instantiate(Planet19, new Vector2(0.08f, 385f), Quaternion.identity);
        Instantiate(Planet20, new Vector2(-2f, 405f), Quaternion.identity);
        Instantiate(Planet21, new Vector2(1.11f, 425f), Quaternion.identity);
        Instantiate(Planet22, new Vector2(-0.44f, 445f), Quaternion.identity);
        Instantiate(Planet23, new Vector2(-1.4f, 465f), Quaternion.identity);
        Instantiate(Planet24, new Vector2(-1.4f, 485f), Quaternion.identity);
        Instantiate(Planet25, new Vector2(0.28f, 505f), Quaternion.identity);
        Instantiate(Planet26, new Vector2(2.84f, 525f), Quaternion.identity);
        Instantiate(Planet27, new Vector2(-1.33f, 545f), Quaternion.identity);
        Instantiate(Planet28, new Vector2(0.4f, 565f), Quaternion.identity);
        Instantiate(Planet29, new Vector2(1.18f, 585f), Quaternion.identity);
        Instantiate(Planet30, new Vector2(-0.11f, 605f), Quaternion.identity);
        Instantiate(Planet31, new Vector2(1.37f, 625f), Quaternion.identity);
        Instantiate(Planet32, new Vector2(-3.77f, 645f), Quaternion.identity);
        Instantiate(Planet33, new Vector2(2.22f, 665f), Quaternion.identity);
        Instantiate(Planet34, new Vector2(-0.81f, 685f), Quaternion.identity);
        Instantiate(Planet35, new Vector2(0.33f, 705f), Quaternion.identity);
        Instantiate(Planet36, new Vector2(1.43f, 725f), Quaternion.identity);
        Instantiate(Planet37, new Vector2(-3f, 745f), Quaternion.identity);
        Instantiate(Planet38, new Vector2(0.01f, 765f), Quaternion.identity);
        Instantiate(Planet39, new Vector2(0.27f, 785f), Quaternion.identity);
        Instantiate(Planet40, new Vector2(0.85f, 805f), Quaternion.identity);
        Instantiate(Planet41, new Vector2(-2.16f, 825f), Quaternion.identity);
        Instantiate(Planet42, new Vector2(1.24f, 845f), Quaternion.identity);
        Instantiate(Planet43, new Vector2(-0.04f, 865f), Quaternion.identity);
        Instantiate(Planet44, new Vector2(0.59f, 885f), Quaternion.identity);
        Instantiate(Planet45, new Vector2(0.59f, 905f), Quaternion.identity);
        Instantiate(Planet46, new Vector2(0.59f, 925f), Quaternion.identity);
        Instantiate(NeptunePlanet47, new Vector2(0f, 945f), Quaternion.identity);
        Instantiate(UranusPlanet48, new Vector2(-1.33f, 965f), Quaternion.identity);
        Instantiate(SaturnPlanet49, new Vector2(2.01f, 985f), Quaternion.identity);
        Instantiate(JupiterPlanet50, new Vector2(-1.4f, 1005f), Quaternion.identity);
        Instantiate(ПоясАстероидов, new Vector2(0.27f, 1020f), Quaternion.identity);
        Instantiate(MarsPlanet51, new Vector2(1.3f, 1035f), Quaternion.identity);
        Instantiate(EarthPlanet52, new Vector2(1.26f, 1055f), Quaternion.identity);
        Instantiate(VenusPlanet53, new Vector2(1.43f, 1075f), Quaternion.identity);
        Instantiate(MercuryPlanet54, new Vector2(0.27f, 1095f), Quaternion.identity);
        Instantiate(Sun, new Vector2(0.27f, 1115f), Quaternion.identity);

    }
}
