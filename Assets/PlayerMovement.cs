using UnityEngine;

/// <summary>
/// ����� ��� ���������� ��������� ������ (������)
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [Header("��������� ��������")]
    [Tooltip("�������� �������� ������ �� ��� Z.")]
    [SerializeField] private float moveSpeed = 2000f; // �������� ��������

    [Header("����������")]
    [Tooltip("������ �� ��������� Rigidbody ������.")]
    [SerializeField] private Rigidbody rb; // ��������� Rigidbody

    /// <summary>
    /// ����� Update ���������� ������ ����
    /// ������������ ��� ��������� ����� � ������ ������� ��������
    /// </summary>
    private void Update()
    {
        MoveForward();
    }

    /// <summary>
    /// ���������� ������ ������ �� ��� Z � �������� ���������
    /// </summary>
    private void MoveForward()
    {
        // ��������� ���� ��� �������� ������
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
    }
}