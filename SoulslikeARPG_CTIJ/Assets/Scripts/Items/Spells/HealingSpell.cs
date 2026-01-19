using UnityEngine;

namespace Souls
{
    [CreateAssetMenu(menuName = "Spells/Healing Spell")]
    public class HealingSpell : SpellItem
    {
        public int healAmount;

        public override void AttemptToCastSpell(AnimationHandler animationHandler, PlayerStats playerStats)
        {
            //GameObject instantiatedWarmUPSpellFX = Instantiate(spellWarmUpFX, animationHandler.transform);
            animationHandler.PlayTargetAnimation(spellAnimation, true);
            Debug.Log("Attempt to cast spell");
        }

        public override void SuccessfullyCastSpell(AnimationHandler animationHandler, PlayerStats playerStats)
        {
            //GameObject instantiatedSpellFX = Instantiate(spellCastFX, animationHandler.transform);
            playerStats.HealPlayer(healAmount);
            Debug.Log("Spell Cast Successful");
        }
    }
}