using UnityEngine;

public class HorizontalCommandCube : CommandCube {

    private float _axeValue;

    public HorizontalCommandCube(float axeValue) {
        _axeValue = axeValue;
    }

    public override void Do(Cube cube) {
        cube.transform.Translate(Vector3.right * _axeValue * cube.speed);
    }

    public override void Undo(Cube cube) {
        cube.transform.Translate(-Vector3.right * _axeValue * cube.speed);
    }
    
}