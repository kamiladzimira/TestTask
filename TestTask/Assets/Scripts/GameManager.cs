using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public static GameManager GetInstance()
    {
        return instance;
    }
}
