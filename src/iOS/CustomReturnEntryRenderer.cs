using System;

using UIKit;
using Foundation;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using ScrollLoginTest;
using ScrollLoginTest.iOS;

[assembly: ExportRenderer(typeof(CustomReturnEntry), typeof(CustomReturnEntryRenderer))]
namespace ScrollLoginTest.iOS
{
    [Preserve(AllMembers = true)]
    public class CustomReturnEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Used for registration with the dependency service
        /// </summary>
        /// <returns></returns>
        public new static void Init()
        {
            var temp = DateTime.Now;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var customEntry = Element as CustomReturnEntry;

            if (Control != null && customEntry != null)
            {
                Control.ReturnKeyType = GetKeyboardButtonType(customEntry.ReturnType);
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CustomReturnEntry.ReturnTypeProperty.PropertyName)
            {
                var customEntry = sender as CustomReturnEntry;

                if (Control != null && customEntry != null)
                    Control.ReturnKeyType = GetKeyboardButtonType(customEntry.ReturnType);
            }

        }

        UIReturnKeyType GetKeyboardButtonType(ReturnType returnType)
        {
            switch (returnType)
            {
                case ReturnType.Go:
                    return UIReturnKeyType.Go;
                case ReturnType.Next:
                    return UIReturnKeyType.Next;
                case ReturnType.Send:
                    return UIReturnKeyType.Send;
                case ReturnType.Search:
                    return UIReturnKeyType.Search;
                case ReturnType.Done:
                    return UIReturnKeyType.Done;
                default:
                    return UIReturnKeyType.Default;
            }
        }
    }
}
