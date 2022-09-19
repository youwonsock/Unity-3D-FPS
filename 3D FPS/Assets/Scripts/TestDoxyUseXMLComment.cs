using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

/// <summary>
/// 코드에 대한 개요
/// </summary>
/// 
/// <remarks>
/// 코드에 대한 상세 설명
/// </remarks>
/// 
/// @author 작성자 이름!
/// @date last change 2022/09/15
public class TestDoxyUseXMLComment : MonoBehaviour
{
    /// <summary>
    /// 변수에도 사용 가능!
    /// </summary>
    public int value1;

    /// <summary>
    /// 메서드 간략 설명!
    /// </summary>
    /// 
    /// <remarks>
    /// 메서드 상세 설명
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
    /// 메서드가 던질 수 있는 예외 
    /// 여기서는 임의로 UnityException으로 해둠
    /// </exception>
    /// 
    /// 아래의 tag들은 XML에서 대신 사용하는 tag가 무엇인지 몰라 기존 스타일 그대로 사용!
    /// 
    /// @note 참고 설명
    /// @todo 할 일 설명
    /// @pre 미리 호출해야 할 사항
    /// @bug 버그 설명
    /// @warning 주의 사항 작성
    /// @see 참고할 함수 또는 페이지(페이지나 함수 이름을 작성하면 자동 링크)
    /// 
    /// @code 중요코드를 설명할때 시작 지점을 가리킵니다.
    /// @endcode 중요코드를 설명할때 종료 지점을 가리킵니다.
    /// @author 작성자 이름!
    /// @date last change 2022/09/15
    private void function1(int a, int b, out int c)
    {
        c = a;

        return;
    }
}
