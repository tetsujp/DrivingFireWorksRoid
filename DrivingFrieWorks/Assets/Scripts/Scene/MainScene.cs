using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MainScene : BasicScene
{
    //曲データ
    //ノートデータ
    public GameObject prefabNoteOwner;
    NoteOwner noteOwner;
    GameObject scoreManager;
    public GameObject prefabStart;
    //Transform score;

	// Use this for initialization
	void Start () {
	}
    override public void Initialize()
    {
        noteOwner=((GameObject)Instantiate(prefabNoteOwner)).GetComponent<NoteOwner>();
        //scoreManager = GameObject.FindGameObjectWithTag("ScoreManager");
        //score = transform.FindChild("Canvas").transform.FindChild("Score");
        //Instantiate(prefabStart);
    }
    override public void SceneFinalize()
    {
        Destroy(noteOwner);
        gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

        //曲の終了
        if (noteOwner.IsEnd())
        {
            noteOwner.FinalizeObj();
            ChangeScene(SceneName.Result);
        }
        //if (Input.GetButtonDown("Stop"))
        //{
        //    noteOwner.GetComponent<NoteOwner>().FinalizeObj();
        //    ChangeScene(SceneName.Result);
        //}
        
	}
    void LateUpdate()
    {
        if (Input.GetButtonDown("Stop"))
        {
            noteOwner.FinalizeObj();
            ChangeScene(SceneName.Result);
        }
    }
}
