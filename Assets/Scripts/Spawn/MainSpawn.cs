using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Spawn
{
    public class MainSpawn : MonoBehaviour
    {
        private protected void SpawnStart(bool check, IEnumerator enumerator)
        {
            if (StartGame.GameIsStart && !check)
            {
                StartCoroutine(enumerator);
                check = true;
            }
        }
    }
}