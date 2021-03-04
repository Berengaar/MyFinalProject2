using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspect.Autofac.Validation
{
    public class ValidationAspect : MethodInterception      //Aspect => Metodun başında sonunda ortasında hata verdiğinde çalışacak metot.
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)        //Doğrulama metodun başında yapılır ondan sadece OnBefore yazılır
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);       //Activator.CreateInstance => çalışma anındaki newleme, nesne oluşturma
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];          
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);  //Metodun argümanlarını gez
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
