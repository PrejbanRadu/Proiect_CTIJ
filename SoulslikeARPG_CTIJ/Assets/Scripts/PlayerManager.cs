using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Souls
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator anim;
        CameraHandler cameraHandler;
        PlayerMovement playerMovement;

        public bool isInteracting;

        [Header("Player Flags")]
        public bool isSprinting;
        public bool isInAir;
        public bool isGrounded;

        void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            anim = GetComponentInChildren<Animator>();
            playerMovement = GetComponent<PlayerMovement>();
            cameraHandler = CameraHandler.singleton;
        }

        void Update()
        {
            float delta = Time.deltaTime;
            isInteracting = anim.GetBool("isInteracting");

            inputHandler.TickInput(delta);
            playerMovement.HandleMovement(delta);
            playerMovement.HandleRollingAndSprinting(delta);
            playerMovement.HandleFalling(delta, playerMovement.moveDirection);
        }

        private void FixedUpdate()
        {
            float delta = Time.fixedDeltaTime;

            if (cameraHandler != null)
            {
                cameraHandler.FollowTarget(delta);
                cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
            }
        }

        private void LateUpdate()
        {
            inputHandler.rollFlag = false;
            inputHandler.sprintFlag = false;
            inputHandler.rb_Input = false;
            inputHandler.rt_Input = false;

            if (isInAir)
            {
                playerMovement.inAirTimer = playerMovement.inAirTimer + Time.deltaTime;
            }
        }
    }
}


