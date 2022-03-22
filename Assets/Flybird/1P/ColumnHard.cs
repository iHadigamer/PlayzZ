using UnityEngine;

public class ColumnHard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.GetComponent<BirdHard>() != null)
        {
            GameControllerHardFor1.Instance.Score();
        }
    }
}
