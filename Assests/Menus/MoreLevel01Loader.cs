﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreLevel01Loader : MonoBehaviour
{
    
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene("Level 01 more");
        }
    }

}
