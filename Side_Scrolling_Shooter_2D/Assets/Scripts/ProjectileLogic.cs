using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    #region Variables
    public float projectileSpeed = 1.2f;

    #endregion

    private void Update()
    {
        MoveProjectileRight();
    }

    void MoveProjectileRight()
    {
        transform.Translate(projectileSpeed, 0, 0);
    }

} // main class
