using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // Сериализуем обьект что бы смоч унаследыватся от него
public class Unit
{
    public string Name;
    public float Health;
    public int Armor;
    public float Speed = 0.7f;
}
