using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraPopUp : MonoBehaviour
{
    [SerializeField] GameObject popUpUI;
    [SerializeField] Button yesBtn, noBtn;


    // Start is called before the first frame update
    void Start()
    {
        popUpUI.SetActive(false);

        yesBtn.onClick.AddListener(ChangeToCameraView);
        noBtn.onClick.AddListener(DisablePopUp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            popUpUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        DisablePopUp();
    }

    public void ChangeToCameraView()
    {
        ChangeSceneManager.Instance.MoveToCamera();
    }

    public void DisablePopUp()
    {
        popUpUI.SetActive(false);
    }
}
