using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CFCAulas.Controls
{
    public class CustomLabel : Label
    {
        public readonly BindableProperty JustifyTextProperty =
           BindableProperty.Create(
               propertyName: nameof(JustifyText),
               returnType: typeof(Boolean),
               declaringType: typeof(CustomLabel),
               defaultValue: false,
               defaultBindingMode: BindingMode.OneWay
        );
        public Boolean JustifyText
        {
            get => (Boolean)GetValue(JustifyTextProperty);
            set => SetValue(JustifyTextProperty, value);
        }
    }
}
