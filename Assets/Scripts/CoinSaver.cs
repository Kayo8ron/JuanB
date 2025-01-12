using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSaver : MonoBehaviour
{
    public int ID; // Assignar un id perquè hi haurà moltes monedes

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Coin" + ID) && PlayerPrefs.GetInt("Coin" + ID) == 1)
        {
            LoadCoin(); // Comprova si hi ha una variable guardada (si no encara no s’ha trobat la moenda i no la tens)
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("Coin" + ID, 1); // Com que no es poden guardar bools a PlayerPrefs, utilitzem ints (0 = false, 1 = true)
    }

    public void LoadCoin()
    {
        GameManager.gameManager.CoinCollected(1);
        gameObject.SetActive(false); // Si la moneda ha sigut recollida aumentem 1 el nombre de coins i desactivem la pròpia moneda per no tornar-la a recollir
    }
}
