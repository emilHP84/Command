using UnityEngine;

public class BackwardCommandCube : CommandCube {
    
    public override void Do(Cube cube) {
        cube.transform.Translate(-Vector3.forward * cube.speed);
    }

    public override void Undo(Cube cube) {
        cube.transform.Translate(Vector3.forward * cube.speed);
    }
    
}