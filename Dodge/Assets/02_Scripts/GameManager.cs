using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText;   // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;  // ���� �ð�
    private bool isGameover;    // ���ӿ��� ����

    private void Start()
    {
        surviveTime = 0;
        isGameover = false; // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
    }


}
