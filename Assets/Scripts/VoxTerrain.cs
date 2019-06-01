using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxTerrain : MonoBehaviour
{

    public int Size = 20;
    public int Seed = 124;

    private float NoiseFactor = 40f;
    private float ScaleFactor = 16f;

    private Color SandColor = new Color32( 239, 221, 111, 255);
    private Color GrassColor = new Color(0f, .5f, 0f);
    private Color RockColor = new Color32(90, 77, 65, 255);
    private Color SnowColor = new Color32(180, 177,  165, 255);
    private Color WaterColor = new Color32(0, 20, 255, 255);

    private float WaterLevel = 4f;
    private float GrassLevel = 5f;
    private float RockLevel = 8f;
    private float SnowLevel = 10;

    float min = 1000;

    void Start()
    {

        for (int i = 0; i < Size; i++)
        {
            {
                for (int k = 0; k < Size; k++)
                {

                    float h = Mathf.PerlinNoise(Seed + i / NoiseFactor , Seed+ k / NoiseFactor);
                    h = Map(h, 0f, 1f, 0f, ScaleFactor);
                    h = Mathf.Round(h);
                    AddTerrainCube(h, i, k);
                    if( h< min)
                    {
                        min = h;
                    }

                    //AddTerrainCube((h - 1) * 1.0f, i, k);
                    //AddTerrainCube((h-2)*1.0f , i, k);


                }

            }

        }

        Debug.Log(min);
    }

    float Map(float mapValue, float mapRangeMin, float mapRangeMax, float targetRangeMin, float targetRangeMax)
    {

        float targetRange = targetRangeMax - targetRangeMin;
        float mapRange = mapRangeMax - mapRangeMin;
        float percent = mapValue / mapRange;
        float targetValue = (percent * targetRange) + targetRangeMin;

        return targetValue;

    }

    void AddTerrainCube(float h , int i, int k) 
    {

        Color voxColor = SandColor;
        if (h > GrassLevel)
        {
            voxColor = GrassColor;
        }
        if (h > RockLevel)
        {
            voxColor = RockColor;
        }
        if (h > SnowLevel)
        {
            voxColor = SnowColor;
        }
        if (h < WaterLevel)
        {
            voxColor = WaterColor;
            h = WaterLevel;
        }

        VoxelTools.MakeCube(i, h, k, voxColor);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            VoxelTools.MakeAllCubesFall();
        }

    }
}
