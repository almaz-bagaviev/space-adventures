using System.Collections;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject Coin;
    private bool Coin_IS_Spawn;
    private float random_position;


    private void Update()
    {
        if (StartGame.GameIsStart && !Coin_IS_Spawn)
        {
            StartCoroutine(NewSpawnCoin());
            Coin_IS_Spawn = true;
        }   
    }
    IEnumerator NewSpawnCoin()
    {
        while (StartGame.GameIsStart)
        {
            yield return new WaitForSeconds(10f);
            random_position = Random.Range(-2.28f, 2.28f);
            Instantiate(Coin, new Vector2(random_position, 28f), Quaternion.identity);
        }
    }
}
