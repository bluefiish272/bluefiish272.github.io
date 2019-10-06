## RWD的學習筆記

#### 小小前言
剛學WEB的時候, 因為使用微軟的MVC樣板，所以習慣有bootstrap...  
進入公司開發後，因為有UI或者是已經處理過的樣板框架，總認為RWD這件事情就是Bootstrap...  

~~直到我膝蓋中了一箭~~

自己嘗試用純Html寫小工具的時候，因為想要電腦與手機都可以輕鬆閱讀，才發現Bootstrap的GridSystem...只是邊邊角角呀!
真是井底之蛙.

於是還是要認真地看一下，RWD到底是什麼。

#### 閱讀清單
* [Responsive Web Design](https://alistapart.com/article/responsive-web-design)
* [FluidGrids](https://alistapart.com/article/fluidgrids/)
* [Responsive Web Design (RWD) 響應式網站開發教學與心得](https://sweeteason.pixnet.net/blog/post/42130394#c1)
* [Bootstrap-Layout](https://getbootstrap.com/docs/4.3/layout/overview/)
* [MDN-CSS彈性盒子用法](https://developer.mozilla.org/zh-TW/docs/Web/CSS/CSS_Flexible_Box_Layout/Using_CSS_flexible_boxes)
* [MDN-Basic concepts of flexbox](https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_Flexible_Box_Layout/Basic_Concepts_of_Flexbox)

  
閱讀過程中夾雜的小小實作，但說實在的想要直接無痛上手是很不切實際的行為。  
因為對CSS沒有基礎概念，只是套用了bootstrap4就以為自己就是無敵(...這想法真嫩)。  
所以還是要稍微看一下什麼是Flexbox、Fluid、Float...那些乍看很抽象的名詞。  
然後完成一個作品--為自己的GitHub Blog設計版面且至少可以在兩種裝置上好好閱讀。

#### 名詞速記
* CSS: media queries / Flexbox 
* CSS Framwork: bootstrap
* screen resolution ??

#### 筆記
透過CSS3的media querier可以替不同的螢幕尺寸進行CSS的設計,  
用圖塊的方式思考，將一行(100%)，再不同尺寸切分不同等分。例如：切成2等分: width: ≒48%; 切成3等分: width: ≒31%; ...依此類推。
於是在不同尺寸的螢幕，一行就可以放下不同等份的圖塊。  
其實沒有想像中複雜，但實作也不是可以無痛上手。


#### 部分摘要
> We can design for an optimal viewing experience, 
> but embed standards-based technologies into our designs to make them not only more flexible, 
> but more adaptive to the media that renders them. 
> In short, we need to practice responsive web design.

> We can design for an optimal viewing experience, 
> 	but embed standards-based technologies into our designs to make them not only more flexible, 
> 	but more adaptive to the media that renders them. 
> In short, we need to practice responsive web design.

> A media query allows us to target not only certain device classes, 
> 	but to actually inspect the physical characteristics of the device rendering our work. 
> For example, following the recent rise of mobile WebKit, 
> 	media queries became a popular client-side technique for delivering a tailored style sheet to the iPhone, Android phones, and their ilk. 
> To do so, we could incorporate a query into a linked style sheet’s media attribute...

> 結論中提到 Fluid Grids、Fluid /Flexible Image、Media Queries 是進行 RWD 時最重要的三項技術
> 1. 流動的區塊 (可隨著螢幕大小折行)
> 2. 靈活有彈性的圖片 (可隨著螢幕大小比例伸縮)
> 3. 使用CSS3 Media Queries (依照不同尺寸裝置給予相對應的呈現) 
