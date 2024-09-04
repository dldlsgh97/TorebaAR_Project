## 📗 : 프로젝트



- Name : TorebaAR
- 프로젝트 기한 : 2022년 2학기 증강현실 기초 및 실습 최종 프로젝트
- 프로젝트 설명 : 웹에서 플레이하는 Toreba라는 인형뽑기를 Vuforia 와 유니티를 이용해서 간략하게 구현한 프로젝트
- Stack : Unity, C#, Vuforia



## 📽️ : 시연영상

- https://youtu.be/lABBZdNet8I


## 🌐 : 실행파일 링크

- [실행 APK파일 다운로드 링크](https://drive.google.com/file/d/1jTi5V4giNB__oCBu9YiGFZrg7Yn8Y3jp/view?usp=drive_link)

## ⚙️ : 구현 기능

- 시작 UI
    - 게임을 시작하고 게임시작 마커를 인식해야 게임이 시작됨
 
 
        ![1-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/be5483d4-29fc-4798-b9c2-758bdb159ee7)

        
        
    - 게임이 시작되고 코인 마커를 인식하면 Credit이 올라감
 
  
        ![1-ezgif com-video-to-gif-converter (1)](https://github.com/user-attachments/assets/a3ac4965-e01d-4d32-87a0-2f9a085b0ac0)

        
        
- 이동
    - 마커를 인식하면 인형뽑기의 기계가 상하좌우로 이동함

        ![3-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/299d3f66-6bc9-484e-8d3d-5ecb662bb781)
![2-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/eae14eee-50de-4c6c-8cbd-19f1c29e8688)


        
    - 밀기 마커를 인식하면 인형뽑기 기계가 상품을 밀어냄
        
        ![4-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/1fdab4fb-19c6-4838-8bd6-0f0ad7c0bd2a)

        
- 상품획득
    - 상품이 밀려서 떨어지면 소리가 나면서 상품을 획득
        
        
        ![5-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/bf0c951e-9b6e-4bad-95d6-a366be4b5f58)




## 💫 Troubleshooting


<aside>
❓ 물체를 밀어내는 기계부분을 늘어나게 만드는것


📌트러블 슈팅 해결 방안

- 같은 크기의 큐브를 겹쳐 놓은 뒤 순서대로 움직이는 방법을 사용

📌트러블 슈팅 결과

- 물체를 밀어내는 기계부분을 자연스럽게 제작
</aside>





<aside>
❓ 물체를 밀어낸 뒤 기계를 원위치로 돌아오는 과정에서 오차 발생

  
📌트러블 슈팅 해결 방안

- Transform을 사용해서 돌아오게 하는것이 아닌 위치 좌표를 입력해서 직접 좌표로 이동하는 방법으로 해결

📌트러블 슈팅 결과

- 물체를 밀어내는 기계의 위치가 자연스럽게 변경
</aside>


## 📢 프로젝트 진행중 아쉬웠던 점



- 크레인
    - 처음 프로젝트 기획 단계에서 일반적인 크레인 인형뽑기를 제작 하려고 했지만 크레인 제작도중 오류가 많이 발생해서 현재와 같은 형태로 변경했다.
- 난이도
    - 마커를 사용해서 조작하다 보니 기계를 조작하는데 원하는 위치에 멈추지 못하거나 원하는 시점에 기계를 이동하지 못하는게 아쉬웠다.
- 상품의 충돌 판정
    - 상품의 충돌을 판정하는 콜라이더를 조금 더 세밀하게 만들어야 상품의 빈공간을 밀었을때 상품이 밀리지 않아야 하는데 콜라이더를 세밀하게 만들지 못한것이 아쉬웠다.



## 📁 : 에셋 출처



- [FREE Christmas Presents / Low Poly](https://assetstore.unity.com/packages/3d/props/free-christmas-presents-low-poly-24356)
- [Low Poly Fruit Pickups](https://assetstore.unity.com/packages/3d/props/food/low-poly-fruit-pickups-98135)
- [코인 마커](https://www.pinterest.co.kr/pin/446067538105111685/)
- [코인 효과음](https://www.sellbuymusic.com/search/soundeffect)
- [QR코드 마커(왼쪽이동 제외)](https://ko.online-qrcode-generator.com/)
- [QR코드 마커(왼쪽 이동)](https://ko.wikipedia.org/wiki/QR_%EC%BD%94%EB%93%9C)

---
