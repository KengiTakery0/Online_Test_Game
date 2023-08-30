using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Mirror.Examples.Basic;

public class TurnManager : MonoBehaviour
{
    List<Player> players = new List<Player>();

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }
}
