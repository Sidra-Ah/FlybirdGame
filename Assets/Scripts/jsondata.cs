using System.Diagnostics;
using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class jsondata : MonoBehaviour
{
    // Start is called before the first frame update
    // private string path = "";
    // private string persisitentPath = "";
    // void Start()
    // {
    //     CreatePlayerData();
    //     SetPaths();
    // }

    // private void CreatePlayerData()
    // {
    //     playerData = new PlayerData("data",200f,10f,3);
    // }
    // private void SetPaths(){
    //     path = Application.dataPath + Path.AltDirectorySepratorChar + "SaveData.json";
    //     persisitentPath = ApplicationException.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // public void SaveData()
    // {
    //     string savePath = path;
    //     Debug.Log("Saving Data at" + savePath);
    //     string json = JsonUtility.ToJson(playerData);
    //     Debug.Log(json);
    //     using StreamWriter writer = new StreamWriter(savePath);
    //     writer.Write(json);
    // }

}
