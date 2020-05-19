TagHelper是ASP.NET CORE出現的小幫手，目的是在.cshtml轉成html的過程中，對預計產生的html進行加工。    
有點像是MVC5的HtmlHelper，但我覺得用起來直覺上的好處是：方便閱讀。  

這次會提到ScriptTagHelper是因為黑大的文章，他提到了一個看起來很方便的標籤：asp-append-version
```html
    <script src="~/js/site.js" asp-append-version="true"></script>
```
直白地來說，這解決了一個惱人的問題：  
就是使用者端會暫存script的問題，有時候會讓開發人員蒙受冤屈，也就是「你的功能真的修正了嗎?」。  
過去常常聽到前輩的作法是：為自己的css或javascript檔案加上版號。而過去相對愚蠢的做法就是，請使用者自己清除暫存......。  

在MVC5的時候，其實我沒有認真注意過這個問題，回想最近在開發的時候，也有遇到相同的問題：  
功能在本機開發、驗證，覺得沒有問題後簽入並部署到SIT環境，結果測試人員說沒有功能。  
檢查後發現是測試人員的瀏覽器因為暫存了舊版的Script檔案，所以沒有新的function，在測試人員的client端清除暫存後。  

現在有了這個TagHelper，應該可以幫助不少，目前還不清楚有什麼不良的副作用。  
經過測試，同黑大所說：要掛上**asp-append-version**的檔案有異動才會更新版號。  
 
ref:
* [ScriptTagHelper.AppendVersion Property](https://docs.microsoft.com/zh-tw/dotnet/api/microsoft.aspnetcore.mvc.taghelpers.scripttaghelper.appendversion?view=aspnetcore-3.1#Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper_AppendVersion)
* [黑暗執行緒_ASP.NET Core 小技巧 - 防止 js/css/圖檔舊版 Cache 搗亂](https://blog.darkthread.net/blog/asp-append-version/)  
  
同場加映
* [黑暗執行緒_ASP.NET MVC5 - 自製 js/css 自動版本參數防止 Cache 舊版惹禍](https://blog.darkthread.net/blog/js-versioning-htmlhelper/)