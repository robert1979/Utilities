using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ClearCache : MonoBehaviour
{

    void OnGUI()
    {
        if(GUILayout.Button("Clear Cache"))
        {
            ClearAllCache();
        }
    }

    public static void ClearAllCache()
    {
        Debug.Log("clear cache at " + Application.persistentDataPath);
        var list = Directory.GetDirectories(Application.persistentDataPath);
 
        foreach (var item in list)
        {
            Debug.Log("Delete" + " " + item);
            Directory.Delete(item, true);
        }
 
        Caching.ClearCache();
    }
}
