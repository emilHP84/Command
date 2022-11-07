using UnityEngine;

public class RightCommandCube : CommandCube {
    
    public override void Do(Cube cube) {
        cube.transform.Translate(Vector3.right * cube.speed);
    }

    public override void Undo(Cube cube) {
        cube.transform.Translate(-Vector3.right * cube.speed);
    }
    
}