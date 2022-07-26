using System.Collections;
using UnityEngine;

public class SpawnerUFO : MonoBehaviour
{
    public GameObject[] UFO;
    private bool UFO_IS_Spawn;
    private float RandomPositionforX;
    private int RandomObjects;


    private void Update()
    {
        if (StartGame.GameIsStart && !UFO_IS_Spawn)
        {
            StartCoroutine(NewSpawnUFO());
            UFO_IS_Spawn = true;
        }
    }


    IEnumerator NewSpawnUFO()

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
    



