//using UnityEngine;

//namespace Souls
//{
//    public class ConsumableItem : Item
//    {
//        [Header("Item Quantity")]
//        public int maxItemAmount;
//        public int currentItemAmount;

//        [Header("Item Model")]
//        public GameObject itemModel;

//        [Header("Animations")]
//        public string consumeAnimation;
//        public bool isInteracting;

//        public virtual void AttemptToConsumeItem(AnimationHandler animationHandler, WeaponSlotManager weaponSlotManager, PlayerEffectsManager playerEffectsManager)
//        {
//            if (currentItemAmount > 0)
//            {
//                animationHandler.PlayTargetAnimation(consumeAnimation, isInteracting);
//            }
//            else
//            {
//                animationHandler.PlayTargetAnimation("Shrug", true);
//            }
//        }
//    }
//}