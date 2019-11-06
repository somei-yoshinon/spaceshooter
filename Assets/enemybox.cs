using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybox: MonoBehaviour
{
    public GameObject prefab;
    Coroutine coroutine;
    // Start is called before the first frame update
    void Start()
    {
        coroutine=StartCoroutine( CreateEnemy() );
    }


    IEnumerator CreateEnemy()
    {
        while (true) {
            yield return new WaitForSeconds( 1.0f );
            Instantiate(
                prefab,
                new Vector3( Random.Range( -10, 11 ), 1f, 15f ),
                Quaternion.identity
                );
        }
    }

    public void Stop()
    {
        StopCoroutine(coroutine);
        Time.timeScale = 0f;
    }
}