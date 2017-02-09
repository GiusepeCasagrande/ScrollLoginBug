﻿using System;
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
		/// Occurs when the user finalizes the text in an entry with the return key
		/// </summary>
		public static readonly BindableProperty ReturnCommandProperty =
			BindableProperty.Create(nameof(ReturnCommand), typeof(ICommand), typeof(CustomReturnEntry), null);

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

		/// <summary>
		/// Invoke Completed event
		/// </summary>
		public ICommand ReturnCommand
		{
			get { return (ICommand)GetValue(ReturnCommandProperty); }
			set { SetValue(ReturnCommandProperty, value); }
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
