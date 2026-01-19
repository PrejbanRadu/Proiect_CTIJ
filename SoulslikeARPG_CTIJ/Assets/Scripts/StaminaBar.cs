using UnityEngine;
using UnityEngine.UI;

namespace Souls
{
    public class StaminaBar : MonoBehaviour
    {
        public Slider slider;

        public void SetMaxStamina(float maxStamina)
        {
            slider.maxValue = maxStamina;
            slider.value = maxStamina;
        }

        public void SetCurrentStamina(float currentStamina)
        {
            slider.value = currentStamina;
        }
    }
}
