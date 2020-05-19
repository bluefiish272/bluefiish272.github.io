[CSS]從套版發現<meta>與viewport, shrink-to-fit

在練習套版的過程中，因為別人的版型在Html中，Head內有一段如下：

```html
<meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
```

平常不會注意什麼，用就對了。
但是既然是套版，就好奇這些東西是什麼。

首先是<meta>跟其中的attribute name="viewport"，初步查詢是與畫面呈現有關係，尤其是手持式裝置。
另外一個好奇的點就是content中的設定：shrink-to-fit=no

接下來應該要花點時間來了解，這些東西大致的意義。
總不能一直用別人的東西都不了解吧~複製貼上還是要有道德的XD

<meta>是HTML中的element，在MDN有一段解釋如下：
> The HTML <meta> element represents metadata that cannot be represented by other HTML meta-related elements, like <base>, <link>, <script>, <style> or <title>.

ref: [<meta>: The Document-level Metadata element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/meta)me
詳細可以再從MDN的說明去追，這次重點不是要把meta完全搞懂。
  
大概來說，<mata>中name代表key, content裡代表value。
也就是有一份名為：viewport的metadata設定，其內容有三項為：
* width=device-width
* initial-scale=1.0
* shrink-to-fit=no
  
1. width：A shorthand descriptor for setting both min-width and max-width.
2. initial-scale：裝置載入文件後，預設的放大比例
3. shrink-to-fit=no：是為了iOS9的設定，避免畫面被縮放(因為width=device-width這個設定會依據寬度縮放畫面)

查完以後，還是覺得哪裡有點怪怪的。
會先實做看看，看看到底會發生什麼事情。