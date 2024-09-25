using System;

public interface IEffect
{
    public void Effect()
    {
        throw new NotImplementedException();
    }

    public void Effect(Fighter target)
    {
        throw new NotImplementedException();
    }

    public void Effect(Fighter[] targets)
    { 
        throw new NotImplementedException(); 
    }
}
