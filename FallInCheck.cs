using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInCheck : MonoBehaviour
{
    public Hole holeRed;
    public Hole holeBlue;
    public Hole holeGreen;

    void OnGUI()
    {
        string strLabel = "";

        if(holeRed.IsFallIn() && holeBlue.IsFallIn() && holeGreen.IsFallIn())
        {
            strLabel = "Fall in hole!";
        }

        GUI.Label(new Rect(0.0f, 0.0f, 100.0f, 30.0f), strLabel);
    }
}
