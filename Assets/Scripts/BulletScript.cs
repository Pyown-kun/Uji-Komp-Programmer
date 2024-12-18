using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public ScoreManager ScoreManager;
    [SerializeField] float bulletLifeTime = 3f;

    private void Update()
    {
        bulletLifeTime -= Time.deltaTime;
        if (bulletLifeTime <= 0)
        {
            Destroy(gameObject);
        }

        //Debug.Log(bulletLifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreManager.AddScore(1);
        }
    }
}
