using UnityEngine;

/// <summary>
/// ����� ��� ��������� �������� ������ (������).
/// </summary>
public class PlayerCollision : MonoBehaviour
{
    [Header("����������")]
    [Tooltip("������ �� ��������� ���������� ��������� ������.")]
    [SerializeField] private PlayerMovement movement; // ��������� �������� ������

    /// <summary>
    /// ����� ���������� ��� ������������ � ������ �����������.
    /// </summary>
    /// <param name="collisionInfo">���������� � ������������.</param>
    private void OnCollisionEnter(Collision collisionInfo)
    {
        HandleCollision(collisionInfo);
    }

    /// <summary>
    /// ������������ ������������ � ���������.
    /// </summary>
    /// <param name="collisionInfo">���������� � ������������.</param>
    private void HandleCollision(Collision collisionInfo)
    {
        if (IsObstacle(collisionInfo))
        {
            DisablePlayerMovement();
        }
    }

    /// <summary>
    /// ���������, �������� �� ������ ������������.
    /// </summary>
    /// <param name="collisionInfo">���������� � ������������.</param>
    /// <returns>True, ���� ������ �������� ������������, ����� False.</returns>
    private bool IsObstacle(Collision collisionInfo)
    {
        return collisionInfo.collider.CompareTag("Obstacle");
    }

    /// <summary>
    /// ��������� �������� ������.
    /// </summary>
    private void DisablePlayerMovement()
    {
        if (movement != null)
        {
            movement.enabled = false;
        }
    }
}