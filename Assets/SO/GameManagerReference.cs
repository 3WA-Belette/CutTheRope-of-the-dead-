using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="GameManagerRef")]
public class GameManagerReference : ScriptableObject
{
    GameManager _gameManager;
    public GameManager GameManager { get => _gameManager; set => _gameManager = value; }
}
