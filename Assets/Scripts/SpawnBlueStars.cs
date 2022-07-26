using System.Collections;
using UnityEngine;

public class SpawnBlueStars : MonoBehaviour
{
    public GameObject BlueStar;
    private bool Star_IS_Spawn;
    private float random_position;


    private void Update()
    {
        if (StartGame.GameIsStart && !Star_IS_Spawn)
        {
            StartCoroutine(NewSpawnStar());
            Star_IS_Spawn = true;
        }
    }

    IEnumerator NewSpawnStar()
    {
        while (StartGame.GameIsStart)
        {
            yield return new WaitForSeconds(40f);
            random_position = Random.Range(-2.28f, 2.28f);
            Instantiate(BlueStar, new Vector2(random_position, 28f), Quaternion.identity);
        }
    }
}
