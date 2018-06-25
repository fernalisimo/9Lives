using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryConditions : MonoBehaviour
{

    public String levelName;

    public bool checkVictoryConditions()
    {
        if (levelName.Equals("BossLevel"))
        {
            if (Boss.lastBoss.IsDefeated())
            {
                return true;
            }
        }

        return false;
    }
}
