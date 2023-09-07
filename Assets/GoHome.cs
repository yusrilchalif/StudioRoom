using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoHome : MonoBehaviour
{
    [SerializeField] Button goHome;

    // Start is called before the first frame update
    void Start()
    {
        goHome.onClick.AddListener(MoveToHome);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToHome()
    {
        ChangeSceneManager.Instance.MoveToHome();
    }
}
