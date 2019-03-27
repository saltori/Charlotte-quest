using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATKListInvisible : MonoBehaviour
{
    public int actFlag;

    void Start()
    {
        actFlag = 0;
    }

    // テキストの表示・非表示の切り替え
    public void ChangeEnabled(Text textComponent)
    {
        actFlag = SelectList.num;
        if (actFlag == 1)
        {
            textComponent.enabled = true;
        }
        else
        {
            textComponent.enabled = false;
        }
    }
}
