using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStates 
{
    void Enter(Player player);
    void Execute(Player player);
}
