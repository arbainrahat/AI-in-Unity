﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    Vector2 screenBounds;
    private float objectWidth;
    private float objectHieght;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHieght = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x,screenBounds.x+objectWidth,screenBounds.x*-1-objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y+objectHieght, screenBounds.y * -1-objectHieght);
        transform.position = viewPos;

    }
}
