# 【打內觴人】 keep working, keep learning, keep writing... #

* 學習清單

* .Net *
 
|項目|標籤|完成狀態|
|----|----|-------|
|Thread相關|-|-|
|委派方法跟實作|-|-|


* 書單 *
 
|書名|閱讀內容|完成狀態|
|----|----|-------|
|CLR via C#|-|-|
|大話設計模式|-|-|
|Web API建構與設計|-|-|


``` C#
public class AddAffixAttribute : Attribute, IActionFilter
    {
        private readonly string _prefix;
        private readonly string _suffix;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="suffix"></param>
        public AddAffixAttribute(string prefix, string suffix)
        {
            _prefix = prefix;
            _suffix = suffix;
        }

        /// <summary>
        /// Called before the action executes, after model binding is complete.
        /// </summary>
        /// <param name="context">The Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext.</param>
        public void OnActionExecuting(ActionExecutingContext context)
        {

        }

        /// <summary>
        /// Called after the action executes, before the action result.
        /// </summary>
        /// <param name="context">The Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext.</param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
```
