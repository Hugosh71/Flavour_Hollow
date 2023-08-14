using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Recipe : MonoBehaviour
{
    public List<Ingredient> ingredients;
    public string recipeName;
    public float preparationTime;
    public Ingredient result;

    public bool Craftable(List<Ingredient> playerIngredients)
    {
        if (ingredients.Count != playerIngredients.Count)
            return false;

        for (int i = 0; i < ingredients.Count; i++)
        {
            if (!playerIngredients.Contains(ingredients[i]))
            {
                return false;
            }
        }
        return true;
    }
}
