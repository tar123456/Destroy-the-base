using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_LevelControl : MonoBehaviour
{
    // Start is called before the first frame update
    S_enemy[] enemies;
    static int levelNum = 1;
    
    string levelName;

    private void OnEnable()
    {
        enemies = FindObjectsOfType<S_enemy>();
    }

    // Update is called once per frame
    void Update()
    {

        foreach (S_enemy enemy in enemies)
        {
            if (enemy != null)
            {
                return;
            }


        }

        if (levelNum >= 3)
        {
            levelName = "Level1";

        }

        else
        {
            levelNum++;
            levelName = "Level" + levelNum;
        }
       
        SceneManager.LoadScene(levelName);

        


    }
}
