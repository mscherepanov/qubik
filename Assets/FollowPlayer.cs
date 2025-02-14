using UnityEngine;

/// <summary>
/// Класс для управления камерой, которая следует за игроком (кубиком).
/// </summary>
public class FollowPlayer : MonoBehaviour
{
    [Header("Настройки камеры")]
    [Tooltip("Цель, за которой следует камера (обычно игрок).")]
    [SerializeField] private Transform player; // Цель (игрок)

    [Tooltip("Смещение камеры относительно цели.")]
    [SerializeField] private Vector3 offset; // Смещение камеры

    /// <summary>
    /// Метод LateUpdate вызывается после всех обновлений (Update).
    /// Используется для обновления позиции камеры, чтобы избежать дрожания.
    /// </summary>
    private void LateUpdate()
    {
        FollowTarget();
    }

    /// <summary>
    /// Обновляет позицию камеры, чтобы она следовала за целью с заданным смещением.
    /// </summary>
    private void FollowTarget()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}