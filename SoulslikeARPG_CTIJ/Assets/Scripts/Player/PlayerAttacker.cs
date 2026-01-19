using System.ComponentModel.Design;
using UnityEngine;

namespace Souls
{
    public class PlayerAttacker : MonoBehaviour
    {
        AnimationHandler animationHandler;
        PlayerManager playerManager;
        PlayerStats playerStats;
        PlayerInventory playerInventory;
        WeaponSlotManager weaponSlotManager;
        InputHandler inputHandler;

        private void Awake()
        {
            animationHandler = GetComponent<AnimationHandler>();
            playerManager = GetComponentInParent<PlayerManager>();
            playerStats = GetComponentInParent<PlayerStats>();
            playerInventory = GetComponentInParent<PlayerInventory>();
            weaponSlotManager = GetComponent<WeaponSlotManager>();
            inputHandler = GetComponentInParent<InputHandler>();
        }

        public void HandleLightAttack(WeaponItem weapon)
        {
            weaponSlotManager.attackingWeapon = weapon;
            if (inputHandler.twoHandFlag)
            {
                animationHandler.PlayTargetAnimation(weapon.TH_Light_Attack_1, true);
            }
            else
            {
                animationHandler.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
            }
        }

        public void HandleHeavyAttack(WeaponItem weapon)
        {
            weaponSlotManager.attackingWeapon = weapon;
            if (inputHandler.twoHandFlag)
            {
                animationHandler.PlayTargetAnimation(weapon.TH_Heavy_Attack_1, true);
            }
            else
            {
                animationHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_1, true);
            }
        }
        #region Input Actions
        public void HandleRBAction()
        {
            if (playerInventory.rightWeapon.isMeleeWeapon)
            {
                PerformRBMeleeAction();
            }
            else if (playerInventory.rightWeapon.isSpellCaster || playerInventory.rightWeapon.isFaithCaster || playerInventory.rightWeapon.isPyroCaster)
            {
                PerformRBMagicAction(playerInventory.rightWeapon);
            }
        }

        #endregion

        #region Attack Actions
        private void PerformRBMeleeAction()
        {
            HandleLightAttack(playerInventory.rightWeapon);
            animationHandler.anim.SetBool("isUsingRightHand", true);
        }

        private void PerformRBMagicAction(WeaponItem weapon)
        {
            if (weapon.isFaithCaster)
            {
                if (playerInventory.currentSpell != null && playerInventory.currentSpell.isFaithSpell)
                {
                    playerInventory.currentSpell.AttemptToCastSpell(animationHandler, playerStats);
                }
            }
        }

        private void SuccessfullyCastSpell()
        {
            playerInventory.currentSpell.SuccessfullyCastSpell(animationHandler, playerStats);
        }
        #endregion
    }
}
