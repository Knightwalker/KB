﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] objProperties = obj.GetType().GetProperties();

            foreach (var propInfo in objProperties)
            {
                IEnumerable<MyValidationAttribute> propAttributes = propInfo.GetCustomAttributes().Where(a => a is MyValidationAttribute).Cast<MyValidationAttribute>();

                foreach (var propAttribute in propAttributes)
                {
                    bool result = propAttribute.IsValid(propInfo.GetValue(obj));

                    if(!result)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
