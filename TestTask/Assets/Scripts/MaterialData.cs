using UnityEngine;

[CreateAssetMenu(fileName = "MaterialData", menuName = "ScriptableObjects/MaterialData")]
public class MaterialData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private MaterialType _type;

    public string Name => _name;
    public MaterialType Type => _type; 
}
