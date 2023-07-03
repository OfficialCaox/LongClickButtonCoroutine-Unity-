# LongClickButtonCoroutine-Unity-
Implementation of long click button using coroutines in Unity(유니티에서 코루틴을 이용한 롱클릭 버튼의 구현)

만들기 귀찮아서 구글링을 좀 해봤는데 Update를 이용한 스크립트 뿐이어서 직접 제작해서 올려봅니다

Update는 필요 없을 때도 호출되기에 특정 이벤트(여기서는 n초이상 누르고 있을 시)가 발생시 코루틴을 호출하는 것이 최적화에 더 가깝다고 봅니다.

=================================================================
Unity Button에

+Event Trigger 추가
+PointerDown 추가
+PointerUp 추가

각 
PointerDown에 OnPointerDown() 할당

PointerUp에 OnPointerUp() 할당
