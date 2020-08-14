using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject DoubleButton;
    DoubleButtonPressed db;
    public GameObject ScoreText=null;
    // Start is called before the first frame update
    void Start()
    {
        db = DoubleButton.GetComponent<DoubleButtonPressed>();
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = ScoreText.GetComponent<Text>();
        score_text.text = "スコア:" + db.score;
    }
}
