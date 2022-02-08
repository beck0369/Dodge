using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText; // 게임오버 시 활성화할 텍스트 게임 오브젝트
    public Text timeText;   // 생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText; // 최고 기록을 표시할 텍스트 컴포넌트

    private float surviveTime;  // 생존 시간
    private bool isGameover;    // 게임오버 상태

    private void Start()
    {
        surviveTime = 0;
        isGameover = false; // 생존 시간과 게임오버 상태 초기화
    }


}
