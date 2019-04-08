using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVM.ViewModels;

namespace XF.MVVM.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPersonPage : ContentPage
	{
		public AddPersonPage ()
		{
			InitializeComponent ();

            BindingContext = new AddPersonPageViewModel();
		}
	}
}