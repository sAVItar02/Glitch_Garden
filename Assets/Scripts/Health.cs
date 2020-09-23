using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] ParticleSystem deatVFX;
    public void DealDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            GetComponent<Attacker>().SetMoveSpeed(0f);
            Destroy(gameObject);
            GetComponent<Animator>().enabled = false;
            var VFX = Instantiate(deatVFX, transform.position, transform.rotation);
            Destroy(VFX, 1f);
        }
    }
}
