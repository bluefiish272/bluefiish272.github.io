在練習切版的過程中，有遇到高度的問題。  
一直想說我有賦予div固定的高度，為什麼沒有感覺。  
後來發現是因為div裡面沒有東西，所以就算設定height:100%也是沒有感覺。  
  
後來又查到兩個跟高度、寬度有關的設定：vh跟vw，分別代表  
1%viewport height => 40vh 表示40%的螢幕高度  
1%viewport weidth => 30vw 表示30%的螢幕寬度
  
在MDN中可以看到，這是一種單位的表示：
[Relative_length_units](https://developer.mozilla.org/en-US/docs/Learn/CSS/Building_blocks/Values_and_units#Relative_length_units)