<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCricket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As TreeNode = New TreeNode("1.1")
        Dim TreeNode2 As TreeNode = New TreeNode("1", New TreeNode() {TreeNode1})
        Dim TreeNode3 As TreeNode = New TreeNode("2")
        Dim TreeNode4 As TreeNode = New TreeNode("3")
        Dim TreeNode5 As TreeNode = New TreeNode("4")
        Dim TreeNode6 As TreeNode = New TreeNode("5")
        Dim TreeNode7 As TreeNode = New TreeNode("Numbers", New TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        TreeView1 = New TreeView()
        txtPath = New TextBox()
        btnShow = New Button()
        ProgressBar1 = New ProgressBar()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Panel1 = New Panel()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(243, 81)
        TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node11"
        TreeNode1.Text = "1.1"
        TreeNode2.Name = "Node6"
        TreeNode2.Text = "1"
        TreeNode3.Name = "Node7"
        TreeNode3.Text = "2"
        TreeNode4.Name = "Node8"
        TreeNode4.Text = "3"
        TreeNode5.Name = "Node9"
        TreeNode5.Text = "4"
        TreeNode6.Name = "Node10"
        TreeNode6.Text = "5"
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "Numbers"
        TreeView1.Nodes.AddRange(New TreeNode() {TreeNode7})
        TreeView1.Size = New Size(311, 251)
        TreeView1.TabIndex = 0
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(243, 39)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(311, 23)
        txtPath.TabIndex = 1
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(570, 39)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 2
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(300, 356)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(207, 23)
        ProgressBar1.TabIndex = 3
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 39)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(200, 100)
        TabControl1.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(192, 72)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(192, 72)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Location = New Point(8, 155)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 5
        ' 
        ' frmCricket
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Controls.Add(ProgressBar1)
        Controls.Add(btnShow)
        Controls.Add(txtPath)
        Controls.Add(TreeView1)
        Name = "frmCricket"
        Text = "Cricket Information"
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
End Class
