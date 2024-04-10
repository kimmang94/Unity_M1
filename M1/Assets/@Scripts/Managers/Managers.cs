using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance;
    private static Managers Instance { get { Init(); return s_instance; } }

    public static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Manangers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);

            //초기화
            s_instance = go.GetComponent<Managers>();
        }
    }
}
