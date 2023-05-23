using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private MaterialType _materialType;
    public MaterialType MaterialType => _materialType;
}
