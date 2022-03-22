using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnHardP2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.GetComponent<P2>() != null)
        {
            GameControllerHard.Instance.ScoreP2();
        }
    }
}
