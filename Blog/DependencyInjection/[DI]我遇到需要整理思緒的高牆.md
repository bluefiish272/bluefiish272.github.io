開始開發ASP.Net Core以後，避免不了相依性注入，因為微軟是有計畫地讓使用者習慣這個做法，像過去的MVC一樣，以習慣取代配置。用一個相對好的框架，培養開發者比較正確的開發觀念。過去前輩常常說：「就用注入的方式!」，我也知道「注入」或"Inject"呀！但是DI這件事，對我來說是一道高牆，實作起來就是渾身不對勁。   
  
**我遇到了什麼問題？**  
   
* 我建立了一個WEB與一個API：在WEB有個Class Call，預計想要彙整HttpClient的處理，也就是將WEB呼叫API有關的實作都集中在Call裡面。
* 我想透過Config定義API的位置，因此有讀取Config的需求。(因為開發與營運的位置不同)  
  
在ASP.NET Core，要讀取Config，微軟官方與四海兄弟的建議作法都是透過「建構式注入」將<code>IConfiguration</code>，如下：  
```csharp
       public class Call
    {
        private readonly IConfiguration config;
        public Call(IConfiguration configuration)
        {
            this.config = configuration;
        }
        ...
     }
```
但是，我的<code>ProductController</code>會呼叫<code>Call</code>：  
```csharp
new Call(_config).GetProducts();
```
所以我必須在<code>ProductController</code>也將<code>IConfiguration</code>注入才能夠有config可以注入Call。  

寫到這裡我就覺得很奇怪，真的是這樣用嗎？  
為什麼好樣沒完沒了的建構式注入，我就查了一陣子，但是**方向是錯**的，像是：  
可不可以不用DI的方式取得Configuration，或者有沒有其他的注入方式。  

我忽略的本質：  
* 我的程式架構是不是有問題，需要這樣做嗎?
* DI的目的是什麼? DI真的是這樣用的嗎?

先將遇到的問題做個整理，我決定先瞭解一下DI的本質，以及WEB呼叫API的實作是不是有改善的方式。  
後面再將這些整理上來。  