// MR Starter Kit - Children's Mercy KC
// Copyright 2018 Children’s Mercy Hospital. All rights reserved.
// Licensed under the Apache License. See LICENSE in the project root for license information.

using UnityEngine;

/// <summary>
/// Class for adding rotation capability to objects.
/// </summary>
public class Rotatable
{
    //Define the maximum rotaion in one direction.
    //0 will allow no rotation. Maxvalue will allow complete rotation.
    private float MAX = float.MaxValue;

    private float leftRotate = 0;
    private float rightRotate = 0;
    private float upRotate = 0;
    private float downRotate = 0;

    private MonoBehaviour _source;

    public Rotatable(MonoBehaviour source)
    {
        _source = source;
    }

    public void RotateLeft(int depth, float step = 10)
    {
        if (leftRotate < MAX)
        {
            leftRotate += step;
            rightRotate -= step;

            if (depth == 1)
            {
                _source.transform.parent.transform.Rotate(new Vector3(0, step, 0));
            }
            else if(depth == 2)
            {
                _source.transform.parent.parent.transform.Rotate(new Vector3(0, step, 0));
            }
            else if (depth == 3)
            {
                _source.transform.parent.parent.parent.transform.Rotate(new Vector3(0, step, 0));
            }
        }
    }

    public void RotateRight(int depth, float step = 10)
    {
        if (rightRotate < MAX)
        {
            leftRotate -= step;
            rightRotate += step;

            if (depth == 1)
            {
                _source.transform.parent.transform.Rotate(new Vector3(0, -step, 0));
            }
            else if (depth == 2)
            {
                _source.transform.parent.parent.transform.Rotate(new Vector3(0, -step, 0));
            }
            else if (depth == 3)
            {
                _source.transform.parent.parent.parent.transform.Rotate(new Vector3(0, -step, 0));
            }
        }
    }

    public void RotateUp(int depth, float step = 10)
    {
        if (upRotate < MAX)
        {
            upRotate += step;
            downRotate -= step;
            if (depth == 1)
            {
                _source.transform.parent.transform.Rotate(new Vector3(step, 0, 0));
            }
            else if(depth == 2)
            {
                _source.transform.parent.parent.transform.Rotate(new Vector3(step, 0, 0));
            }
            else if (depth == 3)
            {
                _source.transform.parent.parent.transform.Rotate(new Vector3(step, 0, 0));
            }
        }
    }
    public void RotateDown(int depth, float step = 10)
    {
        if (downRotate < MAX)
        {
            upRotate -= step;
            downRotate += step;
            if (depth == 1)
            {
                _source.transform.parent.transform.Rotate(new Vector3(-step, 0, 0));
            }
            else if(depth == 2)
            {
                _source.transform.parent.parent.transform.Rotate(new Vector3(-step, 0, 0));
            }
            else if (depth == 3)
            {
                _source.transform.parent.parent.transform.Rotate(new Vector3(-step, 0, 0));
            }
        }
    }

}
