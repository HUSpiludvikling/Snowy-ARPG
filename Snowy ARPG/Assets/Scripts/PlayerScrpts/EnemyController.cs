﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Transform playerPosition;

    void Update()
    {
        if (playerPosition != null)
        {
            transform.LookAt(playerPosition);
        }
    }
}