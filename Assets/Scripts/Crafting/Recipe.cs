using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Cooking/Recipe")]
public class Recipe : ScriptableObject
{
    public new string name;
    public Sprite icon;
    public List<Ingredient> requiredIngredients = new List<Ingredient>();
}
