using UnityEngine;

/// <summary>
/// Класс для обработки коллизий игрока (кубика).
/// </summary>
public class PlayerCollision : MonoBehaviour
{
    [Header("Компоненты")]
    [Tooltip("Ссылка на компонент управления движением игрока.")]
    [SerializeField] private PlayerMovement movement; // Компонент движения игрока

    /// <summary>
    /// Метод вызывается при столкновении с другим коллайдером.
    /// </summary>
    /// <param name="collisionInfo">Информация о столкновении.</param>
    private void OnCollisionEnter(Collision collisionInfo)
    {
        HandleCollision(collisionInfo);
    }

    /// <summary>
    /// Обрабатывает столкновение с объектами.
    /// </summary>
    /// <param name="collisionInfo">Информация о столкновении.</param>
    private void HandleCollision(Collision collisionInfo)
    {
        if (IsObstacle(collisionInfo))
        {
            DisablePlayerMovement();
        }
    }

    /// <summary>
    /// Проверяет, является ли объект препятствием.
    /// </summary>
    /// <param name="collisionInfo">Информация о столкновении.</param>
    /// <returns>True, если объект является препятствием, иначе False.</returns>
    private bool IsObstacle(Collision collisionInfo)
    {
        return collisionInfo.collider.CompareTag("Obstacle");
    }

    /// <summary>
    /// Отключает движение игрока.
    /// </summary>
    private void DisablePlayerMovement()
    {
        if (movement != null)
        {
            movement.enabled = false;
        }
    }
}