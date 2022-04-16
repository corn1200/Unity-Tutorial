﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    // c#은 기본 접근자가 private이다.
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
    }

    public  string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level = level + 1;
    }
}
