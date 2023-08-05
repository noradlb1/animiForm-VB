Namespace CSharp_悬浮球
	Partial Public Class Form1
		''' <summary>
		''' 必需的设计器变量。
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' 清理所有正在使用的资源。
		''' </summary>
		''' <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows 窗体设计器生成的代码"

		''' <summary>
		''' 设计器支持所需的方法 - 不要修改
		''' 使用代码编辑器修改此方法的内容。
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.labGIF = New System.Windows.Forms.Label()
            Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.contextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'labGIF
            '
            Me.labGIF.ContextMenuStrip = Me.contextMenuStrip1
            Me.labGIF.Image = Global.My.Resources.Resources.正常状态
            Me.labGIF.Location = New System.Drawing.Point(0, 0)
            Me.labGIF.Name = "labGIF"
            Me.labGIF.Size = New System.Drawing.Size(90, 130)
            Me.labGIF.TabIndex = 0
            '
            'contextMenuStrip1
            '
            Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出ToolStripMenuItem})
            Me.contextMenuStrip1.Name = "contextMenuStrip1"
            Me.contextMenuStrip1.Size = New System.Drawing.Size(181, 48)
            '
            '退出ToolStripMenuItem
            '
            Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
            Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
            Me.退出ToolStripMenuItem.Text = "Exit"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.ClientSize = New System.Drawing.Size(92, 130)
            Me.ControlBox = False
            Me.Controls.Add(Me.labGIF)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Form1"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            Me.TopMost = True
            Me.TransparencyKey = System.Drawing.SystemColors.Control
            Me.contextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents labGIF As System.Windows.Forms.Label
		Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
		Private WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

