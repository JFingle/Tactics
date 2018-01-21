using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;



public class InfoEventsArgs<T> : EventArgs
{

    public T info;

    public InfoEventsArgs()
    {
        info = default(T);
    }

    public InfoEventsArgs(T info)
    {
        this.info = info;
    }
}


