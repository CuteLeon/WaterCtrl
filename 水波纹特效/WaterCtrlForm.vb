Public Class WaterCtrlForm
    'setwaterparent(GetDesktopWindow)
    'Private Declare Function GetDesktopWindow Lib "user32" Alias "GetDesktopWindow" () As Integer
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    Private Declare Function SendMessageA Lib "user32" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer

    '半径和深度不超过 2147483315
    '开启水波纹特效
    Private Declare Function enablewater Lib "waterctrl.dll" (Handle As Integer, left As Integer, top As Integer, bitmapHandle As Integer, WaterRadius As Integer, WaterHeight As Integer) As Boolean
    '产生一个水波纹
    Private Declare Function waterblob Lib "waterctrl.dll" (x As Integer, y As Integer, radius As Integer, height As Integer) As Boolean
    '设置水波纹父容器句柄
    'Private Declare Function setwaterparent Lib "waterctrl.dll" (HWND As Integer) As Boolean
    '平复水波纹
    Private Declare Function flattenwater Lib "waterctrl.dll" () As Boolean
    '卸载水波纹特效
    Private Declare Function disablewater Lib "waterctrl.dll" () As Boolean

    Dim WaterBitmap As Bitmap

    Private Sub WaterCtrlForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '水波纹背景图像是垂直翻转的
        WaterBitmap = Me.BackgroundImage
        WaterBitmap = WaterBitmap.Clone(New Rectangle(ControlPanel.Width, 0, WaterBitmap.Width - ControlPanel.Width, Me.Height), Imaging.PixelFormat.Format32bppArgb)
        WaterBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY)
    End Sub

    Private Sub EnabledButton_Click(sender As Object, e As EventArgs) Handles EnabledButton.Click
        enablewater(Me.Handle, ControlPanel.Width, 0, WaterBitmap.GetHbitmap, RadiusNumeric.Value, HeightNumeric.Value)

        EnabledButton.Enabled = False
        FlattenButton.Enabled = True
        RandomButton.Enabled = True
        DisableButton.Enabled = True
    End Sub

    Private Sub RandomButton_Click(sender As Object, e As EventArgs) Handles RandomButton.Click
        waterblob(VBMath.Rnd() * 470, VBMath.Rnd * 320, RadiusNumeric.Value, HeightNumeric.Value)
    End Sub

    Private Sub FlattenButton_Click(sender As Object, e As EventArgs) Handles FlattenButton.Click
        flattenwater()
    End Sub

    Private Sub DisableButton_Click(sender As Object, e As EventArgs) Handles DisableButton.Click
        disablewater

        EnabledButton.Enabled = True
        FlattenButton.Enabled = False
        RandomButton.Enabled = False
        DisableButton.Enabled = False
    End Sub

    Private Sub MoveForm(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, ControlPanel.MouseDown
        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0&)
    End Sub

    Private Sub Numeric_ValueChanged(sender As Object, e As EventArgs) Handles RadiusNumeric.ValueChanged, HeightNumeric.ValueChanged
        If DisableButton.Enabled Then
            disablewater
            enablewater(Me.Handle, ControlPanel.Width, 0, WaterBitmap.GetHbitmap, RadiusNumeric.Value, HeightNumeric.Value)
        End If
    End Sub

End Class
