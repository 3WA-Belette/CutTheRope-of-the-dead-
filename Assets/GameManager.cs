using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameManagerReference gameManager;

    static GameManager _instance;

    public static GameManager Instance { get => _instance;}

    private void Awake()
    {
        gameManager.GameManager = this;
    }
    public void Win()
    {

    }

    public void Lose()
    {

    }


}
