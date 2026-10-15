using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]

    private TextMeshProUGUI goalText;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        goalText.enabled = true;
    }
}