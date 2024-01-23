using UnityEngine;
[CreateAssetMenu(fileName = "new ItemPreset", menuName = "ScriptableObjects/Item", order = 1)]

public class ItemPreset : ScriptableObject
{
    public string Name;
    public GameModel.ConsumableTypes type;
    public Sprite Image;
    public string Description;
}
