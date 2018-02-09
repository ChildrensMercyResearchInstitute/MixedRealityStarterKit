// MR Starter Kit - Children's Mercy KC
// Copyright 2018 Children’s Mercy Hospital. All rights reserved.
// Licensed under the Apache License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Class for adding custom Scaling feature.
    /// </summary>
    public class Scalable
    {
        private Vector3 originalSize;
        private float current;
        private MonoBehaviour _source;

        //Adjust Scale Size for bigger/smaller scale.
        private const float scaleSize = 0.1f;
        float STEP { get { return scaleSize * originalSize.x; } }

        public Scalable(MonoBehaviour source, int depth)
        {
            _source = source;
            switch(depth)
            {
                case 2:
                    originalSize = source.transform.parent.parent.localScale;
                    break;
                case 3:
                    originalSize = source.transform.parent.parent.parent.localScale;
                    break;
                default :
                    originalSize = source.transform.parent.localScale;
                    break;
            }
            current = originalSize.x;
        }

        public void ScaleUp(int depth)
        {
            current += STEP;
            switch (depth)
            {
                case 2:
                    _source.transform.parent.parent.localScale = new Vector3(current, current, current);
                    break;
                case 3:
                    _source.transform.parent.parent.parent.localScale = new Vector3(current, current, current);
                    break;
                default:
                    _source.transform.parent.localScale = new Vector3(current, current, current);
                    break;
            }
        }
        public void ScaleDown(int depth)
        {
            current += -STEP;
            switch (depth)
            {
                case 2:
                    _source.transform.parent.parent.localScale = new Vector3(current, current, current);
                    break;
                case 3:
                    _source.transform.parent.parent.parent.localScale = new Vector3(current, current, current);
                    break;
                default:
                    _source.transform.parent.localScale = new Vector3(current, current, current);
                    break;
            }
        }
    }
}
