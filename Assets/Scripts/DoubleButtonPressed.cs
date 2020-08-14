﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleButtonPressed : MonoBehaviour
{

    public GameObject prefab;
    private long button_pressed_count = 0;
    private long instantiate_object_number = 0;
    private long score = 1;
    public float instantiate_x_max, instantiate_y_max,instantiate_y_min;
    public GameObject gameobject;
    //ボタンが押されたらこの関数を呼び出す
    public void OnClick()
    {
        
        //instantiate_object_number = (long)Mathf.Pow(2.0f, button_pressed_count);
        score *= 2;
        if (button_pressed_count == 0)
        {
            instantiate_object_number++;
        }
        button_pressed_count = (button_pressed_count + 1) % 10;

        instantiate_y_max+=0.3f;
        //instantiate_y_min+=0.3f;
        instantiate_x_max += 0.3f;
        gameobject.transform.position = new Vector3(0, gameobject.transform.position.y+0.2f, gameobject.transform.position.z-0.6f);
        for (long i = 0; i <instantiate_object_number ; i++)
        {
            Instantiate(prefab, new Vector3(Random.Range(-instantiate_x_max,instantiate_x_max), Random.Range(instantiate_y_min,instantiate_y_max),0), Quaternion.identity);
        }
        
    }
}
