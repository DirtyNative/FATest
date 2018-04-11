using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FATestApp
{
	public partial class MainPage : ContentPage
	{
	    public string FaIcon { get; set; } = "\uf018";
        
        public MainPage()
		{
			InitializeComponent();

		    this.BindingContext = this;
		}
	}
}
