using System.Collections;
using UnityEngine;

public class ShootingStarSpawn : MonoBehaviour
{
    public GameObject[] ShootingStar;
    private bool ShootingStars_IS_Spawn;
    private int RandomObjects;
    private float RandomPositionforX;

    private void Update()
    {
        if (StartGame.GameIsStart && !ShootingStars_IS_Spawn)
        {
            StartCoroutine(NewSpawnShootingStars());
            ShootingStars_IS_Spawn = true;
        }

        
    }


    IEnumerator NewSpawnShootingStars()

    {
        yield return new WaitForSeconds(20f);
        RandomObjects = Random.Range(0, ShootingStar.Length);
        RandomPositionforX = Random.Range(-4.74f, -1.73f);
        Instantiate(ShootingStar[RandomObjects], new Vector2(RandomPositionforX, 29f), Quaternion.Euler(new Vector3(0, 0, 27f)));
    }
}