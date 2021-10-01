using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace eswaregames
{
    public class InteractionUIPanel : MonoBehaviour
    {
        [SerializeField] private Image progressBar = null;
        [SerializeField] private TextMeshProUGUI tooltipText;

        public void SetTooltip(string tooltip)
        {
            tooltipText.text = tooltip;
        }

        public void UpdateProgressBar(float fillAmount)
        {
            progressBar.fillAmount = fillAmount;
        }

        public void ResetUI()
        {
            tooltipText.text = "";
            progressBar.fillAmount = 0f;
        }
    }
}

