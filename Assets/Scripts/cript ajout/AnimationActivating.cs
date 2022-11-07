using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationActivating : CommandCube
{
    public override void Do(Cube cube)
    {
        cube.anim.SetBool("Mouvement", true);
    }

    public override void Undo(Cube cube)
    {
        cube.anim.SetBool("Mouvement", false);
    }
    
}
