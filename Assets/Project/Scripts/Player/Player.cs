using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace DungeonGunner {
    [DisallowMultipleComponent]
    #region Requirement Components
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(PolygonCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(SortingGroup))]
    [RequireComponent(typeof(SpriteRenderer))]

    [RequireComponent(typeof(Aim))]
    [RequireComponent(typeof(AimEvent))]
    [RequireComponent(typeof(AnimatorHandler))]
    [RequireComponent(typeof(ControllerHandler))]
    [RequireComponent(typeof(Health))]
    [RequireComponent(typeof(Idle))]
    [RequireComponent(typeof(IdleEvent))]
    [RequireComponent(typeof(MoveByVelocity))]
    [RequireComponent(typeof(MoveByVelocityEvent))]
    [RequireComponent(typeof(MoveToPosition))]
    [RequireComponent(typeof(MoveToPositionEvent))]
    #endregion
    public class Player : MonoBehaviour {
        [HideInInspector] public Animator animator;
        [HideInInspector] public Health health;
        [HideInInspector] public SpriteRenderer spriteRenderer;

        [HideInInspector] public PlayerDetailSO playerDetail;

        [HideInInspector] public AimEvent aimEvent;
        [HideInInspector] public IdleEvent idleEvent;
        [HideInInspector] public MoveByVelocityEvent moveByVelocityEvent;
        [HideInInspector] public MoveToPositionEvent moveToPositionEvent;



        private void Awake() {
            animator = GetComponent<Animator>();
            health = GetComponent<Health>();
            spriteRenderer = GetComponent<SpriteRenderer>();

            aimEvent = GetComponent<AimEvent>();
            idleEvent = GetComponent<IdleEvent>();
            moveByVelocityEvent = GetComponent<MoveByVelocityEvent>();
            moveToPositionEvent = GetComponent<MoveToPositionEvent>();
        }



        public void Init(PlayerDetailSO playerDetail) {
            this.playerDetail = playerDetail;

            SetPlayerHealth();
        }



        private void SetPlayerHealth() {
            health.SetStartingAmount(playerDetail.startingHealthAmount);
        }
    }
}
