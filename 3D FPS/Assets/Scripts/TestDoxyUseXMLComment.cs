using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

/// <summary>
/// �ڵ忡 ���� ����
/// </summary>
/// 
/// <remarks>
/// �ڵ忡 ���� �� ����
/// </remarks>
/// 
/// @author �ۼ��� �̸�!
/// @date last change 2022/09/15
public class TestDoxyUseXMLComment : MonoBehaviour
{
    /// <summary>
    /// �������� ��� ����!
    /// </summary>
    public int value1;

    /// <summary>
    /// �޼��� ���� ����!
    /// </summary>
    /// 
    /// <remarks>
    /// �޼��� �� ����
    /// </remarks>
    /// 
    /// <param name="a"> param a </param>
    /// <param name="b"> param b </param>
    /// <param name="c"> param c </param>
    /// 
    /// <returns>
    /// void
    /// </returns>
    /// 
    /// <exception cref="UnityException">
    /// �޼��尡 ���� �� �ִ� ���� 
    /// ���⼭�� ���Ƿ� UnityException���� �ص�
    /// </exception>
    /// 
    /// �Ʒ��� tag���� XML���� ��� ����ϴ� tag�� �������� ���� ���� ��Ÿ�� �״�� ���!
    /// 
    /// @note ���� ����
    /// @todo �� �� ����
    /// @pre �̸� ȣ���ؾ� �� ����
    /// @bug ���� ����
    /// @warning ���� ���� �ۼ�
    /// @see ������ �Լ� �Ǵ� ������(�������� �Լ� �̸��� �ۼ��ϸ� �ڵ� ��ũ)
    /// 
    /// @code �߿��ڵ带 �����Ҷ� ���� ������ ����ŵ�ϴ�.
    /// @endcode �߿��ڵ带 �����Ҷ� ���� ������ ����ŵ�ϴ�.
    /// @author �ۼ��� �̸�!
    /// @date last change 2022/09/15
    private void function1(int a, int b, out int c)
    {
        c = a;

        return;
    }
}
