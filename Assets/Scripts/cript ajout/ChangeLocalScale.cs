using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLocalScale : CommandCube
{
    public override void Do(Cube cube)
    {
        cube.AmmoPrefab.transform.localScale = new Vector3(1.2f, 1, 1);
    }
    
    public override void Undo(Cube cube)
    {
        cube.AmmoPrefab.transform.localScale = new Vector3(1, 1, 1);
    }
}
