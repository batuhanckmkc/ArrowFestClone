using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivateParticle : MonoBehaviour
{
    public GameObject particle;
    public TextMeshPro particleGold;
    void Start()
    {
        particle.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            particle.SetActive(true);
            GoldParticleText indicator = Instantiate(particleGold, transform.position, Quaternion.identity).GetComponent<GoldParticleText>();
        }
    }
}
