using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ScrollLoginTest
{
	/// <summary>
	/// CustomReturnEntry Interface
	/// </summary>
	public class CustomReturnEntry : Entry
	{
		/// <summary>
		/// Return Type Property of the Entry
		/// </summary>
		public static readonly BindableProperty ReturnTypeProperty =
			BindableProperty.Create(propertyName: nameof(ReturnType),
				returnType: typeof(ReturnType),
				declaringType: typeof(CustomReturnEntry),
				defaultValue: ReturnType.Done);

		/// <summary>
		/// Type of the Keyboard Return Key
		/// </summary>
		public ReturnType ReturnType
		{
			get { return (ReturnType)GetValue(ReturnTypeProperty); }
			set { SetValue(ReturnTypeProperty, value); }
		}
	}

	public enum ReturnType
	{
		Default,
		Done,
		Go,
		Next,
		Search,
		Send,
	}
}
