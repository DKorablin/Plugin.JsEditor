using System;
using System.IO;
using System.Windows.Forms;
using Plugin.JsEditor.Script;
using SAL.Windows;

namespace Plugin.JsEditor
{
	public partial class DocumentJsEditor : UserControl
	{
		private PluginWindows Plugin => (PluginWindows)this.Window.Plugin;

		private IWindow Window => (IWindow)base.Parent;

		public DocumentJsEditor()
		{
			this.InitializeComponent();
#if NETFRAMEWORK
			this.txtSource.Language = FastColoredTextBoxNS.Language.JS;
#else
			this.txtSource.Language = FastColoredTextBoxNS.Text.Language.JS;
#endif
		}

		protected override void OnCreateControl()
		{
			this.Window.Caption = "JavaScript Editor";

			base.OnCreateControl();
		}

		private void tsbnRun_Click(Object sender, EventArgs e)
		{
			lvErrors.Items.Clear();

			IJsHelper jsHelper = this.Plugin.Settings.GetEngine();

			foreach(ListViewItem item in lvReferences.Items)
				try
				{
					jsHelper.LoadExternalFile(item.Text);
				} catch(FileNotFoundException exc)
				{
					lvErrors.Items.Add(exc.Message);
				} catch(DirectoryNotFoundException exc)
				{
					lvErrors.Items.Add(exc.Message);
				}

			try
			{
				jsHelper.Eval(txtSource.Text);
			} catch(JsRuntimeException exc)
			{
				ListViewItem item = new ListViewItem(new String[] { exc.Location.ToString(), exc.Message, });
				lvErrors.Items.Add(item);
				lvErrors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}

			splitCode.Panel2Collapsed = lvErrors.Items.Count == 0;
		}

		private void lvErrors_MouseDoubleClick(Object sender, MouseEventArgs e)
		{
			if(lvErrors.SelectedItems.Count > 0)
			{//TODO: In JintHelper, after the main code, there is code from external files, so this possibility must be taken into account here.
				Int32 lineNumber = Int32.Parse(lvErrors.SelectedItems[0].SubItems[colErrorLine.Index].Text) - 1;
				txtSource.Selection = txtSource.GetLine(lineNumber);
				txtSource.DoSelectionVisible();
				txtSource.Invalidate();

			}
		}

		private void lvReferences_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.Delete:
			case Keys.Back:
				while(lvReferences.SelectedItems.Count > 0)
					lvReferences.SelectedItems[0].Remove();
				e.Handled = true;
				break;
			}
		}

		private void txtSource_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.A | Keys.Control:
				e.Handled = true;
				txtSource.SelectAll();
				break;
			}
		}

		private void txtSource_TextChanged(Object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
			=> tsbnRun.Enabled = !String.IsNullOrEmpty(txtSource.Text.Trim());

		private void cmsErrors_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem == tsmiErrorsClear)
			{
				lvErrors.Items.Clear();
				splitCode.Panel2Collapsed = true;
			} else
				throw new NotImplementedException();
		}

		private void splitCode_MouseDoubleClick(Object sender, MouseEventArgs e)
		{
			if(splitCode.SplitterRectangle.Contains(e.Location))
			{
				splitCode.Panel2Collapsed = true;
				txtSource.Focus();
			}
		}
	}
}