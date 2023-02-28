using System;
using UnityEngine;

namespace DefaultNamespace
{
  public class World : MonoBehaviour
  {
    public PlayMode PlayMode;
    public int PlayersNumber;
  }

  public enum PlayMode
  {
    Random =0,
    Custome =1,
    Semirandom=3
    
  }
}