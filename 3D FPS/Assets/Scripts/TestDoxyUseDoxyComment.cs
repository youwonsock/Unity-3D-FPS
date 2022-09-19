using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @brief class 코드에 대한 개요!
 * @details 코드에 대한 상세 설명!
 * 
 * @note 참고 사항을 적는 공간!
 * 
 * @author 작성자 이름!
 * @date last change 2022/09/15
 */
public class TestDoxyUseDoxyComment : MonoBehaviour
{
    /**
     * @brief 변수에도 사용 가능!
     */
    public int value1;

    /**
     * @brief 메서드 간략 설명
     * @details 메서드 상세 설명
     * @param[in] a <- 매개변수 1
     * @param[in] b <- 매개변수 2
     * @param[out] c <- 만약 포인터등이 전달되거나 반환값이 있으면 표시 (C#에서는 out 키워드가 참조 전달의 역할을 합니다.)
     * @return void <- 함수가 void니까
     * 
     * @exception 예외처리를 설명(이 함수에는 예외가 없습니다.)
     * @throws throws하는 객체나 변수등을 설명
     * 
     * @note 참고 설명
     * @todo 할 일 설명
     * @pre 미리 호출해야 할 사항
     * @bug 버그 설명
     * @warning 주의 사항 작성
     * @see 참고할 함수 또는 페이지 (페이지나 함수 이름을 작성하면 자동 링크)
     * 
     * @code 중요코드를 설명할때 시작 지점을 가리킵니다.
     * @endcode 중요코드를 설명할때 종료 지점을 가리킵니다.
     */
    private void function1(int a, int b, out int c)
    {
        c = a;
        return;
    }
}
