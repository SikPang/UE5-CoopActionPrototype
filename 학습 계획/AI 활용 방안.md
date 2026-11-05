# 1. 그러면 AI는 어떻게 해야 하나

여기서는 제 판단이 꽤 명확합니다.

### “AI 없이 전부 직접 구현했다”

를 어필하는 전략은 추천하지 않아요.

면접관이 확인할 방법도 없고, 2026년에 그것 자체가 특별한 경쟁력도 아닙니다.

그리고 사용자님은 AI를 실무에서 사용한 이력이 있습니다.

지금 와서

> Unreal 프로젝트는 AI를 전혀 사용하지 않았습니다.

라고 강조하는 건 오히려 현재 프로필과 맞지 않습니다.

---



# 2. 하지만 처음부터 AI에게 “이거 만들어줘”도 안 됩니다

특히 아래는 **초기에는 직접 해야 합니다.**

### 직접 공부하고 직접 첫 구현

- UObject lifecycle
- Actor lifecycle
- Gameplay Framework
- Replication
- RPC
- CharacterMovement
- C++ ownership
- Delegate
- GAS 기본 구조
- Asset Manager
- Unreal Insights

이것들은 면접에서 바로 물어볼 가능성이 높은 영역이에요.

AI가 구현해 준 코드를 붙이면 프로젝트는 돌아가더라도 면접에서 막힙니다.

---



# 3. 제가 권하는 AI 사용 방식은 이렇습니다

처음 구조를 배울 때:

```text
공식 문서
↓
직접 이해
↓
작은 코드 직접 작성
↓
실행
↓
AI 코드 리뷰
```

이 순서로 가세요.

그 다음 프로젝트 중반부터는 적극적으로 사용합니다.

### AI 적극 사용

- 보일러플레이트 생성
- 반복적인 UPROPERTY/UFUNCTION 코드
- 로그 분석
- crash 원인 후보 분석
- 테스트 케이스 제안
- 코드 리뷰
- refactoring 후보 탐색
- Unreal API 탐색 보조
- 문서 요약
- README 작성 보조

### AI에 맡기지 않을 것

- 전체 architecture 결정
- network authority 모델 결정
- replication strategy 결정
- UObject lifetime 판단
- performance 문제 원인 확정
- AI가 작성한 코드를 이해하지 않고 merge

입니다.

---



# 4. 포트폴리오에서 AI 사용을 보여줘야 하나

**보여주는 게 낫습니다.**

하지만 메인 컨텐츠로는 보여주지 마세요.

README 아래쪽에 작은 섹션 하나면 충분합니다.

예를 들어:

### AI-assisted Development

```text
AI 도구를 다음 영역에 활용

- Unreal API 및 엔진 코드 탐색 보조
- 반복 코드 작성
- 코드 리뷰 및 리팩토링 후보 탐색
- 자동화 테스트 케이스 생성 보조
- Unreal Insights 로그 분석 보조

핵심 게임 구조, Replication 정책, 객체 수명 관리,
성능 개선 방향은 직접 설계 및 검증.
AI가 제안한 코드는 문서 및 엔진 소스와 대조 후 적용.
```

이 정도예요.

---



# 5. 더 좋은 방법은 AI 사용 사례를 하나만 깊게 보여주는 겁니다

예를 들어 프로젝트 도중 이런 일이 있었다고 해보죠.

```text
Dedicated Server에서
특정 조건에서 Character가 Destroy된 뒤
delegate callback으로 접근하며 crash
```

이걸

1. Crash log 수집
2. AI에게 call stack과 관련 코드 분석 요청
3. AI가 원인 후보 3개 제시
4. 직접 UObject lifetime과 delegate binding 확인
5. weak binding 또는 unbind 처리
6. 재현 테스트
7. 수정

했다면,

README에 한 단락 정도:

> AI를 debugging assistant로 사용했지만 최종 원인은 UObject lifecycle과 delegate lifetime을 직접 확인하여 판단했다.

라고 쓰세요.

**이게 AI 시대 개발자의 좋은 사용 방식입니다.**

---



# 6. 오히려 “AI로 얼마나 만들었는지”를 측정하지는 마세요

이런 건 권하지 않습니다.

> 전체 코드의 37% AI 작성

> AI로 개발 속도 2배

> 프롬프트 145개 사용

채용자가 알고 싶은 정보가 아니에요.

중요한 건

> **AI가 있어도 이 코드의 owner가 사용자님인가?**

입니다.

면접에서 어떤 클래스든 열었을 때

> 왜 이렇게 만들었나요?

라고 물으면 대답할 수 있어야 합니다.

---



# 7. 면접관이 정말 AI 안 쓰고 구현한 걸 알아줄까?

대부분 **알 방법이 없습니다.**

Git history를 아무리 봐도 확실하게 알 수 없어요.

그리고 중요한 판단 기준도 아닙니다.

면접관은 대신 이런 걸 물어봅니다.

> 왜 RPC를 Reliable로 했나요?

> 이것을 RepNotify로 하지 않은 이유는?

> CharacterMovement는 이미 prediction을 하는데 무엇을 추가했나요?

> PlayerState와 Character 중 어디에 데이터를 두었고 왜 그런가요?

> 서버에서 검증하지 않으면 어떤 cheat가 가능한가요?

> Hard Reference 대신 Soft Reference를 사용한 이유는?

> UObject가 GC되는 조건은?

> TSharedPtr을 UObject에 쓰면 왜 문제가 될 수 있나요?

> 이 병목을 어떻게 발견했나요?

이걸 설명하면 **누가 코드를 타이핑했느냐는 중요하지 않게 됩니다.**

---



# 8. AI 사용 규칙도 주차별로 바꿉니다

## Week 1에서 3

**강하게 제한합니다.**

AI에게

> 이 기능 구현해줘.

하지 마세요.

가능한 건:

> UObject와 Actor lifetime 차이를 설명해줘.

> 이 컴파일 오류가 무슨 뜻인지 설명해줘.

> 공식 문서에서 어떤 키워드를 찾아봐야 하는지 알려줘.

정도입니다.

핵심 Unreal 구조는 한 번은 직접 구현해야 합니다.

---

## Week 4에서 7

AI 사용 범위를 늘립니다.

가능:

- API 탐색
- boilerplate
- 코드 리뷰
- crash 분석
- 테스트 아이디어
- replication edge case 검토

단, 네트워크 구조와 GAS architecture는 직접 결정합니다.

---

## Week 8 이후

적극 사용하세요.

특히

- profiler trace 분석 보조
- 반복 코드
- test case 생성
- refactoring
- README
- build automation
- log 분석

에 사용합니다.

그리고 프로젝트 루트에

```text
AI_USAGE.md
```

하나를 둬도 좋습니다.

프롬프트 전체를 기록하는 게 아니고

```text
어디에 사용했는가
AI 제안을 어떻게 검증했는가
AI 제안을 거절한 사례
```

만 적습니다.

이건 꽤 괜찮은 차별화 요소가 될 수 있어요.

---

