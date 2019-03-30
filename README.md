# 【打內觴人】 keep working, keep learning, keep writing... #

### 學習清單 ###

+ .Net / C# / OOP / 設計模式
 
|項目|標籤|閱讀|實作|
|----|:----:|----:|----:|
|Program, Process, Thread|N/A|`50%`|`0%`|
|Thread的同步與非同步|N/A|`10%`|`0%`|
|Lock, 鎖|N/A|`30%`|`0%`|
|委派方法|N/A|`70%`|`0%`|
|泛型&條件約束|N/A|`50%`|`0%`|
|Real Proxy|N/A|`20%`|`0%`|
|簡單工廠模式|設計模式|`100%`|`100%`|

+ 其它...
 
|項目|標籤|完成狀態|
|---|:----:|:----:|
|Redis Cluster|-|-|
|UML練習|-|-|


+ 書單
 
|書名|已讀內容|閱讀進度|
|----|-----|:----:|
|CLR via C#||-|
|大話設計模式|-|-|
|Web API建構與設計|-|-|


### 實務探討 ###
```
1. 3~5千人同時使用(選課) => DB IO卡住 <br/>
==> 不適合使用非同步設計, 因為是DB IO瓶頸, 不是WEB或AP的 CPU衝不上去 <br/>
2. 如果是 WEB -> Redis -> DB的架構, 同時3~5000的請求發到web, 這時候有可能web的CPU衝到90~100% 那改用非同步也沒意義 <br/>
3. 同步與非同步的設計不建議混用 (會很可怕)
```
