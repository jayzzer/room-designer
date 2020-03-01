﻿using System.Collections;

public abstract class State
{
    protected MenuSystem MenuSystem;

    protected State(MenuSystem menuSystem)
    {
        MenuSystem = menuSystem;
    }
    
    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator PlaceObj()
    {
        yield break;
    }

    public virtual IEnumerator ChooseObject()
    {
        yield break;
    }

    public virtual IEnumerator CommitObjPos()
    {
        yield break;
    }

    public virtual IEnumerator ChangeColor()
    {
        yield break;
    }
}