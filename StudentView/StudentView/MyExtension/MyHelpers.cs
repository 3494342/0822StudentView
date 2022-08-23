using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace StudentView.MyExtension
{
    public static class MyHelpers
    {
        public static MvcHtmlString Submit(this HtmlHelper html, string caption, object htmlatt)
        {
            //string mysubmit = string.Format("<input type=\"submit\"value=\"{0}\"class=\"{1}\">", caption, cssClass);
            //return new MvcHtmlString(mysubmit);
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type","submit");
            tb.Attributes.Add("value",caption);
            //tb.Attributes.Add("class",cssClass);

            tb.MergeAttributes(htmlatt!=null?HtmlHelper.AnonymousObjectToHtmlAttributes(htmlatt):null);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));

        }
  
        public static MvcHtmlString MyCheckBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression, object value)
        {
            ModelMetadata model = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string propName = model.PropertyName;
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type","checkbox");
            tb.Attributes.Add("id",propName);
            tb.Attributes.Add("name",propName);
            tb.Attributes.Add("value",value.ToString());

            //checkbox没有反应
            if(model.Model!=null&& value.ToString()==model.Model.ToString())
                tb.Attributes.Add("checked","checked");
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}