// MR Starter Kit - Children's Mercy KC
// Copyright 2018 Children’s Mercy Hospital. All rights reserved.
// Licensed under the Apache License. See LICENSE in the project root for license information.

using Assets.Scripts;
using HoloToolkit.Unity.InputModule;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for adding custom Manipulation behavior.
/// </summary>
[RequireComponent(typeof(Renderer))]
public class Manipulable : MonoBehaviour, ISpeechHandler, IFocusable, IManipulationHandler, IInputClickHandler
{
    //This emum keeps track of how deep a mesh is as compare to top most parent object. 
    //Use 1 for meshes directly under the parent model.
    //Use 2 if mesh is 2 layers deep and so on.
    //If MeshDepth is not set properly, system will fire Transform actions on currently focused mesh group.
    public enum MeshDepth { One = 1, Two = 2, Three = 3 };
    [Tooltip("How many layers is this object from the top most parent.")]
    public MeshDepth depth = MeshDepth.One;

    private Scalable scalable;
    public Selectable selectable;
    private Rotatable rotatable;
    private Vector3 objectPosition;

    //To keep track of diabled meshes/elements.
    private static Stack<Renderer> listOfDisabled = new Stack<Renderer>();

    private void Awake()
    {
        scalable = new Scalable(this, (int)depth);
        selectable = new Selectable(this);
        rotatable = new Rotatable(this);
        objectPosition = this.transform.position;
    }

    //Public APIs to be used by Button OnClick event in Unity.
    public void ScaleUp()
    {
        scalable.ScaleUp((int)depth);
    }

    public void ScaleDown()
    {
        scalable.ScaleDown((int)depth);
    }

    public void RotateLeft()
    {
        rotatable.RotateLeft((int)depth);
    }

    public void RotateRight()
    {
        rotatable.RotateRight((int)depth);
    }

    public void RotateUp()
    {
        rotatable.RotateUp((int)depth);
    }

    public void RotateDown()
    {
        rotatable.RotateDown((int)depth);
    }

    public void UndoLastHide()
    {
        if (listOfDisabled.Count > 0)
            listOfDisabled.Pop().gameObject.SetActive(true);
    }

    public void ResetAll()
    {
        foreach (Renderer disabled in listOfDisabled)
        {
            disabled.gameObject.SetActive(true);
        }
        listOfDisabled.Clear();
    }

    //Event handlers
    public void OnFocusEnter()
    {
        selectable.Enter();
    }

    public void OnFocusExit()
    {
        selectable.Exit();
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        HideElement();
    }

    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        switch (eventData.RecognizedText.ToLower())
        {
            case "size up":
                scalable.ScaleUp((int)depth);
                break;
            case "size down":
                scalable.ScaleDown((int)depth);
                break;
            case "hide this":
                HideElement();
                break;
            case "rotate left":
                rotatable.RotateLeft((int)depth);
                break;
            case "rotate right":
                rotatable.RotateRight((int)depth);
                break;
            case "rotate up":
                rotatable.RotateUp((int)depth);
                break;
            case "rotate down":
                rotatable.RotateDown((int)depth);
                break;
            case "learn voice commands":
                GameObject.FindGameObjectWithTag("Help").SetActive(true);
                break;
            case "reset all":
                ResetAll();
                break;
            case "undo hide":
                UndoLastHide();
                break;
        }
    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        //Functionality Not Needed
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        //Functionality Not Needed
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        //Functionality Not Needed
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        float x = eventData.CumulativeDelta.x;
        float y = eventData.CumulativeDelta.y;
        float z = eventData.CumulativeDelta.z;

        float distanceX = Mathf.Abs(x);
        float distanceY = Mathf.Abs(y);
        float distanceZ = Mathf.Abs(z);

        Vector3 currentCameraPosition = Camera.main.transform.position;
        Vector3 distance = objectPosition - currentCameraPosition;

        //Z axis tells us if camera is infront or behind the model.
        bool behindModel = distance.z < 0 ? true : false;

        if (distanceX > distanceY && distanceX > distanceZ)
        {
            if (!behindModel)
            {
                if (x < 0)
                {
                    rotatable.RotateLeft((int)depth, 1);
                }
                else
                {
                    rotatable.RotateRight((int)depth, 1);
                }
            }
            else
            {
                if (x < 0)
                {
                    rotatable.RotateRight((int)depth, 1);
                }
                else
                {
                    rotatable.RotateLeft((int)depth, 1);
                }
            }
        }
        else if (distanceY > distanceX && distanceY > distanceZ)
        {
            if (y < 0)
            {
                rotatable.RotateDown((int)depth, 1);
            }
            else
            {
                rotatable.RotateUp((int)depth, 1);
            }
        }
    }

    private void HideElement()
    {
        var renderer = GetComponent<Renderer>();
        renderer.gameObject.SetActive(!renderer.enabled);
        listOfDisabled.Push(renderer);
    }
}
