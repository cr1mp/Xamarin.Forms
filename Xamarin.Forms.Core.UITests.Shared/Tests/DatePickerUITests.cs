using NUnit.Framework;
using Xamarin.Forms.CustomAttributes;

namespace Xamarin.Forms.Core.UITests
{
	[TestFixture]
	[Category(UITestCategories.DatePicker)]
	internal class DatePickerUITests : _ViewUITests
	{
		public DatePickerUITests()
		{
			PlatformViewType = Views.DatePicker;
		}

		protected override void NavigateToGallery()
		{
			App.NavigateToGallery(GalleryQueries.DatePickerGallery);
		}

		// View Tests
		// TODO
		public override void _Focus()
		{
		}

		[UiTestExempt(ExemptReason.CannotTest, "Invalid interaction")]
		public override void _GestureRecognizers()
		{
		}

		// TODO
		public override void _IsFocused()
		{
		}

		// TODO
		public override void _UnFocus()
		{
		}

		// TODO
		// Implement control specific ui tests

		protected override void FixtureTeardown()
		{
			App.NavigateBack();
			base.FixtureTeardown();
		}
	}
}