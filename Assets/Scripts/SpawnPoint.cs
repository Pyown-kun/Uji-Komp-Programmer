using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrefeb;

    [SerializeField] private float timeSpawn = 2f;


    private void Update()
    {
        timeSpawn -= Time.deltaTime;

        if (timeSpawn <= 0)
        {
            GameObject enemy = Instantiate(enemyPrefeb, gameObject.transform.position, gameObject.transform.rotation);

            timeSpawn = 2;
        }

        Debug.Log(timeSpawn);
    }
}
