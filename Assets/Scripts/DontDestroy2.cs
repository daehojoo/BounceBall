using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy2 : MonoBehaviour
{
    private static DontDestroy2 instance;

    private void Awake()
    {
        // 이미 인스턴스가 존재하는지 확인
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject); // 중복된 인스턴스는 파괴
        }
    }










}
