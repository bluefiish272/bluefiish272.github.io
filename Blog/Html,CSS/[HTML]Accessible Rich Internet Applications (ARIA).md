又是在設計版面的時候，注意到預設的樣板中有段HTML，好奇為什麼要這樣寫:  
```html
<main role="main">...</main>
```

先查了MDN：[\<main\>_Accessibility concerns](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/main#Accessibility_concerns)
看不太懂，看起來是為了讓HTML的文件可以更被瀏覽器理解(?)    
接著繼續閱讀：[ARIA: Main role](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Roles/Main_role)  
  
推測是因為<code>\<main\></code>，不是所有瀏覽器可以解析，所以要輔以role="main"讓瀏覽器讀起HTML的時候可以理解。  
  
  
小心得：HTML也是博大精深QAQ  
魔鬼藏在細節裡，細節就是重要的地方。  
  
額外補充：  
* [MDN-ARIA](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA)
* [ARIA 簡介](https://developers.google.com/web/fundamentals/accessibility/semantics-aria?hl=zh-tw)