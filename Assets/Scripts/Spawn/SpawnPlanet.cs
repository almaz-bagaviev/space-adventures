using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    public GameObject Planet1, Planet2, Planet3, Planet4, Planet5, Planet6, Planet7, Planet8, Planet9, Planet10,
                      Planet11, Planet12, Planet13, Planet14, Planet15, Planet16, Planet17, Planet18, Planet19, Planet20,
                      Planet21, Planet22, Planet23, Planet24, Planet25, Planet26, Planet27, Planet28, Planet29, Planet30,
                      Planet31, Planet32, Planet33, Planet34, Planet35, Planet36, Planet37, Planet38, Planet39, Planet40,
                      Planet41, Planet42, Planet43, Planet44, Planet45, Planet46,
                      NeptunePlanet47, UranusPlanet48, SaturnPlanet49, JupiterPlanet50, Asteroids, MarsPlanet51,
                      EarthPlanet52, VenusPlanet53, MercuryPlanet54, Sun;

    bool planetsIsSpawn;
    List<GameObject> storage;

    private void Start()
    {
        storage = new List<GameObject>()
        {
            Planet1, Planet2, Planet3, Planet4, Planet5, Planet6, Planet7, Planet8, Planet9, Planet10, Planet11, Planet12,
            Planet13, Planet14, Planet15, Planet16, Planet17, Planet18, Planet19, Planet20, Planet21, Planet22, Planet23, Planet24,
            Planet25,Planet26, Planet27, Planet28, Planet29, Planet30, Planet31, Planet32, Planet33, Planet34, Planet35, Planet36,
            Planet37,Planet38, Planet39, Planet40, Planet41, Planet42, Planet43, Planet44, Planet45, Planet46,
            NeptunePlanet47, UranusPlanet48, SaturnPlanet49, JupiterPlanet50, Asteroids, MarsPlanet51,EarthPlanet52,
            VenusPlanet53, MercuryPlanet54, Sun
        };
    }

    private void Update()
    {
        if (StartGame.GameIsStart && !planetsIsSpawn)
        {
            planetsIsSpawn = true;
            PlanetSpawner();
        }

    }
    private void PlanetSpawner()
    {
        for (int i = 0; i < storage.Count; i++)
        {
            Instantiate(storage[i], new Vector2(Random.Range(-2.55f, 3.55f), 25f), Quaternion.identity);
            Thread.Sleep(40_000);
        }
    }
}
