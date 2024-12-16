using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;

public class UIManagment : MonoBehaviour
{
    private SceneManagment sceneManager; 
    private LoginManagment loginManager;
    private LevelManagment levelManager;
    private PauseMenuManagment pauseMenuManager;
    private Tutoriel gameTutoriel;
    private Lv1Manager level1;
    private LocationSwitch playerLocationSwitch; 

    private void Start()
    {
        // Find Referances 
        sceneManager = GameObject.Find("Scene Manager").GetComponent<SceneManagment>(); 

        // When scene is login scene
        if(sceneManager.currentSceneNumber == 1)
        {
            loginManager = GameObject.Find("Login Manager").GetComponent<LoginManagment>();
        }

        // When scene is level scene
        if(sceneManager.currentSceneNumber == 2)
        {
            levelManager = GameObject.Find("Level Manager").GetComponent<LevelManagment>(); 
        }

        // when scene is game scene
        if(sceneManager.currentSceneNumber == 3)
        {
            pauseMenuManager = GameObject.Find("Pause").GetComponent<PauseMenuManagment>();
            gameTutoriel = GameObject.Find("Tutoriel").GetComponent<Tutoriel>();
            level1 = GameObject.Find("Lv1 Manager").GetComponent<Lv1Manager>(); 
            playerLocationSwitch = GameObject.FindWithTag("Player").GetComponent<LocationSwitch>();
        }
    }

    #region LOGIN SCREEN BUTTONS

    public void PressedLoginButton()
    {
        StartCoroutine(loginManager.EmailRegister()); 
    }

    public void PressedOTPEnterButton()
    {
        loginManager.OTPEntered(); 
    }

    public void PressedGoButton()
    {
        loginManager.UsernameEntered(); 
    }

    public void PressedNextButton()
    {
        loginManager.GenderAuth(); 
    }

    public void RightButtonPressed()
    {
        loginManager.ChangeAtRight(); 
    }

    public void LeftButtonPressed()
    {
        loginManager.ChangeAtLeft();
    }

    public void SelectButtonPressed()
    {
        loginManager.CharacterSelected(); 
    }

    #endregion

    #region LEVEL SCREEN BUTTONS
    public void LevelButtonPressed(int levelNumber)
    {
        levelManager.OpenLevel();
    }

    #endregion

    #region PAUSE MENU BUTTONS

    public void PauseButtonPressed()
    {
        pauseMenuManager.GamePause(); 
    }

    public void ResumeButtonPressed()
    {
       StartCoroutine(pauseMenuManager.GameResume()); 
    }

    public void RestartButtonPressed()
    {
        pauseMenuManager.RestartLevel(); 
    }

    public void BackButtonPressed()
    {
        pauseMenuManager.BackToLevelScene(); 
    }

    public void SettingButtonPressed()
    {
        pauseMenuManager.OpenSettingPanel(); 
    }

    public void SettingCloseButtonPressed()
    {
        pauseMenuManager.CloseSettingPanel(); 
    }
    #endregion

    #region TUTORIEL BUTTONS
    public void ReadyButtonPressed()
    {
        gameTutoriel.OffTutoriel(); 
    }
    #endregion

    #region SELECTION MENU BUTTONS
    public void Industry_SelectButtonPressed(int index)
    {
        StartCoroutine(level1.AfterSelection(2,index)); 
    }

    public void Problem_SelectButtonPressed(int index)
    {
        StartCoroutine(level1.AfterSelection(4,index)); 
    }

    public void Solution_DoneButtonPressed(int index)
    {
        StartCoroutine(level1.AfterSelection(6, index));
    }

    public void TargetAudience_DoneButton(int index)
    {
        StartCoroutine(level1.AfterSelection(8, index));
    }

    public void USP_DoneButton(int index)
    {
        StartCoroutine(level1.AfterSelection(10, index));
    }

    #endregion

    #region OTHERS

    public void LocationSwitchButtonPressed()
    {
        playerLocationSwitch.LocationSwitchConfirm(); 
    }

    #endregion
}
