Imports Microsoft.VisualBasic.CompilerServices
Imports System.Collections.Concurrent
Imports System.IO
Imports System.Net
Imports System.Net.Cache
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Form1
    Private bool_0 As Boolean
    Public concurrentQueue_0 As ConcurrentQueue(Of String)
    Private int_1 As Integer
    Private int_2 As Integer
    Private int_3 As Integer
    Private list_1 As List(Of Class9)
    Private list_2 As List(Of Thread)
    Private string_0 As String

    Public Sub New()
        Me.concurrentQueue_0 = New ConcurrentQueue(Of String)
        Me.list_1 = New List(Of Class9)
        Me.list_2 = New List(Of Thread)
        Me.int_1 = 5
        Me.int_2 = &H1388
        Me.int_3 = 0
        Me.string_0 = Nothing
        Me.bool_0 = True
        Me.InitializeComponent()
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Add.Showdialog()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim path As String = Nothing
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.ShowDialog()
        path = Me.OpenFileDialog1.FileName
        If (path <> Nothing) Then
            Dim str2 As String = File.ReadAllText(path)
            Me.method_0(str2)
            Me.MetroButton2.Enabled = True
            Me.MetroButton5.Enabled = True
        End If
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Dim builder As New StringBuilder
        Dim path As String = Nothing
        Me.SaveFileDialog1.FileName = ""
        Me.SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        Me.SaveFileDialog1.ShowDialog()
        path = Me.SaveFileDialog1.FileName
        If (path <> Nothing) Then
            Dim num2 As Integer
            Select Case path.Substring((path.LastIndexOf(".") + 1)).ToLower
                Case "m3u8"
                    Dim num As Integer = (Me.MetroGrid1.Rows.Count - 1)
                    num2 = 0
                    Do While (num2 <= num)
                        Application.DoEvents()
                        Dim str4 As String = Conversions.ToString(Me.MetroGrid1.Rows.Item(num2).Cells.Item(2).Value)
                        builder.AppendLine(("#EXTINF:-1," & Conversions.ToString(Me.MetroGrid1.Rows.Item(num2).Cells.Item(0).Value)))
                        builder.AppendLine(str4)
                        builder.AppendLine()
                        num2 += 1
                    Loop
                    File.WriteAllText(path, builder.ToString.Trim)
                    Exit Select
                Case "cfg"
                    Dim num4 As Integer = (Me.MetroGrid1.Rows.Count - 1)
                    num2 = 0
                    Do While (num2 <= num4)
                        Application.DoEvents()
                        builder.AppendLine(("I: " & Conversions.ToString(Me.MetroGrid1.Rows.Item(num2).Cells.Item(2).Value) & " " & Conversions.ToString(Me.MetroGrid1.Rows.Item(num2).Cells.Item(0).Value)))
                        num2 += 1
                    Loop
                    File.WriteAllText(path, builder.ToString.Trim)
                    Exit Select
            End Select
            MsgBox(("File Successfully saved to " & path), MsgBoxStyle.Information, Nothing)
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim num2 As Integer
        Me.MetroButton2.Enabled = False
        Me.MetroButton5.Enabled = False
        Me.MetroButton1.Enabled = False
        Me.MetroButton6.Enabled = False
        Me.MetroPanel4.Enabled = False
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown2.Enabled = False
        Me.MetroButton3.Enabled = True
        Me.concurrentQueue_0 = New ConcurrentQueue(Of String)
        Dim num As Integer = (Me.MetroGrid1.Rows.Count - 1)
        num2 = 0
        Do While (num2 <= num)
            Application.DoEvents()
            Me.concurrentQueue_0.Enqueue(Conversions.ToString(Me.MetroGrid1.Rows.Item(num2).Cells.Item(2).Value))
            num2 += 1
        Loop
        Dim num4 As Integer = Me.concurrentQueue_0.Count
        Me.MetroProgressBar1.Maximum = num4
        Dim num5 As Integer = Me.int_1
        num2 = 1
        Do While (num2 <= num5)
            Application.DoEvents()
            Dim item As New Thread(New ThreadStart(AddressOf Me.method_7))
            Me.list_2.Add(item)
            item.Start()
            Thread.Sleep(50)
            num2 += 1
        Loop
        Do While (Me.list_2.Count <> 0)
            Application.DoEvents()
            Me.MetroProgressBar1.Value = ((num4 - Me.concurrentQueue_0.Count) - Me.list_2.Count)
        Loop
        Me.MetroPanel4.Enabled = True
        Me.Label1.Text = ("Channels Found: " & Conversions.ToString(Me.MetroGrid1.Rows.Count))
        Me.MetroButton2.Enabled = True
        Me.MetroButton5.Enabled = True
        Me.MetroButton6.Enabled = True
        Me.MetroButton1.Enabled = True
        Me.MetroPanel4.Enabled = True
        Me.MetroButton3.Enabled = False
        Me.NumericUpDown1.Enabled = True
        Me.NumericUpDown2.Enabled = True
        MsgBox("Finished Checking Links", MsgBoxStyle.Information, Nothing)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Me.list_1.Clear()
        Me.MetroGrid1.Rows.Clear()
        Me.MetroPanel4.Enabled = False
        Me.MetroButton2.Enabled = False
        Me.MetroButton5.Enabled = False
        Me.Label1.Text = ("Channels Found: " & Conversions.ToString(Me.MetroGrid1.Rows.Count))
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim num As Integer = (Me.concurrentQueue_0.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Application.DoEvents()

            Try
                Dim str As String = Nothing
                Me.concurrentQueue_0.TryDequeue(str)
            Catch exception1 As Exception
            End Try
            i += 1
        Loop
    End Sub

    Private Sub CopyURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyURLToolStripMenuItem.Click
        Dim text As String = Nothing
        Dim num2 As Integer = (Me.MetroGrid1.SelectedRows.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            Application.DoEvents()
            [text] = Conversions.ToString(Operators.ConcatenateObject(([text] & ChrW(13) & ChrW(10)), Me.MetroGrid1.SelectedRows.Item(i).Cells.Item(2).Value))
            i += 1
        Loop
        [text] = [text].Trim
        My.Computer.Clipboard.SetText([text])
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ServicePointManager.DefaultConnectionLimit = 200
        Me.method_11()
    End Sub
    Private Shared Function smethod_1(ByVal class9_0 As Class9) As Class9
        Dim class3 As New Class9
        class3.name = class9_0.name
        class3.status = class9_0.status
        class3.url = class9_0.url
        Return class3
    End Function
    Private Shared Function smethod_2(ByVal class9_0 As Class9) As Class9
        Dim class3 As New Class9
        class3.name = class9_0.name
        class3.status = class9_0.status
        class3.url = class9_0.url
        Return class3
    End Function
    Public Sub method_0(string_3 As String)
        If string_3.Contains("#EXTINF") Then
            Dim regex As Regex = New Regex("EXTINF.*?(rtp|rtsp|rtmp|http|https):\/\/(\w+:{0,1}\w*@)?(\S+)(:[0-9]+)?(\/|\/([\w#!:.?+=&%@!\-\/]))?", RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            Dim matchCollection As MatchCollection = regex.Matches(string_3)
            Dim arg_2F_0 As Integer = 0
            Dim num As Integer = matchCollection.Count - 1
            Dim num2 As Integer = arg_2F_0
            While True
                Dim arg_161_0 As Integer = num2
                Dim num3 As Integer = num
                If arg_161_0 > num3 Then
                    Exit While
                End If
                Dim [class] As Form1.Class7 = New Form1.Class7([class])
                Application.DoEvents()
                Dim value As String = matchCollection(num2).Value
                [class].class9_0 = New Class9()
                [class].class9_0.name = Regex.Match(value, ",.*").Value.Replace(",", "").Trim()
                [class].class9_0.status = "Waiting"
                [class].class9_0.url = Regex.Match(value, "(rtp|rtsp|rtmp|http|https):\/\/(\w+:{0,1}\w*@)?(\S+)(:[0-9]+)?(\/|\/([\w#!:.?+=&%@!\-\/]))?").Value.Trim()
                Dim list As List(Of Class9) = Me.list_1.Where(AddressOf [class].method_0).[Select](AddressOf Form1.smethod_1).ToList()
                If list.Count = 0 Then
                    Me.list_1.Add([class].class9_0)
                    Me.method_1([class].class9_0)
                Else
                    Me.int_3 += 1
                End If
                Me.Label1.Text = "Channels Found: " + Conversions.ToString(Me.MetroGrid1.Rows.Count)
                num2 += 1
            End While
        Else
            Dim regex2 As Regex = New Regex("(rtp|rtsp|rtmp|http|https):\/\/(\w+:{0,1}\w*@)?(\S+)(:[0-9]+)?(\/|\/([\w#!:.?+=&%@!\-\/]))?")
            Dim matchCollection2 As MatchCollection = regex2.Matches(string_3)
            Dim arg_18D_0 As Integer = 0
            Dim num4 As Integer = matchCollection2.Count - 1
            Dim num5 As Integer = arg_18D_0
            While True
                Dim arg_2A7_0 As Integer = num5
                Dim num3 As Integer = num4
                If arg_2A7_0 > num3 Then
                    Exit While
                End If
                Dim class2 As Form1.Class8 = New Form1.Class8(class2)
                Application.DoEvents()
                Dim url As String = matchCollection2(num5).Value.Trim()
                Dim name As String = "Unknown " + Conversions.ToString(num5)
                class2.class9_0 = New Class9()
                class2.class9_0.name = name
                class2.class9_0.url = url
                class2.class9_0.status = "Waiting"
                Dim list2 As List(Of Class9) = Me.list_1.Where(AddressOf class2.method_0).[Select](AddressOf Form1.smethod_2).ToList()
                If list2.Count = 0 Then
                    Me.list_1.Add(class2.class9_0)
                    Me.method_1(class2.class9_0)
                Else
                    Me.int_3 += 1
                End If
                Me.Label1.Text = "Channels Found: " + Conversions.ToString(Me.MetroGrid1.Rows.Count)
                num5 += 1
            End While
        End If
        If Me.int_3 > 0 Then
            Interaction.MsgBox("File has been loaded successfully, " + Conversions.ToString(Me.int_3) + " duplicates files have been removed.", MsgBoxStyle.Information, Nothing)
            Me.int_3 = 0
        Else
            Interaction.MsgBox("File has been loaded successfully.", MsgBoxStyle.Information, Nothing)
        End If
    End Sub
    Private Sub method_1(ByVal class9_0 As Class9)
        Dim strArray As String() = New String(4 - 1) {}
        strArray(0) = class9_0.name
        strArray(1) = class9_0.status
        strArray(2) = class9_0.url
        Dim dataGridViewRow As New DataGridViewRow
        dataGridViewRow.CreateCells(Me.MetroGrid1)
        dataGridViewRow.Cells.Item(0).Value = class9_0.name
        dataGridViewRow.Cells.Item(1).Value = class9_0.status
        dataGridViewRow.Cells.Item(2).Value = class9_0.url
        If (class9_0.status = "Online") Then
            dataGridViewRow.DefaultCellStyle.BackColor = Color.GreenYellow
        End If
        If (class9_0.status = "Offline") Then
            dataGridViewRow.DefaultCellStyle.BackColor = Color.Red
        End If
        Me.MetroGrid1.Rows.Add(dataGridViewRow)
    End Sub

    Private Sub MetroGrid1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MetroGrid1.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            Me.MetroGrid1.Rows.Item(e.RowIndex).Cells.Item(0).Selected = True
        End If
    End Sub
    Private Sub method_11()
        Dim path As String = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"
        If File.Exists(path) Then
            Me.string_0 = path
        End If
    End Sub
    Private Sub method_2(ByVal string_3 As String, ByVal string_4 As String)
        Dim num2 As Integer
        Dim num As Integer = (Me.MetroGrid1.Rows.Count - 1)
        num2 = 0
        Do While (num2 <= num)
            Application.DoEvents()

            If Operators.ConditionalCompareObjectEqual(Me.MetroGrid1.Rows.Item(num2).Cells.Item(2).Value, string_3.Trim, False) Then
                Me.MetroGrid1.Rows.Item(num2).Cells.Item(1).Value = string_4
                If (string_4 = "Online") Then
                    Me.MetroGrid1.Rows.Item(num2).DefaultCellStyle.BackColor = Color.GreenYellow
                End If
                If (string_4 = "Offline") Then
                    Me.MetroGrid1.Rows.Item(num2).DefaultCellStyle.BackColor = Color.Red
                End If
            End If
            num2 += 1
        Loop
        Dim num4 As Integer = (Me.list_1.Count - 1)
        num2 = 0
        Do While (num2 <= num4)
            Application.DoEvents()

            If (Me.list_1.Item(num2).url = string_3.Trim) Then
                Me.list_1.Item(num2).status = string_4
            End If
            num2 += 1
        Loop
    End Sub
    Public Function method_5(ByVal string_3 As String) As String
        Dim str As String = Nothing
        Dim num As Integer = 0
        Do While True
            Try
                num += 1
                Dim request As HttpWebRequest = DirectCast(WebRequest.Create(string_3), HttpWebRequest)
                request.Timeout = Me.int_2
                request.ReadWriteTimeout = Me.int_2
                request.Method = "GET"
                request.Proxy = WebRequest.DefaultWebProxy
                request.ContentType = "application/x-www-form-urlencoded"
                request.KeepAlive = True
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; Win64; x64;) Gecko/20100101 Firefox/20.0"
                Dim httpRequestCachePolicy As System.Net.Cache.HttpRequestCachePolicy = New System.Net.Cache.HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore)
                request.AllowAutoRedirect = True
                Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)
                Dim buffer As Char() = New Char(&H801 - 1) {}
                Dim reader As New StreamReader(response.GetResponseStream)
                reader.Read(buffer, 0, (buffer.Length - 1))
                str = New String(buffer)
                response.Close()
                reader.Close()
                str = str.Replace(ChrW(0), "").Trim
                If (str.Length = 0) Then
                    Return "Offline"
                End If
                If (((str.ToLower.Contains("html") Or str.ToLower.Contains("found")) Or str.ToLower.Contains("error")) Or str.ToLower.Contains("authorized")) Then
                    Return "Offline"
                End If
                Return "Online"
            Catch exception1 As Exception
                If (num < 5) Then
                    Thread.Sleep(&H3E8)
                Else
                    Return "Offline"
                End If
            End Try
        Loop
    End Function

    Private Sub method_7()
        Do While Not Me.concurrentQueue_0.IsEmpty
            Dim str As String = Nothing
            Me.concurrentQueue_0.TryDequeue(str)
            Dim str2 As String = Nothing
            str2 = Me.method_5(str)
            Me.method_2(str, str2)
        Loop
        Me.list_2.RemoveAt(0)
    End Sub

    Private Sub MetroGrid1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MetroGrid1.CellMouseDoubleClick
        If (Me.string_0 <> Nothing) Then
            Process.Start(Me.string_0, Conversions.ToString(Me.MetroGrid1.CurrentRow.Cells.Item(2).Value))
        Else
            MsgBox("No VLC Detected on your system.", MsgBoxStyle.Critical, Nothing)
        End If
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Me.int_1 = Convert.ToInt32(Me.NumericUpDown1.Value)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        Me.int_2 = Convert.ToInt32(Decimal.Multiply(Me.NumericUpDown2.Value, 1000))
    End Sub

    Private Sub OpenWithVLCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenWithVLCToolStripMenuItem.Click
        If (Me.string_0 <> Nothing) Then
            Process.Start(Me.string_0, Conversions.ToString(Me.MetroGrid1.CurrentRow.Cells.Item(2).Value))
        Else
            Interaction.MsgBox("No VLC Detected on your system.", MsgBoxStyle.Critical, Nothing)
        End If
    End Sub
    Private Sub radio_all_CheckedChanged(sender As Object, e As EventArgs) Handles radio_all.CheckedChanged
        If Me.radio_all.Checked Then
            Me.MetroGrid1.Rows.Clear()
            Dim num As Integer = (Me.list_1.Count - 1)
            Dim i As Integer = 0
            Do While (i <= num)
                Application.DoEvents()
                Dim class2 As Class9 = Me.list_1.Item(i)
                Me.method_1(class2)
                i += 1
            Loop
            Me.Label1.Text = ("Channels Found: " & Conversions.ToString(Me.MetroGrid1.Rows.Count))
        End If
    End Sub

    Private Sub radio_offline_CheckedChanged(sender As Object, e As EventArgs) Handles radio_offline.CheckedChanged
        If Me.radio_offline.Checked Then
            Me.MetroGrid1.Rows.Clear()
            Dim num As Integer = (Me.list_1.Count - 1)
            Dim i As Integer = 0
            Do While (i <= num)
                Application.DoEvents()
                Dim class2 As Class9 = Me.list_1.Item(i)
                If (class2.status = "Offline") Then
                    Me.method_1(class2)
                End If
                i += 1
            Loop
            Me.Label1.Text = ("Channels Found: " & Conversions.ToString(Me.MetroGrid1.Rows.Count))
        End If
    End Sub

    Private Sub radio_online_CheckedChanged(sender As Object, e As EventArgs) Handles radio_online.CheckedChanged
        If Me.radio_online.Checked Then
            Me.MetroGrid1.Rows.Clear()
            Dim num As Integer = (Me.list_1.Count - 1)
            Dim i As Integer = 0
            Do While (i <= num)
                Application.DoEvents()
                Dim class2 As Class9 = Me.list_1.Item(i)
                If (class2.status = "Online") Then
                    Me.method_1(class2)
                End If
                i += 1
            Loop
            Me.Label1.Text = ("Channels Found: " & Conversions.ToString(Me.MetroGrid1.Rows.Count))
        End If
    End Sub

    Private Sub RenameChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameChannelToolStripMenuItem.Click
        Dim str As String = Interaction.InputBox("Enter New Channel Name", "Modify Channel Name", Conversions.ToString(Me.MetroGrid1.CurrentRow.Cells.Item(0).Value), -1, -1)
        If (str <> Nothing) Then
            Me.MetroGrid1.CurrentRow.Cells.Item(0).Value = str
        End If
    End Sub


    Friend Class Class7
        Public Sub New(ByVal other As Class7)
            If (Not other Is Nothing) Then
                Me.class9_0 = other.class9_0
            End If
        End Sub
        Public Function method_0(ByVal class9_1 As Class9) As Boolean
            Return (class9_1.url = Me.class9_0.url)
        End Function

        Public class9_0 As Class9
    End Class

    Friend Class Class8

        Public Sub New(ByVal other As Class8)
            If (Not other Is Nothing) Then
                Me.class9_0 = other.class9_0
            End If
        End Sub
        Public Function method_0(ByVal class9_1 As Class9) As Boolean
            Return (class9_1.url = Me.class9_0.url)
        End Function


        Public class9_0 As Class9
    End Class

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        MsgBox("SUPP ME IF YOU LIKE IT")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://discord.gg/benEH43utw")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.youtube.com/channel/UCLF-eRNc52VslhdctpHaAzg")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://t.me/MONSTERMCSY")
    End Sub

End Class
