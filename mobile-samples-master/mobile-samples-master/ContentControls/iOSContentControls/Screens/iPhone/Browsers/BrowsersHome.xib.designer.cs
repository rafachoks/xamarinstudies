// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_ContentControls.Screens.iPhone.Browsers {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[Foundation.Register("BrowsersHome")]
	public partial class BrowsersHome {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIButton __mt_btnLocalBrowser;
		
		private UIKit.UIButton __mt_btnWebBrowser;
		
		private UIKit.UIButton __mt_btnInteractivity;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("btnLocalBrowser")]
		private UIKit.UIButton btnLocalBrowser {
			get {
				this.__mt_btnLocalBrowser = ((UIKit.UIButton)(this.GetNativeField("btnLocalBrowser")));
				return this.__mt_btnLocalBrowser;
			}
			set {
				this.__mt_btnLocalBrowser = value;
				this.SetNativeField("btnLocalBrowser", value);
			}
		}
		
		[Foundation.Connect("btnWebBrowser")]
		private UIKit.UIButton btnWebBrowser {
			get {
				this.__mt_btnWebBrowser = ((UIKit.UIButton)(this.GetNativeField("btnWebBrowser")));
				return this.__mt_btnWebBrowser;
			}
			set {
				this.__mt_btnWebBrowser = value;
				this.SetNativeField("btnWebBrowser", value);
			}
		}
		
		[Foundation.Connect("btnInteractivity")]
		private UIKit.UIButton btnInteractivity {
			get {
				this.__mt_btnInteractivity = ((UIKit.UIButton)(this.GetNativeField("btnInteractivity")));
				return this.__mt_btnInteractivity;
			}
			set {
				this.__mt_btnInteractivity = value;
				this.SetNativeField("btnInteractivity", value);
			}
		}
	}
}