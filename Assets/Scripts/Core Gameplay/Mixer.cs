using System;
using TMPro;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    [HideInInspector] public BubbleTea bubbleTea = null;
    private bool missingIngredient;
    [SerializeField] private GameObject orders;
    [SerializeField] private GameObject mixServe;
    [SerializeField] private GameObject baseOrder, syrupOrder, bubbleOrder;
    [SerializeField] private AudioClip _missingIngredient;

    public void OnClick()
    {
        missingIngredient = false;
        if (bubbleTea != null)
        {
            if (!bubbleTea.hasBase)
            {
                Debug.Log("Você ainda não escolheu uma base :(");
                baseOrder.GetComponent<TextMeshProUGUI>().color = Color.red;
                missingIngredient = true;
            } 
            if (!bubbleTea.hasSyrup)
            {
                Debug.Log("Está faltando o xarope :(");
                syrupOrder.GetComponent<TextMeshProUGUI>().color = Color.red;
                missingIngredient = true;
            }
            if (!bubbleTea.hasBubble)
            {
                Debug.Log("Deixou de colocar o principal! O Bubble! >:(");
                bubbleOrder.GetComponent<TextMeshProUGUI>().color = Color.red;
                missingIngredient = true;
            }

            if (missingIngredient)
            {
                SoundManager.Instance.PlaySFX(_missingIngredient);
            } else
            {
                Debug.Log("Saindo um Bubble Tea de " + bubbleTea.baseType + " com " + bubbleTea.syrup + " e bubbles " + bubbleTea.bubble + " no copo " + bubbleTea.cup + " :3");
                orders.GetComponent<Orders>().CompleteOrder(bubbleTea);
                bubbleTea = null;
                mixServe.SetActive(false);
            }
        } else
        {
            Debug.Log("Nenhum copo foi selecionado ainda :(");
        }
    }
}
