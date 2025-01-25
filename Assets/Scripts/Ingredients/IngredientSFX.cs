using UnityEngine;

public class IngredientSFX:MonoBehaviour
{
    [SerializeField] protected AudioClip _ingredientClick;
    public void IngredientClickSFX()
    {
        SoundManager.Instance.PlaySFX(_ingredientClick);
    }
}
