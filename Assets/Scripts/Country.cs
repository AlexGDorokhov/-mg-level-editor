using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.ProBuilder;

public class Country : MonoBehaviour
{
  private int Player;
  private int ID;

  public string Title;
  public List<Country> AvailableRoutes;

  [Header("Zone Settings")] public bool Capital;
  public bool Frost;
  public bool Portal;
  public bool Zombie;
}