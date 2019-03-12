using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class title : MonoBehaviour
{

    Image image;
    int FlashingCnt;

    bool soundFlag;

    Color color1 = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    Color color2 = new Color(1.0f, 1.0f, 1.0f, 0.0f);

    // Use this for initialization
    void Start()
    {
        FlashingCnt = 0;
        image = GetComponent<Image>();
        soundFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (soundFlag)
        {

            FlashingCnt++;
            if (FlashingCnt / 30 % 2 == 0)
            {
                image.color = color1;
            }
            else
            {
                image.color = color2;
            }
            if (Input.GetMouseButtonDown(0))
            {
                Title();
            }
        }
    }
    public void Title()
    {
        if (soundFlag)
        {
            AudioManager.Instance.PlaySE("タイトルから進む時");
            SceneNavigator.Instance.Change("ホーム");
            soundFlag = false;
        }
    }
}
