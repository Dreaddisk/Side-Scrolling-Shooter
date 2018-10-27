using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    #region Variables
    public float enemySpeed = 0.6f;
    #endregion

    private void Update()
    {
        MoveEnemyToLeft();
    }
    void MoveEnemyToLeft()
    {
        transform.Translate(-enemySpeed, 0, 0);

    }

} // main class
