<h3>AppService_Web：組態變數怎麼設定(置換)</h3>

ref: [Configure an App Service app in the Azure portal](https://docs.microsoft.com/zh-tw/azure/app-service/configure-common#configure-app-settings)    

> The same code uses your development settings when you debug locally, and it uses your production secrets when deployed to Azure.
 
 **先說結論**  
 [設定方式]
 * AppService(Web) / 設定 / 組態 / 應用程式設定
 * 名稱(key) = appsettings.json的Key
 * 值(Value) = appsettings.json的Value
 
 <hr/>
   
 **遇到的問題紀錄**  
 將WEB部署到AppServive上的時候，知道要去設定組態，讓appsettings.json的內容被更新成伺服器上的設定。  
 過去的經驗是會透過自定義的腳本，讀取符合條件的字串，將組態的值進行字串置換，變成目的環境的值。  
     
 因此我設定appsettings.json：  
```json
 {
    "ApiBaseUrl" : "__ApiBaseUrl__"
 }
```
然而，我以為在組態設定上要調整的key是<code>\_\_ApiBaseUrl\_\_</code>，但是這樣的設定讓我的WEB沒辦法呼叫API。  

透過AppServive提供的console去看appsettings.json發現仍來沒有被置換，因此開始進行測試。  
後來嘗試將key改成<code>ApiBaseUrl</code>，按下儲存會AppService會被重啟，這時候發現appsettings.json內容一樣沒有被置換。  
但是呼叫API已經成功取回資料，WEB的介面顯示正常。  
 
 回頭去看文章開頭貼的參考文章，應該是在runtime的時候，去使用設定在AppService上的組態。  
 
 Azure真的很方便...但是還是要謹記不要忘記很多細節。