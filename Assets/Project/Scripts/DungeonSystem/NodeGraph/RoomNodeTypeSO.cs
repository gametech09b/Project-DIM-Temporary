using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonGunner
{
    [CreateAssetMenu(fileName = "RoomNodeTypeSO_", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
    public class RoomNodeTypeSO : ScriptableObject
    {
        public string roomNodeTypeName;

        #region Header
        [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
        #endregion
        public bool displayInNodeGraphEditor = true;

        #region Header
        [Header("One Type should be a Corridor")]
        #endregion
        public bool isCorridor;

        #region Header
        [Header("One Type should be a CorridorNS (North South)")]
        #endregion
        public bool isCorridorNS;

        #region Header
        [Header("One Type should be a CorridorEW (East West)")]
        #endregion
        public bool isCorridorEW;

        #region Header
        [Header("One Type should be a Entrance")]
        #endregion
        public bool isEntrance;

        #region Header
        [Header("One Type should be a Boss Room")]
        #endregion
        public bool isBossRoom;

        #region Header
        [Header("One Type should be None (unassigned)")]
        #endregion
        public bool isNone;



        #region Validation
#if UNITY_EDITOR
        private void OnValidate()
        {
            HelperUtilities.CheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
        }
#endif
        #endregion
    }
}
