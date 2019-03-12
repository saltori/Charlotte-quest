using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textManager : SingletonMonoBehaviour<textManager>
{
    public static textManager instance = null;

    //  テキストファイルのパス
    private const string Story = "Story/Scenario";

    // 次に映すテキストファイルの名前
    private string _nextStory;

    // テキストファイルの保持
    private Dictionary<string, TextAsset> _story;
    private void Awake()
    {
        // インスタンスが存在するとき
        if (instance != null)
        {
            // これを破棄する
            Destroy(this.gameObject);
            return;
        }
        // インスタンスが存在しない時
        else if (instance == null)
        {
            // これをインスタンスとする
            instance = this;
        }
        // シーンをまたいでも消去されないようにする
        DontDestroyOnLoad(this.gameObject);
        // リソースフォルダからファイルを読み込み,セット
        _story = new Dictionary<string, TextAsset>();

        object[] storyList = Resources.LoadAll(Story);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}

    public void playText(string storyName)
    {
        if(!_story.ContainsKey(storyName))
        {
            Debug.Log(storyName + "という名前のテキストファイルがありません");
            return;
        }
        _nextStory = storyName;
    }
}
