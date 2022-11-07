using UnityEngine;

public class RightCommandHand : CommandCube
{

    private GameObject _instantiated;
    //private float _speed;

    public override void Do(Cube cube)
    {
        _instantiated = Object.Instantiate(cube.AmmoPrefab, cube.CanonOut.transform);
        //cube.AmmoPrefab.transform.Rotate(Vector3.up * _speed * Time.deltaTime)
    }




    public override void Undo(Cube cube)
    {
        Object.Destroy(_instantiated);
    }
}