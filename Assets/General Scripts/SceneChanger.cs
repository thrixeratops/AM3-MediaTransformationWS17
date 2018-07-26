using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    private float MyTime = 0F;
    private int SceneNum = -1;
    public float ActivationTime;
    public Transform RadialProgress;

    // Use this for initialization
    void Start()
    {
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;
    }

    // Update is called once per frame
    public void Update()
    {
        MyTime += Time.deltaTime;
        RadialProgress.GetComponent<Image>().fillAmount = MyTime / ActivationTime;

        if (MyTime >= ActivationTime)
        {
            SetToScene();
        }
    }

    public void SetSceneNumber(int num)
    {
        SceneNum = num;
    }

    public void ResetTimer()
    {
        MyTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;
        SceneNum = -1;
    }

    public void SetToScene()
    {
        SceneManager.LoadScene("VRScene" + SceneNum, LoadSceneMode.Single);
    }

    public void TestTransform()
    {
        transform.position = new Vector3(0, 4.8F, 0);
    }
}
