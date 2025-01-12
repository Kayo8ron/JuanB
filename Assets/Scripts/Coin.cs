using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, ICollectable
{
    // Start is called before the first frame update
  public void OnCollected()
{ 
    if (GameManager.gameManager != null)
    {
        GameManager.gameManager.CoinCollected(1 );
    }
    else
    {
        Debug.LogError("GameManager no está asignado.");
    }
    Destroy(gameObject);
}


}
