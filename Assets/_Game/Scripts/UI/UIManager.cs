using UnityEngine;

public class MainMenu_ButtonManager : MonoBehaviour
{
    public MainMenu_UiManager uiManager;
    public SceneLoaderManager sceneLoaderManager;
    public void Button_OpenLoadMenu()
    {
        uiManager.OpenLoadMenu();
    }

    public void Button_OpenMainMenu()
    {
        uiManager.OpenMainMenu();
    }

    public void Button_OpenOptionsMenu()
    {
        uiManager.OpenOptionsMenu();
    }

    public void Button_LoadSceneByIndex(int index)
    {
        sceneLoaderManager.LoadScene(index);

    }
    
    public void Button_ExitGame()
    {
        Application.Quit();
    }
}