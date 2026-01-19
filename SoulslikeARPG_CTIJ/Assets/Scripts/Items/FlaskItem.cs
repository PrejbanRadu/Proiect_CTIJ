//using UnityEngine;

//namespace Souls
//{
//    [CreateAssetMenu(menuName = "Items/Consumables/Flask")]
//    public class FlaskItem : ConsumableItem
//    {
//        [Header("Flask Type")]
//        public bool estusFlask;
//        public bool ashenFlask;

//        [Header("Recovery Amount")]
//        public int healthRecoverAmount;
//        public int focusPointsRecoverAmount;

//        [Header("Recovery Effects")]
//        public GameObject recoveryFX;

//        public override void AttemptToConsumeItem(AnimationHandler animationHandler, WeaponSlotManager weaponSlotManager, PlayerEffectsManager playerEffectsManager)
//        {
//            base.AttemptToConsumeItem(animationHandler, weaponSlotManager, playerEffectsManager);
//            playerEffectsManager.currentParticleFX = recoveryFX;
//            playerEffectsManager.amountToBeHealed = healthRecoverAmount;
//            playerEffectsManager.instantiatedFXModel = itemModel;
//            GameObject flask = Instantiate(itemModel, weaponSlotManager.rightHandSlot.transform);
//            weaponSlotManager.rightHandSlot.UnloadWeapon();
//        }
//    }
//}