using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text username;

    public void OnUsernameSet()
    {
        GameManager.Instance.username = username.text;
    }

    public void LoadMain()
    {
        if (!string.IsNullOrEmpty(username.text))
        {
            SceneManager.LoadScene(1);
        }
    }
}
