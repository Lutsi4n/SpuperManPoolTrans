using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermanPower : MonoBehaviour
{
    public float punchForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>(); // �������� ��������� Rigidbody �������, � ������� �����������

        if (rb != null) // ���� ������, � ������� �����������, ����� Rigidbody
        {
            Vector3 punchDirection = collision.contacts[0].point - transform.position; // ���������� ����������� ����� �� ������ ��������� � ������ �������
            punchDirection = punchDirection.normalized; // ����������� ������ �����������
            rb.AddForce(punchDirection * punchForce, ForceMode.Impulse); // ������� ���� � �������� ����� � �������� �����������
        }
    }
}
