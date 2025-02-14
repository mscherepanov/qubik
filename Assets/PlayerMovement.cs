using UnityEngine;

/// <summary>
/// ����� ��� ���������� ��������� ������ (������).
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [Header("��������� ��������")]
    [Tooltip("�������� �������� ������ ������ �� ��� Z.")]
    [SerializeField] private float forwardForce = 2000f; // �������� �������� ������

    [Tooltip("�������� �������� ������ ����� � ������ �� ��� X.")]
    [SerializeField] private float sidewaysForce = 500f; // �������� �������� ��������

    [Header("����������")]
    [Tooltip("������ �� ��������� Rigidbody ������.")]
    [SerializeField] private Rigidbody rb; // ��������� Rigidbody

    /// <summary>
    /// ����� FixedUpdate ���������� � ������������� ����������.
    /// ������������ ��� ���������� ��������, ����� ��� ��������.
    /// </summary>
    private void FixedUpdate()
    {
        MoveForward();
        HandleSidewaysMovement();
    }

    /// <summary>
    /// ���������� ������ ������ �� ��� Z � �������� ���������.
    /// </summary>
    private void MoveForward()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    /// <summary>
    /// ������������ �������� ������ ����� � ������ �� ��� X.
    /// </summary>
    private void HandleSidewaysMovement()
    {
        if (Input.GetKey("d")) // �������� ������
        {
            ApplySidewaysForce(sidewaysForce);
        }
        else if (Input.GetKey("a")) // �������� �����
        {
            ApplySidewaysForce(-sidewaysForce);
        }
    }

    /// <summary>
    /// ��������� ���� ��� �������� ����� ��� ������.
    /// </summary>
    /// <param name="force">����, ����������� �� ��� X.</param>
    private void ApplySidewaysForce(float force)
    {
        rb.AddForce(force * Time.deltaTime, 0, 0);
    }
}