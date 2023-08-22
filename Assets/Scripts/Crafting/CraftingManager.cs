using System.Collections.Generic;
using UnityEngine;

public class CraftingManager : MonoBehaviour
{
    public List<Recipe> recipes = new List<Recipe>();

    public bool Craft(Recipe recipe)
    {
        foreach (Ingredient ingredient in recipe.requiredIngredients)
        {
            if (!InventoryContains(ingredient))
            {
                Debug.Log("Missing ingredient: " + ingredient.name);
                return false;
            }
        }

        
        foreach (Ingredient ingredient in recipe.requiredIngredients)
        {
            RemoveFromInventory(ingredient);
        }

        Debug.Log("Crafted: " + recipe.name);
        return true;
    }

    bool InventoryContains(Ingredient ingredient)
    {
        return true;
    }

    void RemoveFromInventory(Ingredient ingredient)
    {
        
    }
}
