using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level3 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level3Start()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
