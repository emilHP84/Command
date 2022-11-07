using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiActivating : CommandCube
{

    public override void Do(Cube cube)
    {
        cube.Ui.SetActive(true);
    }
    public override void Undo(Cube cube)
    {
        cube.Ui.SetActive(false);
    }
}
