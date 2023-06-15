using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private SpawnManager _spawnManager;
    public int numbOfTargets;

    //Restart
    public TextMeshProUGUI endScreen;
    private float timeToRestart = 5.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        _spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        endScreen = GameObject.Find("Canvas").GetComponentInChildren<TextMeshProUGUI>();
        endScreen.enabled = false;
    }

    private void Update()
    {
        VictoryConditions();

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void VictoryConditions()
    {
        numbOfTargets = GameObject.FindGameObjectsWithTag("Target").Length;

        if (numbOfTargets <= _spawnManager.PrefabsToSpawn - 5)
        {
            endScreen.enabled = true;
            endScreen.text = "Gratulacje";
            timeToRestart -= Time.deltaTime;
            if (timeToRestart <= 0)
            {
                ResetTheGame();
            }
        }
    }
    private void ResetTheGame()
    {
        SceneManager.LoadScene("Main");
    }
}
