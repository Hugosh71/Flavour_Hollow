using System.Collections.Generic;
using UnityEngine;

public class CraftingManager : MonoBehaviour
{
    public List<Recipe> recipes = new List<Recipe>();

    public bool Craft(List<Ingredient> ingredients)
    {
        foreach (Recipe recipe in recipes)
        {
            if (IngredientsMatch(recipe, ingredients))
            {
                StartCoroutine(CraftWithDelay(recipe));
                return true;
            }
        }
        return false;
    }

    bool IngredientsMatch(Recipe recipe, List<Ingredient> ingredients)
    {
        if (recipe.ingredients.Count != ingredients.Count)
            return false;

        for (int i = 0; i < recipe.ingredients.Count; i++)
        {
            if (!ingredients.Contains(recipe.ingredients[i]))
            {
                return false;
            }
        }
        return true;
    }

    System.Collections.IEnumerator CraftWithDelay(Recipe recipe)
    {
        yield return new WaitForSeconds(recipe.preparationTime);

        foreach (Ingredient ingredient in recipe.ingredients)
        {
            // Remove ingredients from player's inventory
        }

        // Add the crafted item to player's inventory
        // Assuming you have an "Item" class or structure to represent crafted items
        // Item craftedItem = recipe.result;
        // AddToInventory(craftedItem);
    }
}

