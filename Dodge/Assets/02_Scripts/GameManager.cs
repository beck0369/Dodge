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

    private void Update()
    {
        if (!isGameover)    // 게임오버가 아닌 동안
        {
            surviveTime += Time.deltaTime;  // 생존 시간 갱신
            timeText.text = "Time : " + (int)surviveTime;   // 갱신한 생존 시간을 timeText 텍스트 컴포넌트를 이용해 표시
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))    // 게임오버 상태에서 R 키를 누른 경우
            {
                SceneManager.LoadScene("SampleScene");  // SampleScene 씬을 로드
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;  // 현재 상태를 게임오버 상태로 전환
        gameOverText.SetActive(true);   // 게임오버 텍스트 게임 오브젝트를 활성화
    }
}
