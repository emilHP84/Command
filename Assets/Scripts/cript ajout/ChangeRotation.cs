using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : CommandCube
{

    public override void Do(Cube cube)
    {
        cube.AmmoPrefab.transform.rotation = Quaternion.Euler(0,0,25 );
    }

    public override void Undo(Cube cube)
    {
        cube.AmmoPrefab.transform.rotation = Quaternion.Euler(0,0,-25 );
    }
}
