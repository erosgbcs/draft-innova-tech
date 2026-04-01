Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms

Public Class UIControls

End Class

''' <summary>
''' Custom Button with rounded corners and hover effects.
''' </summary>
Public Class RoundedButton
    Inherits Button

    Public Property CornerRadius As Integer = 12
    Private normalColor As Color = Color.FromArgb(0, 120, 215)
    Private hoverColor As Color = Color.FromArgb(0, 150, 255)
    Private currentColor As Color = Color.FromArgb(0, 120, 215)

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.ForeColor = Color.White
        Me.Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        Using path As GraphicsPath = GetRoundedRect(rect, CornerRadius)
            Using brush As New SolidBrush(currentColor)
                pevent.Graphics.FillPath(brush, path)
            End Using
        End Using

        ' Center the text
        TextRenderer.DrawText(pevent.Graphics, Me.Text, Me.Font, rect, Me.ForeColor,
                              TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        ' Ensure radius isn't larger than the button height/width
        Dim d As Integer = radius * 2
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        currentColor = hoverColor
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        currentColor = normalColor
        Me.Invalidate()
    End Sub
End Class

''' <summary>
''' Custom Panel with rounded corners, a border, and an animated drop shadow.
''' </summary>
Public Class RoundedShadowPanel
    Inherits Panel

    Public Property CornerRadius As Integer = 20
    Public Property ShadowSize As Integer = 5
    Public Property BorderColor As Color = Color.Gray

    Private normalShadowAlpha As Integer = 50
    Private hoverShadowAlpha As Integer = 120
    Private currentShadowAlpha As Integer = 50
    Private fadeTimer As Timer
    Private targetAlpha As Integer

    Public Sub New()
        Me.DoubleBuffered = True
        fadeTimer = New Timer()
        fadeTimer.Interval = 15
        AddHandler fadeTimer.Tick, AddressOf FadeStep
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Draw Shadow
        Dim shadowRect As New Rectangle(ShadowSize, ShadowSize, Me.Width - ShadowSize, Me.Height - ShadowSize)
        Using shadowPath As GraphicsPath = GetRoundedRect(shadowRect, CornerRadius)
            Using shadowBrush As New SolidBrush(Color.FromArgb(currentShadowAlpha, Color.Black))
                g.FillPath(shadowBrush, shadowPath)
            End Using
        End Using

        ' Draw Main Panel Body
        Dim rect As New Rectangle(0, 0, Me.Width - ShadowSize, Me.Height - ShadowSize)
        Using path As GraphicsPath = GetRoundedRect(rect, CornerRadius)
            Using brush As New SolidBrush(Me.BackColor)
                g.FillPath(brush, path)
            End Using
            ' Draw Border
            Using pen As New Pen(Me.BorderColor, 1)
                g.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Integer = radius * 2
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        targetAlpha = hoverShadowAlpha
        fadeTimer.Start()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        targetAlpha = normalShadowAlpha
        fadeTimer.Start()
    End Sub

    Private Sub FadeStep(sender As Object, e As EventArgs)
        If currentShadowAlpha < targetAlpha Then
            currentShadowAlpha += 5
            If currentShadowAlpha >= targetAlpha Then
                currentShadowAlpha = targetAlpha
                fadeTimer.Stop()
            End If
        ElseIf currentShadowAlpha > targetAlpha Then
            currentShadowAlpha -= 5
            If currentShadowAlpha <= targetAlpha Then
                currentShadowAlpha = targetAlpha
                fadeTimer.Stop()
            End If
        End If
        Me.Invalidate()
    End Sub
End Class