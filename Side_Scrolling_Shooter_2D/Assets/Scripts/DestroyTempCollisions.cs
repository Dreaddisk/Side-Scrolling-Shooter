using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTempCollisions : MonoBehaviour
{
    public GameObject particles;
    private void OnCollisionEnter2D(Collision2D tempcollision)
    {
        if(tempcollision.gameObject.tag == "Collision")
        {
            Destroy(tempcollision.gameObject);
            SpawnParticles(tempcollision.transform.position);
        }
    }

    void SpawnParticles(Vector2 tempPosition)
    {
        Instantiate(particles, tempPosition, Quaternion.identity);
    }
}
