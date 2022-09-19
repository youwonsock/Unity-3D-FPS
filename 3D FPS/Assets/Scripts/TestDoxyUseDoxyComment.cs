using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @brief class �ڵ忡 ���� ����!
 * @details �ڵ忡 ���� �� ����!
 * 
 * @note ���� ������ ���� ����!
 * 
 * @author �ۼ��� �̸�!
 * @date last change 2022/09/15
 */
public class TestDoxyUseDoxyComment : MonoBehaviour
{
    /**
     * @brief �������� ��� ����!
     */
    public int value1;

    /**
     * @brief �޼��� ���� ����
     * @details �޼��� �� ����
     * @param[in] a <- �Ű����� 1
     * @param[in] b <- �Ű����� 2
     * @param[out] c <- ���� �����͵��� ���޵ǰų� ��ȯ���� ������ ǥ�� (C#������ out Ű���尡 ���� ������ ������ �մϴ�.)
     * @return void <- �Լ��� void�ϱ�
     * 
     * @exception ����ó���� ����(�� �Լ����� ���ܰ� �����ϴ�.)
     * @throws throws�ϴ� ��ü�� �������� ����
     * 
     * @note ���� ����
     * @todo �� �� ����
     * @pre �̸� ȣ���ؾ� �� ����
     * @bug ���� ����
     * @warning ���� ���� �ۼ�
     * @see ������ �Լ� �Ǵ� ������ (�������� �Լ� �̸��� �ۼ��ϸ� �ڵ� ��ũ)
     * 
     * @code �߿��ڵ带 �����Ҷ� ���� ������ ����ŵ�ϴ�.
     * @endcode �߿��ڵ带 �����Ҷ� ���� ������ ����ŵ�ϴ�.
     */
    private void function1(int a, int b, out int c)
    {
        c = a;
        return;
    }
}
