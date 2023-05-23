using PaintIn3D;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace FIMSpace.FTail
{
    public partial class TailAnimator2
    {
        List<P3dHitBetween> hitColliders = new List<P3dHitBetween>();
        
        void ColorSetup()
        {
            for (int i = 1; i < _TransformsGhostChain.Count - 1; i++)
            {
                SpawnColorSphere spawnColorSphere = _TransformsGhostChain[i].gameObject.AddComponent<SpawnColorSphere>();
            }
        }

    }
}