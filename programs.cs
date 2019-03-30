using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace P01.實作練習_簡單網站壓力測試
{
    class Program
    {
        /* 使用多個非同步工作，針對特定網站網址，進行壓力測試。
         * • 提示 • 
         * 請使用 Task.Run 建立10個工作  Task是為了忽略Thread實作細節
         * 可以使用 HttpClient.GetStringAsync(url).Result 取得結果
         * 在每個工作下，使用 HttpClient 物件，開啟HTTP連線到指定網址
         * 每個工作開啟兩次該 URL
         * 列出HTTP開始時間、Web API 回傳內容、結束時間
         * 有錯誤，要列出提示訊息
         */
        // 注意有幾條thread
        // 注意時間 (效能)
        // await 只能接Task(幫我們管理Thread的類別 => 協助管理非同步工作)
        // WhenAll, WaitAll

        private static TimeSpan totalSpent = new TimeSpan();
        private static object locker = new object();
        private static string url = "https://gist.github.com/doggy8088/";

        static async Task Main(string[] args)
        {
            //Console.WriteLine($"ThreadId={Thread.CurrentThread.ManagedThreadId} | 開始");
            Task[] tasks = new Task[10];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    using (var client = new HttpClient())
                    {
                        //Console.WriteLine($"ThreadId={Thread.CurrentThread.ManagedThreadId} | CallApi[client] - Start");
                        var s = DateTime.Now;
                        Task a = client.GetStringAsync(url);
                        Task b = client.GetStringAsync(url);
                        var e = DateTime.Now;
                        var spent = e - s;
                        //Console.WriteLine($"ThreadId={Thread.CurrentThread.ManagedThreadId} | CallApi[client] - Start");

                        Task.WaitAll(new Task[] { a, b });
                        //Task.WhenAll(new Task[] { a, b });

                        var threadId = Thread.CurrentThread.ManagedThreadId;
                        Console.WriteLine($"ThreadId={threadId} | 花費時間:{spent.ToString()}");

                        lock (locker)
                        {
                            totalSpent += spent;
                        }
                        //Console.WriteLine($"ThreadId={Thread.CurrentThread.ManagedThreadId} | CallApi[client] - End");
                    }
                });
            }
            Task.WaitAll(tasks);

            //一筆一筆跑
            //for (int i = 0; i < 10; i++)
            //{
            //    CallApi();
            //}

            Console.WriteLine($"ThreadId={Thread.CurrentThread.ManagedThreadId} | 總花費時間:{totalSpent.ToString()}");
            //Console.WriteLine($"ThreadId={Thread.CurrentThread.ManagedThreadId} | 結束");
            Console.ReadKey();
        }

        private static void CallApi()
        {
            using (var client = new HttpClient())
            {
                var s = DateTime.Now;
                client.GetStringAsync(url);
                client.GetStringAsync(url);
                var e = DateTime.Now;
                var spent = e - s;

                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"ThreadId={threadId} | 花費時間:{spent.ToString()}");
                totalSpent += spent;
            }
        }
    } 
}
