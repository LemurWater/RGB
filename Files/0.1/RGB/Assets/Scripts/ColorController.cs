using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class ColorController : MonoBehaviour
{
    public RGB rgb;

    public Material mat;
    

    public float tmp_time = 0f;
    byte counter = 1;

    // Colors
    Color pink;


    public ColorController()
    {
        this.mat.color = Color.magenta;
    }

    public void Set_Color()
    {
        try
        {
            switch (rgb)
            {
                case RGB.Red:
                    mat.color = Color.red;
                    break;

                case RGB.Green:
                    mat.color = Color.green;
                    break;

                case RGB.Blue:
                    mat.color = Color.blue;
                    break;



                case RGB.White:
                    mat.color = Color.white;
                    break;

                case RGB.Black:
                    mat.color = Color.black;
                    break;


                case RGB.Yellow:
                    mat.color = Color.yellow;
                    break;


                case RGB.Pink:
                    pink.a = 1f;
                    pink.r = 1f;
                    pink.g = 37 / 255f;
                    pink.b = 130/ 255f;

                    mat.color = pink;
                    break;

                case RGB.Magenta:
                    mat.color = Color.magenta;
                    break;

                default:
                    mat.color = Color.magenta;
                    break;
            }
        }
        catch (Exception e)
        {
            throw new Exception("Error set color method" + e);
        }
    }
    public void Set_Color(float time, float interval)
    {
        try
        {
            tmp_time += time;

            if (tmp_time > interval)
            {
                switch (counter)
                {
                    case 1:
                        mat.color = Color.red;
                        counter++;
                        break;

                    case 2:
                        mat.color = Color.green;
                        counter++;
                        break;

                    case 3:
                        mat.color = Color.blue;
                        counter = 1;
                        break;

                    default:
                        mat.color = Color.black;
                        break;
                }
                tmp_time = 0f;
            }
        }
        catch (Exception e)
        {
            throw new Exception("Tile Set_Color(float, float) error" + e);
        }
    }

    public void Set_Color(RGB color)
    {
        try
        {
            rgb = color;

            if (rgb == RGB.Red)
            {
                mat.color = Color.red;
            }
            else if (rgb == RGB.Green)
            {
                mat.color = Color.green;
            }
            else if (rgb == RGB.Blue)
            {
                mat.color = Color.blue;
            }
            else if (rgb == RGB.White)
            {
                mat.color = Color.white;
            }
            else if (rgb == RGB.Black)
            {
                mat.color = Color.black;
            }
        }
        catch (Exception e)
        {
            throw new System.Exception("Error assign color" + e);
        }
    }
}
