using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOpacity : CommandCube
{
    public override void Do(Cube cube)
    {
        cube.Ground.transform.GetComponent<Renderer>().material.SetColor("_Color", new Color(1,1,1,0.1f));
    }


    public override void Undo(Cube cube)
    {
        cube.Ground.transform.GetComponent<Renderer>().material.SetColor("_Color", new Color(1,1,1,1.0f));
    }
}
