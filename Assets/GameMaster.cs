using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    public static GameMaster instance;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public int bricks;

    private GameMaster()
    {

    }

    public void BlockDestroyed()
    {
        if (--bricks == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
