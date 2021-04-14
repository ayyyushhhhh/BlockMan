using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ScoredProductions.Global
{
    public class CollisonScript : MonoBehaviour
    {
        [Range(0, 1000)]
        public float Damage;
        
       private AudioSource blockSound;
        void OnCollisionEnter(Collision other) {
            DamageInterface x = other.gameObject.GetComponent<DamageInterface>();
            blockSound = GetComponent<AudioSource>();
            if (x != null) {
                x.ReceiveDamage(Damage);
                if (blockSound != null)
                {
                    blockSound.Play();
                }

               
            }
           // Destroy(gameObject);
        }
    }
}