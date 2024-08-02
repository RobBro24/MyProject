using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManger : MonoBehaviour
{

    bool gameEnd = false;

    public GameObject levelCompUI;


    public float RestartDelay = 1f;

    public void completedLevel()
    {
        levelCompUI.SetActive(true);

    
    }



    public void EndGame()
    {

        if(gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Game Over!");

            Invoke("Restart",RestartDelay);


        }
       
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
