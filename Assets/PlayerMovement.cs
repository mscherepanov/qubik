using UnityEngine;

/// <summary>
/// Класс для управления движением игрока (кубика)
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [Header("Настройки движения")]
    [Tooltip("Скорость движения игрока по оси Z.")]
    [SerializeField] private float moveSpeed = 2000f; // Скорость движения

    [Header("Компоненты")]
    [Tooltip("Ссылка на компонент Rigidbody игрока.")]
    [SerializeField] private Rigidbody rb; // Компонент Rigidbody

    /// <summary>
    /// Метод Update вызывается каждый кадр
    /// Используется для обработки ввода и вызова методов движения
    /// </summary>
    private void Update()
    {
        MoveForward();
    }

    /// <summary>
    /// Перемещает игрока вперед по оси Z с заданной скоростью
    /// </summary>
    private void MoveForward()
    {
        // Применяем силу для движения вперед
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
    }
}