using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float life=100;

    private void Update(){
        if (life <= 0){
            if (gameObject.CompareTag("Player") && life <= 0){
                Debug.Log("Game Over");
            } else if (gameObject.CompareTag("Bot") && life <= 0){
                Debug.Log(life);
                Destroy(gameObject);
            }
        }
    }
}
