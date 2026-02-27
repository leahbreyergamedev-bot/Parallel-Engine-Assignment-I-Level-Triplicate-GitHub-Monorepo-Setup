using UnityEngine;

public class GetCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin Collected");
    }

}
