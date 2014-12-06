namespace OPCDemo
{
    partial class ProjectsModule
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
            if (disposing && (components != null))
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
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.Empty.Options.UseBackColor = true;
            this.treeList.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.treeList.Appearance.FocusedRow.Options.UseFont = true;
            this.treeList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.treeList.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.treeList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeList.Appearance.HideSelectionRow.Options.UseFont = true;
            this.treeList.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.Row.Options.UseBackColor = true;
            this.treeList.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.treeList.Appearance.SelectedRow.Options.UseFont = true;
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.BeginUnboundLoad();
            this.treeList.AppendNode(new object[] {
            "OPC"}, -1);
            this.treeList.AppendNode(new object[] {
            "Dashboards (2)"}, 0);
            this.treeList.AppendNode(new object[] {
            "Today"}, 0);
            this.treeList.AppendNode(new object[] {
            "Projects (200)"}, 0);
            this.treeList.AppendNode(new object[] {
            "Projects Sales (100)"}, 3);
            this.treeList.AppendNode(new object[] {
            "Tasks"}, 0);
            this.treeList.AppendNode(new object[] {
            "Open (2000)"}, 5);
            this.treeList.AppendNode(new object[] {
            "Ivan (1000)"}, 5);
            this.treeList.AppendNode(new object[] {
            "Emails"}, 0);
            this.treeList.AppendNode(new object[] {
            "Not Read (40)"}, 8);
            this.treeList.AppendNode(new object[] {
            "Related to Projects (1000)"}, 8);
            this.treeList.AppendNode(new object[] {
            "Calendar"}, 0);
            this.treeList.AppendNode(new object[] {
            "My Calendar"}, 11);
            this.treeList.AppendNode(new object[] {
            "Vacation / Holiday"}, 11);
            this.treeList.AppendNode(new object[] {
            "People"}, 0);
            this.treeList.AppendNode(new object[] {
            "Customers"}, 14);
            this.treeList.AppendNode(new object[] {
            "Reports"}, 0);
            this.treeList.AppendNode(new object[] {
            "By Project"}, 16);
            this.treeList.AppendNode(new object[] {
            "History"}, 0);
            this.treeList.AppendNode(new object[] {
            "Options"}, 0);
            this.treeList.EndUnboundLoad();
            this.treeList.OptionsBehavior.DragNodes = true;
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList.OptionsView.ShowColumns = false;
            this.treeList.OptionsView.ShowFocusedFrame = false;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.Size = new System.Drawing.Size(218, 576);
            this.treeList.TabIndex = 1;
            this.treeList.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList_AfterFocusNode);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "treeListColumn2";
            this.treeListColumn2.MinWidth = 70;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 576);
            this.panel1.TabIndex = 2;
            // 
            // ProjectsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeList);
            this.Name = "ProjectsModule";
            this.Size = new System.Drawing.Size(783, 576);
            this.Load += new System.EventHandler(this.ProjectsModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.Panel panel1;
    }
}
