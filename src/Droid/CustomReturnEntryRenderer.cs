using System;

using Android.Widget;
using Android.Runtime;
using Android.Views.InputMethods;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ScrollLoginTest;
using ScrollLoginTest.Android;

[assembly: ExportRenderer(typeof(CustomReturnEntry), typeof(CustomReturnEntryRenderer))]
namespace ScrollLoginTest.Android
{
    /// <summary>
    /// CustomReturnEntry Implementation
    /// </summary>
    [Preserve(AllMembers = true)]
    public class CustomReturnEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
            var temp = DateTime.Now;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var customEntry = Element as CustomReturnEntry;

            if (Control != null && customEntry != null)
            {
                Control.ImeOptions = GetKeyboardButtonType(customEntry.ReturnType);
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CustomReturnEntry.ReturnTypeProperty.PropertyName)
            {
                var customEntry = sender as CustomReturnEntry;

                if (Control != null && customEntry != null)
                    Control.ImeOptions = GetKeyboardButtonType(customEntry.ReturnType);
            }

        }

        ImeAction GetKeyboardButtonType(ReturnType returnType)
        {
            switch (returnType)
            {
                case ReturnType.Go:
                    return ImeAction.Go;
                case ReturnType.Next:
                    return ImeAction.Next;
                case ReturnType.Send:
                    return ImeAction.Send;
                case ReturnType.Search:
                    return ImeAction.Search;
                case ReturnType.Done:
                    return ImeAction.Done;
                default:
                    return ImeAction.Done;
            }
        }
    }
}

