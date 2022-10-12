using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{

    [SerializeField] DetectCandy _detect;

    private void Update()
    {
        if(_detect.DetectedCandy != null)
        {
            SceneManager.LoadScene(gameObject.scene.name);
        }
    }

}
