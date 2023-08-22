using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Cooking/Ingredient")]
public class Ingredient : ScriptableObject
{
    public new string name;
    public Sprite icon;
}

