using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocInfintyForward : CommandCube
{
    public override void Do(Cube cube)
    {
        cube.CubeInfinity.transform.Translate(Vector3.forward * cube.speedInfinity);
    }
    public override void Undo(Cube cube)
    {
        cube.CubeInfinity.transform.Translate(Vector3.back * cube.speedInfinity);
    }
}
