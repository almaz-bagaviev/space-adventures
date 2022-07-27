using Assets.Scripts.Spawn;
using System.Collections;
using UnityEngine;

public class SpawnBlueStars : MainSpawn
{
    public GameObject BlueStar;
    bool starIsSpawn;
    float randomPosition;

    private void Update()
    {
        SpawnStart(starIsSpawn, NewSpawnStar());
    }

    private IEnumerator NewSpawnStar()
    {
        while (StartGame.GameIsStart)
        {
            yield return new WaitForSeconds(40f);
            randomPosition = Random.Range(-2.28f, 2.28f);
            Instantiate(BlueStar, new Vector2(randomPosition, 28f), Quaternion.identity);
        }
    }
}
