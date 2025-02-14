using UnityEngine;

/// <summary>
/// ����� ��� ���������� �������, ������� ������� �� ������� (�������).
/// </summary>
public class FollowPlayer : MonoBehaviour
{
    [Header("��������� ������")]
    [Tooltip("����, �� ������� ������� ������ (������ �����).")]
    [SerializeField] private Transform player; // ���� (�����)

    [Tooltip("�������� ������ ������������ ����.")]
    [SerializeField] private Vector3 offset; // �������� ������

    /// <summary>
    /// ����� LateUpdate ���������� ����� ���� ���������� (Update).
    /// ������������ ��� ���������� ������� ������, ����� �������� ��������.
    /// </summary>
    private void LateUpdate()
    {
        FollowTarget();
    }

    /// <summary>
    /// ��������� ������� ������, ����� ��� ��������� �� ����� � �������� ���������.
    /// </summary>
    private void FollowTarget()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}