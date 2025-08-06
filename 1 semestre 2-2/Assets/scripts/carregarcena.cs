using UnityEngine;
using UnityEngine.SceneManagement;

public class carregarcena : MonoBehaviour
{
    public string nomeDaCena;

    public void carregar()
    {
        SceneManager.LoadScene(nomeDaCena);
    }

}
