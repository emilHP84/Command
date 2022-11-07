using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActivating : CommandCube
{
    public override void Do(Cube cube)
    {
        cube.Light.SetActive(true);
    }
    
    public override void Undo(Cube cube)
    {
        cube.Light.SetActive(false);
    }
    
 
}
