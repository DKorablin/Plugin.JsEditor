namespace Plugin.JsEditor
{
	partial class DocumentJsEditor
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStrip tsMain;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentJsEditor));
			System.Windows.Forms.SplitContainer splitMain;
			this.tsbnRun = new System.Windows.Forms.ToolStripButton();
			this.lvReferences = new System.Windows.Forms.ListView();
			this.colReferencePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitCode = new System.Windows.Forms.SplitContainer();
			this.txtSource = new FastColoredTextBoxNS.FastColoredTextBox();
			this.lvErrors = new System.Windows.Forms.ListView();
			this.colErrorDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsErrors = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiErrorsClear = new System.Windows.Forms.ToolStripMenuItem();
			this.colErrorLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			tsMain = new System.Windows.Forms.ToolStrip();
			splitMain = new System.Windows.Forms.SplitContainer();
			tsMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(splitMain)).BeginInit();
			splitMain.Panel1.SuspendLayout();
			splitMain.Panel2.SuspendLayout();
			splitMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitCode)).BeginInit();
			this.splitCode.Panel1.SuspendLayout();
			this.splitCode.Panel2.SuspendLayout();
			this.splitCode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSource)).BeginInit();
			this.cmsErrors.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMain
			// 
			tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnRun});
			tsMain.Location = new System.Drawing.Point(0, 0);
			tsMain.Name = "tsMain";
			tsMain.Size = new System.Drawing.Size(200, 25);
			tsMain.TabIndex = 0;
			tsMain.Text = "toolStrip1";
			// 
			// tsbnRun
			// 
			this.tsbnRun.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnRun.Image = ((System.Drawing.Image)(resources.GetObject("tsbnRun.Image")));
			this.tsbnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnRun.Name = "tsbnRun";
			this.tsbnRun.Size = new System.Drawing.Size(23, 22);
			this.tsbnRun.Text = "Run";
			this.tsbnRun.Click += new System.EventHandler(this.tsbnRun_Click);
			// 
			// splitMain
			// 
			splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			splitMain.Location = new System.Drawing.Point(0, 25);
			splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			splitMain.Panel1.Controls.Add(this.lvReferences);
			// 
			// splitMain.Panel2
			// 
			splitMain.Panel2.Controls.Add(this.splitCode);
			splitMain.Size = new System.Drawing.Size(200, 175);
			splitMain.SplitterDistance = 66;
			splitMain.TabIndex = 1;
			// 
			// lvReferences
			// 
			this.lvReferences.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReferencePath});
			this.lvReferences.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvReferences.FullRowSelect = true;
			this.lvReferences.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvReferences.HideSelection = false;
			this.lvReferences.Location = new System.Drawing.Point(0, 0);
			this.lvReferences.Name = "lvReferences";
			this.lvReferences.Size = new System.Drawing.Size(66, 175);
			this.lvReferences.TabIndex = 0;
			this.lvReferences.UseCompatibleStateImageBehavior = false;
			this.lvReferences.View = System.Windows.Forms.View.Details;
			this.lvReferences.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvReferences_KeyDown);
			// 
			// splitCode
			// 
			this.splitCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitCode.Location = new System.Drawing.Point(0, 0);
			this.splitCode.Name = "splitCode";
			this.splitCode.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitCode.Panel1
			// 
			this.splitCode.Panel1.Controls.Add(this.txtSource);
			// 
			// splitCode.Panel2
			// 
			this.splitCode.Panel2.Controls.Add(this.lvErrors);
			this.splitCode.Panel2Collapsed = true;
			this.splitCode.Size = new System.Drawing.Size(130, 175);
			this.splitCode.SplitterDistance = 84;
			this.splitCode.TabIndex = 0;
			this.splitCode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitCode_MouseDoubleClick);
			// 
			// txtSource
			// 
			this.txtSource.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.txtSource.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
			this.txtSource.AutoScrollMinSize = new System.Drawing.Size(42, 15);
			this.txtSource.BackBrush = null;
			this.txtSource.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.txtSource.CharHeight = 15;
			this.txtSource.CharWidth = 7;
			this.txtSource.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSource.DelayedEventsInterval = 500;
			this.txtSource.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSource.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.txtSource.IsReplaceMode = false;
			this.txtSource.Language = FastColoredTextBoxNS.Language.JS;
			this.txtSource.LeftBracket = '(';
			this.txtSource.LeftBracket2 = '{';
			this.txtSource.LeftPadding = 17;
			this.txtSource.Location = new System.Drawing.Point(0, 0);
			this.txtSource.Name = "txtSource";
			this.txtSource.Paddings = new System.Windows.Forms.Padding(0);
			this.txtSource.RightBracket = ')';
			this.txtSource.RightBracket2 = '}';
			this.txtSource.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.txtSource.Size = new System.Drawing.Size(130, 175);
			this.txtSource.TabIndex = 1;
			this.txtSource.Zoom = 100;
			this.txtSource.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txtSource_TextChanged);
			this.txtSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSource_KeyDown);
			// 
			// lvErrors
			// 
			this.lvErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colErrorLine,
            this.colErrorDescription});
			this.lvErrors.ContextMenuStrip = this.cmsErrors;
			this.lvErrors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvErrors.FullRowSelect = true;
			this.lvErrors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvErrors.Location = new System.Drawing.Point(0, 0);
			this.lvErrors.Name = "lvErrors";
			this.lvErrors.Size = new System.Drawing.Size(150, 46);
			this.lvErrors.TabIndex = 0;
			this.lvErrors.UseCompatibleStateImageBehavior = false;
			this.lvErrors.View = System.Windows.Forms.View.Details;
			this.lvErrors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvErrors_MouseDoubleClick);
			// 
			// cmsErrors
			// 
			this.cmsErrors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiErrorsClear});
			this.cmsErrors.Name = "cmsErrors";
			this.cmsErrors.Size = new System.Drawing.Size(102, 26);
			this.cmsErrors.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsErrors_ItemClicked);
			// 
			// tsmiErrorsClear
			// 
			this.tsmiErrorsClear.Name = "tsmiErrorsClear";
			this.tsmiErrorsClear.Size = new System.Drawing.Size(101, 22);
			this.tsmiErrorsClear.Text = "&Clear";
			// 
			// colErrorLine
			// 
			this.colErrorLine.DisplayIndex = 0;
			this.colErrorLine.Text = "Line";
			this.colErrorLine.Width = 94;
			// 
			// colErrorDescription
			// 
			this.colErrorDescription.DisplayIndex = 1;
			this.colErrorDescription.Text = "Description";
			// 
			// DocumentJsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(splitMain);
			this.Controls.Add(tsMain);
			this.Name = "DocumentJsEditor";
			this.Size = new System.Drawing.Size(200, 200);
			tsMain.ResumeLayout(false);
			tsMain.PerformLayout();
			splitMain.Panel1.ResumeLayout(false);
			splitMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(splitMain)).EndInit();
			splitMain.ResumeLayout(false);
			this.splitCode.Panel1.ResumeLayout(false);
			this.splitCode.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitCode)).EndInit();
			this.splitCode.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSource)).EndInit();
			this.cmsErrors.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitCode;
		private System.Windows.Forms.ListView lvErrors;
		private System.Windows.Forms.ColumnHeader colErrorDescription;
		private FastColoredTextBoxNS.FastColoredTextBox txtSource;
		private System.Windows.Forms.ListView lvReferences;
		private System.Windows.Forms.ColumnHeader colReferencePath;
		private System.Windows.Forms.ToolStripButton tsbnRun;
		private System.Windows.Forms.ContextMenuStrip cmsErrors;
		private System.Windows.Forms.ToolStripMenuItem tsmiErrorsClear;
		private System.Windows.Forms.ColumnHeader colErrorLine;

	}
}
