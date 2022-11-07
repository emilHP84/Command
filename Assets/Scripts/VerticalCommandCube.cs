using UnityEngine;

public class VerticalCommandCube : CommandCube {

    private readonly float _axeValue;

    public VerticalCommandCube(float axeValue) {
        _axeValue = axeValue;
    }

    public override void Do(Cube cube) {
        cube.transform.Translate(Vector3.forward * _axeValue * cube.speed);
    }

    public override void Undo(Cube cube) {
        cube.transform.Translate(-Vector3.forward * _axeValue * cube.speed);
    }
    
}