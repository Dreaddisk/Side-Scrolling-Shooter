using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    #region Variables
    public float playerSpeed = 3.0f;
    public GameObject projectile;

    float maxPlayerY = 7.0f;
    float maxPlayerX = 25.0f;
    #endregion

    private void Update()
    {
        PlayerMovement();
        KeyThenSpawnProjectile();
    }

    void PlayerMovement()
    {
        if(Input.GetKey(KeyCode.W) && transform.position.y <= maxPlayerY)
        {
            transform.Translate(0, playerSpeed, 0);
        }
        if(Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerX)
        {
            transform.Translate(-playerSpeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.S) && transform.position.y >= -maxPlayerY)
        {
            transform.Translate(0, -playerSpeed, 0);
        }
        if(Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerX)
        {
            transform.Translate(playerSpeed, 0, 0);
        }
    }

    void KeyThenSpawnProjectile()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnProjectile();
        }
    }

    void SpawnProjectile()
    {
        Instantiate(projectile, new Vector3
            (transform.position.x,
            transform.position.y),
            Quaternion.identity);
    }
}// main class
