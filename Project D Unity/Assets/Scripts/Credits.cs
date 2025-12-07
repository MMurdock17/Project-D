using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void CreditsLoadMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
