﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commandMenu : MonoBehaviour
{

    public bool actFlag/* = true*/;
    public static bool flag;

    // Use this for initialization
    void Start()
    {
        actFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        flag = actFlag;
    }

    public void menuBotton()
    {
        if (actFlag)
        {
            actFlag = false;
        }
        else
        {
            actFlag = true;
        }
        //switch (actFlag)
        //{
        //    case true:
        //        actFlag = false;
        //        break;
        //    case false:
        //        actFlag = true;
        //        break;
        //    default:
        //        break;
        //}
    }
}