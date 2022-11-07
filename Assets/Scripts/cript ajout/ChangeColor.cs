using UnityEngine;

public class ChangeColor : CommandCube
{
    private GameObject _objectChangeColor;
    private Material _changingColor;
    
    public override void Do(Cube cube)
    {
        cube.AmmoPrefab.GetComponent<Renderer>().sharedMaterial.color = Color.black;
    }

    public override void Undo(Cube cube)
    {
        cube.AmmoPrefab.GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}
