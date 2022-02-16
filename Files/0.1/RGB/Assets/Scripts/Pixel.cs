using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pixel : ColorController
{
    public short id;
    public byte posX;
    public byte posY;

    public Pixel(short id, byte posX, byte posY, RGB rgb)
    {
        this.id = id;
        this.posX = posX;
        this.posY = posY;
        this.rgb = rgb;
    }
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            mat.color = Color.black;
        }
        catch (Exception e)
        {
            throw new Exception("Pixel Start error" + e);
        }
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            Set_Color();
            //Set_Color(0.01f, 3.2f);
        }
        catch (Exception e)
        {
            throw new Exception("Pixel Update error" + e);
        }
    }
}
