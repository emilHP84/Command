using System;

[Serializable]
public abstract class CommandCube {

    public abstract void Do(Cube cube);
    public abstract void Undo(Cube cube);

}