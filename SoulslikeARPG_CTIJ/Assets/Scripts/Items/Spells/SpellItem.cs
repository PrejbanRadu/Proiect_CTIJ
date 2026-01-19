using UnityEngine;

namespace Souls
{
    public class SpellItem : Item
    {
        public GameObject spellWarmUpFX;
        public GameObject spellCastFX;

        public string spellAnimation;

        [Header("Spell Type")]
        public bool isFaithSpell;
        public bool isMagicSpell;
        public bool isPyroSpell;

        [Header("Spell Description")]
        [TextArea]
        public string spellDescription;

        public virtual void AttemptToCastSpell(AnimationHandler animationHandler, PlayerStats playerStats)
        {
            Debug.Log("You attempt to cast a spell");
        }

        public virtual void SuccessfullyCastSpell(AnimationHandler animationHandler, PlayerStats playerStats)
        {
            Debug.Log("You successfully cast a spell");
        }
    }
}