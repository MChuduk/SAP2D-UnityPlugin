using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAP2D
{
    [CreateAssetMenu(fileName = "New Pathfiding Config", menuName = "SAP2D/Pathfinding Config", order = 1)]
    public class SAP2DPathfindingConfig : ScriptableObject
    {
        public int GridIndex;
        public bool CutCorners;
        public bool CallbackPathFound; // whether or not we want to trigger an event if the path cannot be found
    }
}
