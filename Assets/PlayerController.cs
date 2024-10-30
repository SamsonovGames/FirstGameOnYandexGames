using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField]
    float speed, angularSpeed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (direction.y != 0)
        {
            if (direction.x != 0)
            {
                transform.eulerAngles += new Vector3(0, angularSpeed * Time.deltaTime * direction.x * direction.y, 0);
            }
            movement= transform.forward * speed * direction.y;
        }
        rb.linearVelocity = movement;
        //transform.position += new Vector3(x,y,z(0)) x y ����� �� ��������� direction.x, direction.y
    }

    public void Move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    // ������� ���� � ������� ����� ������ ���, ������ ��������� �� x � y(WASD), ��� �������. ��� ������ ������
    //������ ������ ������ ����� ����� (�������� z = -10), ��� �� 0 ��� ����
    //���������������� � ������� ��������� ����������� ����.
}
