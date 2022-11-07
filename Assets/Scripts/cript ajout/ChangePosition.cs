using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : CommandCube
{
    public override void Do(Cube cube)
    {
        cube.AmmoPrefab.transform.position = new Vector3(0, 0, 1);
    }
    public override void Undo(Cube cube)
    { 
        cube.AmmoPrefab.transform.position = new Vector3(0, 0, -1);
    }
    
}
