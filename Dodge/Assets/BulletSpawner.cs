using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;     // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;   // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f;     // �ִ� ���� �ֱ�

    private Transform target; // �߻��� ���
    private float spawnRate;    // ���� �ֱ�
    private float timeAfterSpawn;   //�ֱ� ���� �������� ���� �ð�

    private void Start()
    {
        timeAfterSpawn = 0f;    // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);   // ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����
        target = FindObjectOfType<PlayerController>().transform;    // playerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
    }
}
