using System;
using System.Linq;

using System.Maui.CustomAttributes;
using System.Maui.Internals;

namespace System.Maui.Controls.Issues
{
	[Preserve (AllMembers=true)]
	[Issue (IssueTracker.Github, 260, "Layout issue for TableView", PlatformAffected.WinPhone)]
	public class Issue260 : ContentPage
	{
		public Issue260 ()
		{
			var items = Enumerable.Range (0, 50).Select (i => new TextCell {
				Text = i.ToString (),
				Detail = i.ToString ()
			}).ToList ();

			var tableSection = new TableSection("First Section");
			foreach (TextCell cell in items) {
				tableSection.Add (cell);
			}

			var tableRoot = new TableRoot () {
				tableSection
			};

			var tableLayout = new TableView {
				Root = tableRoot
			};

			tableLayout.Intent = TableIntent.Data;
			Content = tableLayout;
		}
	}
}
