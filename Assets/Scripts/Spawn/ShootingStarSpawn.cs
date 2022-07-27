using Assets.Scripts.Spawn;
using System.Collections;
using UnityEngine;

public class ShootingStarSpawn : MainSpawn
{
    public GameObject[] shootingStar;
    bool shootingStarsIsSpawn;
    int randomObjects;
    float randomPositionforX;

    private void Update()
    {
        SpawnStart(shootingStarsIsSpawn, NewSpawnShootingStars());
    }

    private IEnumerator NewSpawnShootingStars()
    {
        yield return new WaitForSeconds(20f);
        randomObjects = Random.Range(0, shootingStar.Length);
        randomPositionforX = Random.Range(-4.74f, -1.73f);
        Instantiate(shootingStar[randomObjects], new Vector2(randomPositionforX, 29f), Quaternion.Euler(new Vector3(0, 0, 27f)));
    }
}