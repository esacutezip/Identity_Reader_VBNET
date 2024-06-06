Imports System.IO
Imports System.Text.RegularExpressions
Public Class Form1

    Private Property Input As Object

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'TextBox1.Text = Shell("adb devices", AppWinStyle.NormalFocus)
        'Dim ps As New ProcessStartInfo("cmd.exe")
        'ps.Arguments = "ambil.bat"
        'Process.Start(ps)
        System.Diagnostics.Process.Start("delete.bat", AppWinStyle.Hide)


        PictureBox1.Image = Image.FromFile("null.png")
        PictureBox2.Image = Image.FromFile("null.png")

        System.Diagnostics.Process.Start("ambil.bat", AppWinStyle.Hide)
        Me.Button1.Enabled = False
        Me.Button2.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        
        'Dim p As New System.Diagnostics.Process()
        'p.StartInfo.FileName = "C:\\aplikasi2\2\AplikasiEKTP\AplikasiEKTP\bin\ambil.bat"
        'p.Start()
    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Button1.Enabled = True
        Me.Button2.Enabled = False


        Dim FILE_NAME3 As String = "image.jpg"
        Dim FILE_NAME2 As String = "signature.jpg"
        Dim FILE_NAME As String = "biodata.csv"
        Dim FILE_NAME4 As String = "reading_ektp.log"
        Dim FILE_NAME5 As String = "riwayat_transaksi.log"

        If System.IO.File.Exists(FILE_NAME3) = True Then
            Dim fs As System.IO.FileStream
            ' Specify a valid picture file path on your computer.
            fs = New System.IO.FileStream("image.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            PictureBox1.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If

        If System.IO.File.Exists(FILE_NAME2) = True Then
            Dim fs1 As System.IO.FileStream
            ' Specify a valid picture file path on your computer.
            fs1 = New System.IO.FileStream("signature.jpg",
                 IO.FileMode.Open, IO.FileAccess.Read)
            PictureBox2.Image = System.Drawing.Image.FromStream(fs1)
            fs1.Close()
        End If

        If System.IO.File.Exists(FILE_NAME4) = True Then
            Dim objReader9 As New System.IO.StreamReader(FILE_NAME4)

            TextBox5.Text = objReader9.ReadToEnd
            Dim value As String = objReader9.ReadToEnd
            objReader9.Close()
        End If

        If System.IO.File.Exists(FILE_NAME5) = True Then
            Dim objReader8 As New System.IO.StreamReader(FILE_NAME5)

            TextBox6.Text = objReader8.ReadToEnd
            Dim value As String = objReader8.ReadToEnd
            objReader8.Close()
        End If

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            'Dim objReader2 As New System.IO.StreamReader(FILE_NAME)

            'TextBox1.Text = objReader.ReadToEnd
            Dim value As String = objReader.ReadToEnd
            'Dim sa As String = objReader.ReadToEnd
            'Dim inputs() As String = {"1 May 1917", "June 16 2003"}
            'Dim pattern As String = "(?<=\d{1,2}\s)\w+,?\s\d{4}"
            'Dim sa As String = "('BH','BAHRAIN','Bahrain','BHR','048')"
            'Dim pattern As String = ".*?" & ".*?"
            Dim pattern As String = "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\""" & ".*?" &
                                    "\""(.*?)\"""
            ' Dim pattern As String = "(?>(\w)\1+).\b" & "(\w)\1+.\b"
            'TextBox3.Text = objReader2.ReadToEnd

            Dim col As MatchCollection = Regex.Matches(value, pattern, RegexOptions.RightToLeft)

            For Each input As Match In col
                'objReader.ReadToEnd()
                Dim a As Group = input.Groups(16)
                TextBox1.Text = a.Value
                Dim b As Group = input.Groups(8)
                If (b.Value.ToString.IndexOf("KOTA")) Then
                    TextBox2.Text = "KABUPATEN " & b.Value
                Else
                    TextBox2.Text = b.Value
                End If

                Dim c As Group = input.Groups(1)
                TextBox3.Text = c.Value
                Dim d As Group = input.Groups(14)
                TextBox4.Text = d.Value
                Dim f As Group = input.Groups(5)
                TextBox7.Text = f.Value
                Dim g As Group = input.Groups(9)
                TextBox8.Text = g.Value
                Dim h As Group = input.Groups(2)
                TextBox9.Text = h.Value
                Dim i As Group = input.Groups(3)
                TextBox10.Text = i.Value
                Dim j As Group = input.Groups(7)
                TextBox11.Text = j.Value
                Dim k As Group = input.Groups(6)
                TextBox12.Text = k.Value
                Dim l As Group = input.Groups(11)
                TextBox13.Text = l.Value
                Dim m As Group = input.Groups(12)
                TextBox14.Text = m.Value
                Dim n As Group = input.Groups(13)
                TextBox15.Text = n.Value
                Dim o As Group = input.Groups(4)
                TextBox16.Text = o.Value
                Dim p As Group = input.Groups(15)
                TextBox17.Text = p.Value
                Dim q As Group = input.Groups(10)
                TextBox18.Text = q.Value
                Dim r As Group = input.Groups(17)
                TextBox19.Text = r.Value
                Dim s As Group = input.Groups(20)
                TextBox20.Text = s.Value

                objReader.Close()

            Next

            objReader.Close()
        Else

            MsgBox("File Does Not Exist")

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





        PictureBox1.Image = Image.FromFile("null.png")
        PictureBox2.Image = Image.FromFile("null.png")
        Me.Button1.Enabled = True
        Me.Button2.Enabled = False

    End Sub

   
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Function pattern() As String
        Throw New NotImplementedException
    End Function

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim procstart As New ProcessStartInfo("explorer")
        Dim winDir As String = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory) + "\Debug"
        procstart.Arguments = winDir
        Process.Start(procstart)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("reboot.bat", AppWinStyle.Hide)
    End Sub

   
   

    
End Class
