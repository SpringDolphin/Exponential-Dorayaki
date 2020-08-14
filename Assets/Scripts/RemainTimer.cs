using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RemainTimer : MonoBehaviour
{
    public GameObject DoubleButton;
    public GameObject RetryButton;
    DoubleButtonPressed db;
    public float gameTime = 10.0f;        // ゲーム制限時間 [s]
    Text uiText;                                    // UIText コンポーネント
    float currentTime;                              // 残り時間タイマー
    

    void Start()
    {
        // Textコンポーネント取得
        uiText = GetComponent<Text>();
        // 残り時間を設定
        currentTime = gameTime;
        db = DoubleButton.GetComponent<DoubleButtonPressed>();
    }

    void Update()
    {
        // 残り時間を計算する
        if (db.play_now == true){
            currentTime -= Time.deltaTime;
        }
        

        // ゼロ秒以下にならないようにする
        if (currentTime <= 0.0f)
        {
            currentTime = 0.0f;
            DoubleButton.SetActive(false);
            RetryButton.SetActive(true);

        }
        int minutes = Mathf.FloorToInt(currentTime / 60F);
        int seconds = Mathf.FloorToInt(currentTime - minutes * 60);
        int mseconds = Mathf.FloorToInt((currentTime - minutes * 60 - seconds) * 1000);
        //uiText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, mseconds);
        uiText.text = string.Format("残り時間:{0:00}:{1:000}",  seconds, mseconds);
    }
}
