using UnityEngine;

/// <summary>
/// Класс для управления движением игрока (кубика).
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [Header("Настройки движения")]
    [Tooltip("Скорость движения игрока вперед по оси Z.")]
    [SerializeField] private float forwardForce = 2000f; // Скорость движения вперед

    [Tooltip("Скорость движения игрока влево и вправо по оси X.")]
    [SerializeField] private float sidewaysForce = 500f; // Скорость бокового движения

    [Header("Компоненты")]
    [Tooltip("Ссылка на компонент Rigidbody игрока.")]
    [SerializeField] private Rigidbody rb; // Компонент Rigidbody

    /// <summary>
    /// Метод FixedUpdate вызывается с фиксированным интервалом.
    /// Используется для физических расчетов, таких как движение.
    /// </summary>
    private void FixedUpdate()
    {
        MoveForward();
        HandleSidewaysMovement();
    }

    /// <summary>
    /// Перемещает игрока вперед по оси Z с заданной скоростью.
    /// </summary>
    private void MoveForward()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    /// <summary>
    /// Обрабатывает движение игрока влево и вправо по оси X.
    /// </summary>
    private void HandleSidewaysMovement()
    {
        if (Input.GetKey("d")) // Движение вправо
        {
            ApplySidewaysForce(sidewaysForce);
        }
        else if (Input.GetKey("a")) // Движение влево
        {
            ApplySidewaysForce(-sidewaysForce);
        }
    }

    /// <summary>
    /// Применяет силу для движения влево или вправо.
    /// </summary>
    /// <param name="force">Сила, применяемая по оси X.</param>
    private void ApplySidewaysForce(float force)
    {
        rb.AddForce(force * Time.deltaTime, 0, 0);
    }
}