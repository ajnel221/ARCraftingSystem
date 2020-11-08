using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject arSessionPrefab;
    private GameObject newSessionSpawn;
    public bool resetStuff = false;

    void Start()
    {
        newSessionSpawn = Instantiate(arSessionPrefab, Vector3.zero, Quaternion.identity);
    }

    public void ResetBools()
    {
        RestartCrafting();
    }

    public void RestartCrafting()
    {
        Destroy(newSessionSpawn);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
