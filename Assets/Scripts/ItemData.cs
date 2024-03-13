using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ajout d'un menu perso dans unity */
[CreateAssetMenu(fileName = "Item", menuName ="Items/New item")]

public class ItemData : ScriptableObject
{
    public string name; /* nom de l'item */
    public Sprite visual; /* visuel de l'item */
    public GameObject prefab; 
}
