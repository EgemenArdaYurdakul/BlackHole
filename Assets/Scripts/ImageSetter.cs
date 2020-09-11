﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSetter : MonoBehaviour
{
    Image image;
    public Sprite[] lvlImages;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();   
    }

    // Update is called once per frame
    void Update()
    {
        image.sprite = lvlImages[GameManager.currentLevel - 1];
    }
}
