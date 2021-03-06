**<前情提要>**  
切輪播圖版面的時候，要把「左右方向按鈕」加上去。  
原本的作法是：  
透過<code>display:inline-block</code>，分成三個區塊：左按鈕、內容、右按鈕。  
但是發現這樣切，會有互相擠壓的問題，就是沒辦法安分的在同一個區塊內分成三塊。   

於是就更改作法，讓方向按鈕是浮起來的，也就是有圖層的概念出來。  
因為撞到一些牆，所以做個筆記記錄下來。  

1. 加上float後，沒有浮在輪播圖的區塊上方。  
2. 浮在輪播圖區塊上方後，沒有辦法點到。  

**問題一：float卻沒有浮在目的區塊上方(重疊)**  
因為目的區塊本身就佔有自己的高與寬，而按鈕的區塊，就算讓他浮起來，也會因為目的區塊的高而被擠到目的區塊的下方。 
所以要再透過<code>style="margin-top:-Xpx;"</code>讓按鈕區塊可以浮在目的區塊的上方(重疊)。  
* 用負的margin，扣掉高度讓他往上(回)走，而X就是目的區塊有多高，就扣多少。
  
  
**問題二：浮在目的區塊上方了，卻點不到，無法觸發click事件**  
這就是要加上Z軸，確保元素在最上方，才能夠點到；  
z-index，數字越大，圖層越上面。  
但是我加了卻還是沒有用，因為要讓加上z-index的元素，還需要明確指定position，  
所以我還加了<code>style="position: relative;"</code>
