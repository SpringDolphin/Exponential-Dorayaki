using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    //ボタンが押されたらこの関数を呼び出す
    public void OnClick()
    {

        SceneManager.LoadScene("SampleScene");

    }
}
