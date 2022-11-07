using System;

[Serializable]
public abstract class CommandEvironment {
    
    
    public abstract void Do(Cube cube);
    
    public abstract void Undo(Cube cube);
}