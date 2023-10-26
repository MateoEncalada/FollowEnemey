using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public TextMeshProUGUI HealthUI;
    public Material playerMaterial;
    public Material playerDamagedMaterial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Proyectile"))
        {
             playerHealth -= 1;
            GetComponent<Renderer>().material = playerDamagedMaterial;
            Invoke("ResetMaterial", 0.5f);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        HealthUI.text= playerHealth.ToString();
    }
    void ResetMaterial()
    {
        GetComponent<Renderer>().material = playerMaterial;
    }
}
