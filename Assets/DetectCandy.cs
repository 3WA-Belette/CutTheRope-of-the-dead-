using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCandy : MonoBehaviour
{
    Candy _detectedCandy;

    public Candy DetectedCandy { get => _detectedCandy;}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if(collision.attachedRigidbody.TryGetComponent<Candy>(out var c))
        {
            _detectedCandy = c;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if (collision.attachedRigidbody.TryGetComponent<Candy>(out var c))
        {
            _detectedCandy = null;
        }
    }
}
