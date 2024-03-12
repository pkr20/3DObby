using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    // Start is called before the first frame update
    int coins = 0;
    [SerializeField] Text coinsText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")){
            Destroy(other.gameObject);
            coins = coins + 5;
            coinsText.text = "Coins: " + coins;
        }
    }
}
