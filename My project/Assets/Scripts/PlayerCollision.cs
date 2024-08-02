using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public CoinCollected cc;

    public int score = 0;

    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Token")
        {
            score++;
            Debug.Log(score);

            cc.playAudio();

            Destroy(collisionInfo.gameObject);

        }

        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(message: "HIT!");

            movement.enabled = false;

            Object.FindFirstObjectByType<gameManger>().EndGame();

           

        }

        if(collisionInfo.collider.tag == "Enemy")
        {
            movement.enabled = false;

            Debug.Log(message:"Caught!");

            Object.FindFirstObjectByType<gameManger>().EndGame();

        }


    }
}


