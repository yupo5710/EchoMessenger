# (C# 코딩) 에코 메신저

## 개요

- C# 프로그래밍 학습
- 1줄 소개: 사용자가 입력한 글을 화면에 보여주는 간단한 메신저 프로그램
- 사용한 플랫폼 :
  - C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  - Label, TextBox, ListBox, Button
- 사용한 기술과 구현한 기능:
  - Visual Studio를 이용하여 UI 디자인
  - string 클래스를 이용해 입력된 텍스트 처리
- 실습 중에 구현한 기능들 설명
  - 메시지 전송 기능 구현
 

---

## 실행 화면 (과제1)

- 과제1 코드의 실행 스크린샷  
  ![과제1 실행화면](img/screenshot-1.png)

### - 과제 내용
- Label (표시), TextBox(입력), Button(전송), ListBox(대화창)를 적절히 배치합니다.
- 전송 버튼 클릭 시 TextBox의 텍스트를 ListBox의 항목(Items)으로 추가합니다.
- 추가 직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비합니다.

### - 구현 내용과 기능 설명
- 입력창에 메시지를 입력하고 전송 버튼을 누르면 메시지가 리스트 박스에 표시된다.  
  사용한 코드:  
  `lbChatLog.Items.Add(txtMessege.Text);`
- 메시지를 보낸 후 입력창을 비워 다음 메시지를 입력할 수 있게 했다.  
  사용한 코드:  
  `txtMessege.Clear();`
- 메시지가 많아지면 자동으로 스크롤이 생겨 편하게 볼 수 있다. (ListBox 기본 기능)
---
## 실행 화면 (과제2)

- 과제2 코드의 실행 스크린샷  
  ![과제2 실행화면](img/screenshot-2.png)

### - 과제 내용
- 입력창의 기존 메시지 지우기
- 입력창에 입력 포커스 갖다 놓기
- 엔터키로 메시지 전송하기
- 입력 방어 (빈 메시지 전송 방지)

### - 구현 내용과 기능 설명
- 전송 후 입력창의 기존 메시지가 자동으로 지워지도록 구현됨.  
  사용한 코드:  
  `txtMessege.Clear(); // 입력창 초기화`

- 메시지 전송 후 입력창에 자동으로 포커스가 이동되도록 구현됨.  
  사용한 코드:  
  `txtMessege.Focus(); // 입력창에 포커스 설정`

- Enter 키를 눌러도 메시지가 전송되도록 구현됨.  
  사용한 코드:  
  `if (e.KeyCode == Keys.Enter) { Send.PerformClick(); }`

- 공백 또는 빈 문자열일 경우 메시지가 전송되지 않도록 방어 로직이 적용됨.  
  사용한 코드:  
  `if (!string.IsNullOrWhiteSpace(txtMessege.Text)) { // 메시지 전송 처리 }`
 ---
 # 실행 화면 (과제3)

- 과제3 코드의 실행 스크린샷  
  ![과제3 실행화면](img/screenshot-3.png)

### - 과제 내용
- 메시지 앞에 현재 시간(타임스탬프)을 자동으로 붙여 출력
- 현재까지 입력된 메시지 개수를 Label에 실시간으로 표시합니다.
- 사용자가 입력한 메시지의 앞뒤 공백을 Trim()으로 제거하여 저장합니다.
### - 구현 내용과 기능 설명
- 메시지 앞에 현재 시간이 자동으로 붙는다.  
  사용한 코드:  
  `string timeStamp = DateTime.Now.ToString("HH:mm:ss");`
- 메시지 개수를 Label에 표시한다.  
  사용한 코드:  
  `lblCount.Text = $"메세지 수 : {ChatLog.Items.Count}개";`
- Trim()으로 앞뒤 공백을 제거해 깔끔한 메시지를 만든다.  
  사용한 코드:  
  `string TrimMessege = txtMessege.Text.Trim();`



