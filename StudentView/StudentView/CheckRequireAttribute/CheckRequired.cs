using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentView.CheckRequireAttribute
{
    public class CheckRequiredAttribute : ValidationAttribute,IClientValidatable
    {
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
           ModelClientValidationRule myRule = new ModelClientValidationRule();
            myRule.ErrorMessage = base.ErrorMessage;
            myRule.ValidationType = "chkreq";
            return new ModelClientValidationRule[] {myRule};
        }

        public override bool IsValid(object value)
        {
            try
            {
                bool flag = (bool) value;
                return flag;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}