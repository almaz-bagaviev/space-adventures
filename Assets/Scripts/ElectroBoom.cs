using Assets.Scripts.Spawn;
using System.Collections;
using UnityEngine;

public class ElectroBoom : MainSpawn
{
    public GameObject Electro;
    bool electroIsSpawn;
    float RandomPositionforX;

    private void Update()
    {
        SpawnStart(electroIsSpawn, NewSpawnElectro());
    }

    private IEnumerator NewSpawnElectro()
    {
        while (true)
        {
            if (StartGame.GameIsStart)
            {
                yield return new WaitForSeconds(30f);
                RandomPositionforX = Random.Range(-2.28f, 2.28f);
                Instantiate(Electro, new Vector2(RandomPositionforX, 24f), Quaternion.identity);
            }
        }
    }
}


