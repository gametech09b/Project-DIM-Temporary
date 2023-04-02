using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonGunner {
    public static class Settings {
        #region Units
        public const float pixelPerUnit = 16f;
        public const float tileSizePixel = 16f;
        #endregion



        #region Dungeon Builder Settings
        public const int maxDungeonBuildAttempts = 10; // Max number of attempts to build the dungeon
        public const int maxDungeonRoomRebuildAttempts = 1000; // Max number of attempts to rebuild the dungeon for room graph
        #endregion



        #region Room Settings
        public const int maxChildCorridors = 3; // Max number of child corridors per room
        #endregion



        #region Animator Parameters - Player
        public static int AimUp = Animator.StringToHash("aimUp");
        public static int AimUpRight = Animator.StringToHash("aimUpRight");
        public static int AimUpLeft = Animator.StringToHash("aimUpLeft");
        public static int AimRight = Animator.StringToHash("aimRight");
        public static int AimDown = Animator.StringToHash("aimDown");
        public static int AimLeft = Animator.StringToHash("aimLeft");

        public static int IsIdle = Animator.StringToHash("isIdle");
        public static int IsMoving = Animator.StringToHash("isMoving");

        public static int RollUp = Animator.StringToHash("rollUp");
        public static int RollRight = Animator.StringToHash("rollRight");
        public static int RollDown = Animator.StringToHash("rollDown");
        public static int RollLeft = Animator.StringToHash("rollLeft");
        #endregion



        #region Animator Parameters - Door
        public static int IsOpen = Animator.StringToHash("isOpen");
        #endregion



        #region GameObject Tags
        public const string PlayerTag = "Player";
        public const string PlayerWeaponTag = "playerWeapon";
        #endregion
    }
}
