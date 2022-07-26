using System.Collections;
using UnityEngine;

public class ElectroBoom : MonoBehaviour
{
    public GameObject Electro;
    private bool Electro_IS_Spawn;
    private float RandomPositionforX;

    private void Update()
    {
        if (StartGame.GameIsStart && !Electro_IS_Spawn)
        {
            StartCoroutine(NewSpawnElectro());
            Electro_IS_Spawn = true;
        }
    }

    IEnumerator NewSpawnElectro()

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


