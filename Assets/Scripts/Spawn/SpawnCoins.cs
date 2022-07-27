using Assets.Scripts.Spawn;
using System.Collections;
using UnityEngine;

public class SpawnCoins : MainSpawn
{
    public GameObject Coin;
    bool coinIsSpawn;
    float random_position;

    private void Update()
    {
        SpawnStart(coinIsSpawn, NewSpawnCoin());
    }

    private IEnumerator NewSpawnCoin()
    {
        while (StartGame.GameIsStart)
        {
            yield return new WaitForSeconds(10f);
            random_position = Random.Range(-2.28f, 2.28f);
            Instantiate(Coin, new Vector2(random_position, 28f), Quaternion.identity);
        }
    }
}
