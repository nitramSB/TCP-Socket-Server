Imports System.Net, System.Net.Sockets
Public Class Form1
    Dim serverSocket As Socket
    Dim clientSocket As Socket
    Dim byteData(1023) As Byte


    Dim activecon As Int16
    Dim totalcon As Int16
    Dim uptimecount As Int64


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activecon = 0
        totalcon = 0
        uptimecount = 0

        serverSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim IpEndPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 8800)

        serverSocket.Bind(IpEndPoint)
        serverSocket.Listen(5)
        serverSocket.BeginAccept(New AsyncCallback(AddressOf OnAccept), Nothing)
    End Sub



    Private Sub OnAccept(ByVal ar As IAsyncResult)

        clientSocket = serverSocket.EndAccept(ar)

        serverSocket.BeginAccept(New AsyncCallback(AddressOf OnAccept), Nothing)

        Dim BlockedIP As IPAddress = IPAddress.Parse(CType(clientSocket.RemoteEndPoint, IPEndPoint).Address.ToString())

        For Each IP In BlockedIPs

            If BlockedIP.ToString = IP.ToString Then
                Call TriedToCon(BlockedIP.ToString)

            End If
        Next

        If clientSocket.Connected Then
            AddClient(clientSocket)
        End If



    End Sub
    Delegate Sub _TriedToCon(ByVal BlockedIP As String)

    Private Sub TriedToCon(ByVal BlockedIP As String)
        If InvokeRequired Then
            Invoke(New _TriedToCon(AddressOf TriedToCon), BlockedIP)
            Exit Sub
        End If


        ListBoxTriedToConnect.Items.Add(BlockedIP.ToString & "    " & DateTime.Today.ToString)

        clientSocket.Close()

    End Sub

    Public sockets As New List(Of Socket)()
    Delegate Sub _AddClient(ByVal client As Socket)

    Private Sub AddClient(ByVal client As Socket)
        If InvokeRequired Then
            Invoke(New _AddClient(AddressOf AddClient), client)
            Exit Sub
        End If

        Dim lvi As New ListViewItem(client.RemoteEndPoint.ToString)
        lvi.Tag = client
        ListViewActive.Items.Add(lvi)

        sockets.Add(client)
        Send("socketinformation|" & clientSocket.RemoteEndPoint.ToString, clientSocket)


        activecon = activecon + 1
        totalcon = totalcon + 1

        clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
        New AsyncCallback(AddressOf OnRecieve), clientSocket)
    End Sub


    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Try
            Dim client As Socket = ar.AsyncState
            client.EndReceive(ar)


            Dim bytesRec As Byte() = byteData
            Dim message As String = System.Text.ASCIIEncoding.ASCII.GetString(bytesRec)

            Read(message)


            Array.Clear(byteData, 0, byteData.Length)

            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
           New AsyncCallback(AddressOf OnRecieve), clientSocket)

        Catch ex As Exception

        End Try

    End Sub

    Dim lst As New List(Of String)
    Delegate Sub _Read(ByVal msg As String)
    Private Sub Read(ByVal msg As String)
        If InvokeRequired Then
            Invoke(New _Read(AddressOf Read), msg)
            Exit Sub
        End If

        If msg.StartsWith("username") Then

            Dim MessageArray() As String
            MessageArray = msg.Split("|")
            Dim username As String = MessageArray(1)

            Dim lvi As New ListViewItem
            lvi = ListViewTaken.FindItemWithText(username, True, 0, False)
            If Not lvi Is Nothing Then

                Send("usernamenotapproved", clientSocket)

            Else
                Send("usernameapproved", clientSocket)

                Dim lvi1 As New ListViewItem(username)
                lvi1.Tag = clientSocket
                ListViewTaken.Items.Add(lvi1)

                lst.Add(username)
            End If

        ElseIf msg.StartsWith("update") Then
            Send(PublicChat.Text, clientSocket)

        ElseIf msg.StartsWith("usersonline") Then

            Dim MessageArray() As String
            MessageArray = msg.Split("|")


            Dim socketinfo As String = MessageArray(1).ToString

            Dim intCompare As Int16 = 0

            For Each sc In sockets

                Dim scstring As String = sc.RemoteEndPoint.ToString

                intCompare = StrComp(socketinfo, scstring, vbTextCompare)

                If intCompare = 0 Then
                    Send("usersonline|" & "Admin", sc)
                End If


                ' If socketinfo = scstring Then
                'MsgBox(scstring & "=" & socketinfo)
                ' 
                ' Else
                '  MsgBox("Strings did not match")
                '  End If
            Next



        Else

            PublicChat.Text = PublicChat.Text + vbNewLine & msg
        End If



    End Sub

    Private Sub Send(ByVal msg As String, ByVal client As Socket)

        Dim sendBytes As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(msg)

        client.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, New AsyncCallback(AddressOf OnSend), client)


    End Sub

    Private Sub OnSend(ByVal ar As IAsyncResult)
        Dim client As Socket = ar.AsyncState
        client.EndSend(ar)
    End Sub


    Public BlockedIPs As New List(Of String)()

    Private Sub BlockButton_Click(sender As Object, e As EventArgs) Handles BlockButton.Click
        Try

            Dim blockedsocket As Socket = ListViewActive.SelectedItems(0).Tag

            Dim IP As IPAddress = IPAddress.Parse(CType(blockedsocket.RemoteEndPoint, IPEndPoint).Address.ToString())

            ListViewBlocked.Items.Add(IP.ToString)


            BlockedIPs.Add(IP.ToString)


            Dim lst As New List(Of Object)
            For Each a As Object In ListViewActive.SelectedItems
                lst.Add(a)

            Next
            For Each a As Object In lst
                ListViewActive.Items.Remove(a)
            Next

            blockedsocket.Dispose()
            blockedsocket.Close()

            MsgBox("User has been kicked, and added to banned list")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub KickButton_Click(sender As Object, e As EventArgs) Handles KickButton.Click
        Try

            Dim kicksocket As Socket = ListViewActive.SelectedItems(0).Tag

            kicksocket.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub UnblockButton_Click(sender As Object, e As EventArgs) Handles UnblockButton.Click
        Try

            Dim SelectedItem As ListViewItem = ListViewBlocked.SelectedItems(0)

            SelectedItem.Remove()

            BlockedIPs.Remove(SelectedItem.Text.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        If ReplyPublic.Text = "" Then

        Else
            PublicChat.Text = PublicChat.Text + vbNewLine & "Admin: " & ReplyPublic.Text
            ReplyPublic.Text = ""

        End If
        


    End Sub


    Private Sub Uptime_Tick(sender As Object, e As EventArgs) Handles Uptime.Tick
        uptimecount = uptimecount + 1
        UptimeLabel.Text = uptimecount

    End Sub

  


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            PublicChat.Enabled = False
            ReplyPublic.Enabled = False
            SendButton.Enabled = False

        ElseIf CheckBox1.Checked = True Then
            PublicChat.Enabled = True
            ReplyPublic.Enabled = True
            SendButton.Enabled = True

        End If
    End Sub

    Private Sub StatusTimer_Tick(sender As Object, e As EventArgs) Handles StatusTimer.Tick
        ActiveConnectionsLabel.Text = activecon
        TotalConnectionsLabel.Text = totalcon

    End Sub



    Private Sub UpdateSocketList_Tick(sender As Object, e As EventArgs) Handles UpdateSocketList.Tick

        Try

            For Each lvi As ListViewItem In ListViewActive.Items

                Try
                    Send("heartbeat", lvi.Tag)
                Catch ex As Exception
                    lvi.Remove()
                    activecon = activecon - 1

                End Try
            Next

        Catch ex As Exception

        End Try


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim str As String
        Dim strArr() As String
        Dim count As Integer
        str = "vb.net split test"
        strArr = str.Split(" ")
        For count = 0 To strArr.Length - 1
            MsgBox(strArr(count))
        Next
    End Sub

    Private Sub AddBlockedManual_Click(sender As Object, e As EventArgs) Handles AddBlockedManual.Click
        ListViewBlocked.Items.Add(BanIPTextbox.Text)
        BlockedIPs.Add(BanIPTextbox.Text)
        BanIPTextbox.Text = ""

    End Sub

    Private Sub Usernames_Tick(sender As Object, e As EventArgs) Handles Usernames.Tick

        Try

            For Each lvi As ListViewItem In ListViewTaken.Items

                If lvi.Text = "Admin" Then

                Else

                    Try
                        Send("usernameupdate", lvi.Tag)
                    Catch ex As Exception
                        lvi.Remove()


                    End Try
                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClearChat_Click(sender As Object, e As EventArgs) Handles ClearChat.Click
        PublicChat.Text = "Admin# Welcome to Anonychat!"

    End Sub

    Private Sub KickUser_Click(sender As Object, e As EventArgs) Handles KickUser.Click
        Try

            Dim kicksocket As Socket = ListViewTaken.SelectedItems(0).Tag

            kicksocket.Close()

            MsgBox("User has been kicked!")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


           

        Catch ex As Exception

        End Try
        
    End Sub
End Class
