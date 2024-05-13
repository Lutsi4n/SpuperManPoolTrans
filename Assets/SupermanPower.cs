using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermanPower : MonoBehaviour
{
    public float punchForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>(); // Получаем компонент Rigidbody объекта, с которым столкнулись

        if (rb != null) // Если объект, с которым столкнулись, имеет Rigidbody
        {
            Vector3 punchDirection = collision.contacts[0].point - transform.position; // Определяем направление удара от центра Супермена к центру объекта
            punchDirection = punchDirection.normalized; // Нормализуем вектор направления
            rb.AddForce(punchDirection * punchForce, ForceMode.Impulse); // Наносим удар с заданной силой в заданном направлении
        }
    }
}
