using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMake : MonoBehaviour
{
    public Vector2 GridSize;
    [Space]
    [Space]
    public GameObject BgTileL;
    public GameObject BgTileD;

    public GameObject wallL;
    public GameObject wallR;
    public GameObject wallB;
    public GameObject wallT;

    float TileWidth = 0.576f;

    void Start()
    {
        wallL.transform.position = new Vector2(0 - GridSize.x * TileWidth / 2,0);
        wallR.transform.position = new Vector2(GridSize.x * TileWidth / 2,0);
        wallT.transform.position = new Vector2(0, GridSize.y * TileWidth / 2);
        wallB.transform.position = new Vector2(0, 0 - GridSize.y * TileWidth / 2);


        Vector2 CurrentPos = new Vector2( 0 -GridSize.x * TileWidth/2 + TileWidth/2, 0 - GridSize.y * TileWidth/2 + TileWidth / 2);
        bool isDark=true;

        GameObject Bg = Instantiate(BgTileL,new Vector3(0,0,10),Quaternion.identity, transform.parent = transform);
        Bg.transform.localScale = new Vector2(GridSize.x * 0.9f + 1, GridSize.y * 0.9f + 1);

        for (int i = 0; i < GridSize.y; i++) {

            for (int o = 0; o < GridSize.x; o++)
            {
                if (isDark)
                {
                    Instantiate(BgTileD, CurrentPos, Quaternion.identity, transform.parent = transform);
                    isDark = false;
                }
                else
                {
                    Instantiate(BgTileL, CurrentPos, Quaternion.identity, transform.parent = transform);
                    isDark = true;
                }

                CurrentPos.x += TileWidth;
            }

            if (GridSize.x % 2 == 0) //if even
            {
                if (isDark)
                {
                    isDark = false;
                }
                else
                {
                    isDark = true;
                }
            }

            CurrentPos.x = 0 - GridSize.x * TileWidth / 2 + TileWidth / 2;
            CurrentPos.y += TileWidth;
        }
    }

}
