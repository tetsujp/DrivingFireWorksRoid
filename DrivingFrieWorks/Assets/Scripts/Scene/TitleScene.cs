using UnityEngine;
using System.Collections;

public class TitleScene :  BasicScene
{

	// Use this for initialization
	void Start () {
        IT_Gesture.onTouchDownE += OnTouchDown;
        Initialize();
        
	}
    public override void Initialize()
    {
        
    }
    public override void SceneFinalize()
    {
        IT_Gesture.onTouchDownE -= OnTouchDown;
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Decide"))
        {
            //曲選択画面へ

            ChangeScene(SceneName.Select);
        }
	}
    void OnTouchDown(Touch touch)
    {
        ChangeScene(SceneName.Select);
    }
}
