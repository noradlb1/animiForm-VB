Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CSharp_悬浮球
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub labGIF_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles labGIF.MouseEnter
			labGIF.Image = My.Resources.鼠标滑过
		End Sub


		Private Sub labGIF_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles labGIF.MouseLeave
			labGIF.Image = My.Resources.正常状态
		End Sub


		Private startPoint As New Point()

		Private isDown As Boolean = False

		Private Sub labGIF_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles labGIF.MouseDown

			If e.Button <> MouseButtons.Left Then
				Return
			End If
			startPoint = e.Location
			isDown = True

		End Sub

		Private Sub labGIF_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles labGIF.MouseUp

			If e.Button <> MouseButtons.Left Then
				Return
			End If
			isDown = False
		End Sub

		Private Sub labGIF_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles labGIF.MouseMove
			If e.Button <> MouseButtons.Left OrElse Not isDown Then
				Return
			End If
			Me.Location = Me.PointToScreen(New Point(e.X - startPoint.X, e.Y - startPoint.Y))
		End Sub

		Private Sub 退出ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 退出ToolStripMenuItem.Click
			Me.Close()
		End Sub
	End Class
End Namespace
