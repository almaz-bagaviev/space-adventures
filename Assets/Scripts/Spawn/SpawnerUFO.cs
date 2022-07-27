using Assets.Scripts.Spawn;
using System.Collections;
using UnityEngine;

public class SpawnerUFO : MainSpawn
{
    public GameObject[] UFO;
    bool UFO_IS_Spawn;
    float RandomPositionforX;
    int RandomObjects;

    private void Update()
    {
        SpawnStart(UFO_IS_Spawn, NewSpawnUFO());
    }

    private IEnumerator NewSpawnUFO()
    {
        while (StartGame.GameIsStart)
        {
            yield return new WaitForSeconds(0.7f);
            RandomPositionforX = Random.Range(-2.28f, 2.28f);
            RandomObjects = Random.Range(0, UFO.Length);
            Instantiate(UFO[RandomObjects], new Vector2(RandomPositionforX, 24f), Quaternion.identity);
        }
    }
}