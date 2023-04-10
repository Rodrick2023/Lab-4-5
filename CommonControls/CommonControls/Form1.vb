Imports System.IO

Public Class frmCommonControls
    Inherits System.Windows.Forms.Form
    Private filename As String
    Dim sr As StreamReader
    Dim sw As StreamWriter

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            With OpenFileDialog1
                .Filter = "Text files (*.txt) |*.txt|" & "All files|*.*"

                If .ShowDialog() = DialogResult.OK Then
                    filename = .FileName
                    sr = New StreamReader(.OpenFile)
                    rtbContents.Text = sr.ReadToEnd()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not (sr Is Nothing) Then
                sr.Close()
            End If
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        Try
            With SaveFileDialog1
                .FileName = filename
                .Filter = "Text files (*.txt) |*.txt|" & "All files|*.*"

                If .ShowDialog() = DialogResult.OK Then
                    filename = .FileName
                    sw = New StreamWriter(filename)
                    sw.Write(rtbContents.Text)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()
            End If
        End Try
    End Sub

    Private Sub SelectFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFontToolStripMenuItem.Click
        Try
            With FontDialog1
                .Font = rtbContents.Font

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    rtbContents.Font = .Font
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        Static CustomColors() As Integer = {RGB(255, 0, 0), RGB(0, 255, 0), RGB(0, 0, 255)}
        'initializing CustomColors with an array of integers and putting Red, Green, and Blue in the custom colors section
        Try
            With ColorDialog1
                .Color = rtbContents.ForeColor
                'initializing the selected color to match the color currently used by the richtextbox's foreground color

                .CustomColors = CustomColors
                'filling custom colors on the dialog box with the array declared above

                If .ShowDialog() = DialogResult.OK Then
                    rtbContents.ForeColor = .Color
                    CustomColors = .CustomColors
                    'Storing the custom colors to use again
                End If
                ColorDialog1.Reset()
                'resetting all colors in the dialog box
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmCommonControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
