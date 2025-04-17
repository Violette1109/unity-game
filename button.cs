using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToScene1()
    {
        SceneManager.LoadScene("SampleScene 1");  // 請替換成你的場景名稱
    }
}
