using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] string _isCandyNearBoolName;
    [SerializeField] string _eatTriggerName;


    [SerializeField] DetectCandy _openMouth;
    [SerializeField] DetectCandy _eatCandy;

    [SerializeField] GameManagerReference _gameManager;

    private void Update()
    {
        _animator.SetBool(_isCandyNearBoolName, _openMouth.DetectedCandy != null);
        if(_eatCandy.DetectedCandy != null )
        {
            _animator.SetTrigger(_eatTriggerName);
            Destroy(_eatCandy.DetectedCandy.gameObject);

            // Version SO
            _gameManager.GameManager.Win();
        }

    }


}
