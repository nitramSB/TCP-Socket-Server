<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Admin")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UptimeLabel = New System.Windows.Forms.Label()
        Me.TotalConnectionsLabel = New System.Windows.Forms.Label()
        Me.ActiveConnectionsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PublicCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrivateCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListViewPrivate = New System.Windows.Forms.ListView()
        Me.KickButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBoxTriedToConnect = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BanIPTextbox = New System.Windows.Forms.TextBox()
        Me.AddBlockedManual = New System.Windows.Forms.Button()
        Me.UnblockButton = New System.Windows.Forms.Button()
        Me.ListViewBlocked = New System.Windows.Forms.ListView()
        Me.BlockButton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListViewActive = New System.Windows.Forms.ListView()
        Me.PublicChat = New System.Windows.Forms.RichTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.Uptime = New System.Windows.Forms.Timer(Me.components)
        Me.ReplyPublic = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaxLines = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UpdateSocketList = New System.Windows.Forms.Timer(Me.components)
        Me.ListViewTaken = New System.Windows.Forms.ListView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.KickUser = New System.Windows.Forms.Button()
        Me.Usernames = New System.Windows.Forms.Timer(Me.components)
        Me.ClearChat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UptimeLabel)
        Me.GroupBox1.Controls.Add(Me.TotalConnectionsLabel)
        Me.GroupBox1.Controls.Add(Me.ActiveConnectionsLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(282, 156)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'UptimeLabel
        '
        Me.UptimeLabel.AutoSize = True
        Me.UptimeLabel.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UptimeLabel.Location = New System.Drawing.Point(179, 106)
        Me.UptimeLabel.Name = "UptimeLabel"
        Me.UptimeLabel.Size = New System.Drawing.Size(18, 22)
        Me.UptimeLabel.TabIndex = 10
        Me.UptimeLabel.Text = "0"
        '
        'TotalConnectionsLabel
        '
        Me.TotalConnectionsLabel.AutoSize = True
        Me.TotalConnectionsLabel.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalConnectionsLabel.Location = New System.Drawing.Point(155, 72)
        Me.TotalConnectionsLabel.Name = "TotalConnectionsLabel"
        Me.TotalConnectionsLabel.Size = New System.Drawing.Size(18, 22)
        Me.TotalConnectionsLabel.TabIndex = 9
        Me.TotalConnectionsLabel.Text = "0"
        '
        'ActiveConnectionsLabel
        '
        Me.ActiveConnectionsLabel.AutoSize = True
        Me.ActiveConnectionsLabel.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveConnectionsLabel.Location = New System.Drawing.Point(246, 39)
        Me.ActiveConnectionsLabel.Name = "ActiveConnectionsLabel"
        Me.ActiveConnectionsLabel.Size = New System.Drawing.Size(18, 22)
        Me.ActiveConnectionsLabel.TabIndex = 8
        Me.ActiveConnectionsLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Service Uptime (min):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total connections:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of active connections:"
        '
        'PublicCheckBox
        '
        Me.PublicCheckBox.AutoSize = True
        Me.PublicCheckBox.Checked = True
        Me.PublicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PublicCheckBox.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicCheckBox.Location = New System.Drawing.Point(26, 40)
        Me.PublicCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PublicCheckBox.Name = "PublicCheckBox"
        Me.PublicCheckBox.Size = New System.Drawing.Size(188, 26)
        Me.PublicCheckBox.TabIndex = 4
        Me.PublicCheckBox.Text = "Public Chat Enabled"
        Me.PublicCheckBox.UseVisualStyleBackColor = True
        '
        'PrivateCheckBox
        '
        Me.PrivateCheckBox.AutoSize = True
        Me.PrivateCheckBox.Checked = True
        Me.PrivateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PrivateCheckBox.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrivateCheckBox.Location = New System.Drawing.Point(26, 76)
        Me.PrivateCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrivateCheckBox.Name = "PrivateCheckBox"
        Me.PrivateCheckBox.Size = New System.Drawing.Size(194, 26)
        Me.PrivateCheckBox.TabIndex = 5
        Me.PrivateCheckBox.Text = "Private Chat Enabled"
        Me.PrivateCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PublicCheckBox)
        Me.GroupBox2.Controls.Add(Me.PrivateCheckBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 179)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(282, 240)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action Pane"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListViewPrivate)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(316, 15)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(335, 404)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Private Chat Connections"
        '
        'ListViewPrivate
        '
        Me.ListViewPrivate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListViewPrivate.Location = New System.Drawing.Point(25, 39)
        Me.ListViewPrivate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewPrivate.Name = "ListViewPrivate"
        Me.ListViewPrivate.Size = New System.Drawing.Size(284, 343)
        Me.ListViewPrivate.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewPrivate.TabIndex = 23
        Me.ListViewPrivate.UseCompatibleStateImageBehavior = False
        Me.ListViewPrivate.View = System.Windows.Forms.View.List
        '
        'KickButton
        '
        Me.KickButton.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KickButton.Location = New System.Drawing.Point(24, 351)
        Me.KickButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KickButton.Name = "KickButton"
        Me.KickButton.Size = New System.Drawing.Size(110, 38)
        Me.KickButton.TabIndex = 16
        Me.KickButton.Text = "Kick"
        Me.KickButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListBoxTriedToConnect)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.BanIPTextbox)
        Me.GroupBox4.Controls.Add(Me.AddBlockedManual)
        Me.GroupBox4.Controls.Add(Me.UnblockButton)
        Me.GroupBox4.Controls.Add(Me.ListViewBlocked)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1000, 15)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(342, 502)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Blocked IP's"
        '
        'ListBoxTriedToConnect
        '
        Me.ListBoxTriedToConnect.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTriedToConnect.FormattingEnabled = True
        Me.ListBoxTriedToConnect.ItemHeight = 22
        Me.ListBoxTriedToConnect.Location = New System.Drawing.Point(23, 268)
        Me.ListBoxTriedToConnect.Name = "ListBoxTriedToConnect"
        Me.ListBoxTriedToConnect.Size = New System.Drawing.Size(285, 114)
        Me.ListBoxTriedToConnect.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Tried to connect:"
        '
        'BanIPTextbox
        '
        Me.BanIPTextbox.Location = New System.Drawing.Point(24, 396)
        Me.BanIPTextbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BanIPTextbox.Multiline = True
        Me.BanIPTextbox.Name = "BanIPTextbox"
        Me.BanIPTextbox.Size = New System.Drawing.Size(127, 36)
        Me.BanIPTextbox.TabIndex = 27
        Me.BanIPTextbox.Text = "127.0.0.1"
        '
        'AddBlockedManual
        '
        Me.AddBlockedManual.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBlockedManual.Location = New System.Drawing.Point(158, 396)
        Me.AddBlockedManual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddBlockedManual.Name = "AddBlockedManual"
        Me.AddBlockedManual.Size = New System.Drawing.Size(151, 38)
        Me.AddBlockedManual.TabIndex = 24
        Me.AddBlockedManual.Text = "Add IP Address"
        Me.AddBlockedManual.UseVisualStyleBackColor = True
        '
        'UnblockButton
        '
        Me.UnblockButton.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnblockButton.Location = New System.Drawing.Point(24, 441)
        Me.UnblockButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UnblockButton.Name = "UnblockButton"
        Me.UnblockButton.Size = New System.Drawing.Size(285, 38)
        Me.UnblockButton.TabIndex = 9
        Me.UnblockButton.Text = "Remove blocked IP from list"
        Me.UnblockButton.UseVisualStyleBackColor = True
        '
        'ListViewBlocked
        '
        Me.ListViewBlocked.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListViewBlocked.Location = New System.Drawing.Point(24, 39)
        Me.ListViewBlocked.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewBlocked.Name = "ListViewBlocked"
        Me.ListViewBlocked.Size = New System.Drawing.Size(284, 193)
        Me.ListViewBlocked.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewBlocked.TabIndex = 23
        Me.ListViewBlocked.UseCompatibleStateImageBehavior = False
        Me.ListViewBlocked.View = System.Windows.Forms.View.List
        '
        'BlockButton
        '
        Me.BlockButton.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlockButton.Location = New System.Drawing.Point(140, 351)
        Me.BlockButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BlockButton.Name = "BlockButton"
        Me.BlockButton.Size = New System.Drawing.Size(168, 38)
        Me.BlockButton.TabIndex = 14
        Me.BlockButton.Text = "Block selected IP"
        Me.BlockButton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.KickButton)
        Me.GroupBox5.Controls.Add(Me.ListViewActive)
        Me.GroupBox5.Controls.Add(Me.BlockButton)
        Me.GroupBox5.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(658, 15)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(335, 404)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "All active connections to server"
        '
        'ListViewActive
        '
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        Me.ListViewActive.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.ListViewActive.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListViewActive.Location = New System.Drawing.Point(24, 39)
        Me.ListViewActive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewActive.Name = "ListViewActive"
        Me.ListViewActive.Size = New System.Drawing.Size(284, 296)
        Me.ListViewActive.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewActive.TabIndex = 22
        Me.ListViewActive.UseCompatibleStateImageBehavior = False
        Me.ListViewActive.View = System.Windows.Forms.View.List
        '
        'PublicChat
        '
        Me.PublicChat.Location = New System.Drawing.Point(14, 475)
        Me.PublicChat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PublicChat.Name = "PublicChat"
        Me.PublicChat.Size = New System.Drawing.Size(637, 135)
        Me.PublicChat.TabIndex = 17
        Me.PublicChat.Text = "Admin# Welcome to Anonychat!"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 426)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(198, 36)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Public Chat"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(14, 702)
        Me.SendButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(637, 48)
        Me.SendButton.TabIndex = 20
        Me.SendButton.Text = "Send Response"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'Uptime
        '
        Me.Uptime.Enabled = True
        Me.Uptime.Interval = 60000
        '
        'ReplyPublic
        '
        Me.ReplyPublic.Location = New System.Drawing.Point(14, 646)
        Me.ReplyPublic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReplyPublic.Name = "ReplyPublic"
        Me.ReplyPublic.Size = New System.Drawing.Size(637, 48)
        Me.ReplyPublic.TabIndex = 22
        Me.ReplyPublic.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 619)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Reply"
        '
        'StatusTimer
        '
        Me.StatusTimer.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Users online"
        '
        'MaxLines
        '
        Me.MaxLines.Enabled = True
        Me.MaxLines.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1065, 610)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UpdateSocketList
        '
        Me.UpdateSocketList.Enabled = True
        Me.UpdateSocketList.Interval = 1000
        '
        'ListViewTaken
        '
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup1"
        Me.ListViewTaken.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup2})
        Me.ListViewTaken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListViewTaken.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListViewTaken.Location = New System.Drawing.Point(12, 52)
        Me.ListViewTaken.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewTaken.Name = "ListViewTaken"
        Me.ListViewTaken.Size = New System.Drawing.Size(270, 158)
        Me.ListViewTaken.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewTaken.TabIndex = 23
        Me.ListViewTaken.UseCompatibleStateImageBehavior = False
        Me.ListViewTaken.View = System.Windows.Forms.View.List
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.KickUser)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.ListViewTaken)
        Me.GroupBox6.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(670, 475)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(296, 275)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Users"
        '
        'KickUser
        '
        Me.KickUser.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KickUser.Location = New System.Drawing.Point(12, 218)
        Me.KickUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KickUser.Name = "KickUser"
        Me.KickUser.Size = New System.Drawing.Size(270, 36)
        Me.KickUser.TabIndex = 31
        Me.KickUser.Text = "Kick User"
        Me.KickUser.UseVisualStyleBackColor = True
        '
        'Usernames
        '
        Me.Usernames.Enabled = True
        Me.Usernames.Interval = 1000
        '
        'ClearChat
        '
        Me.ClearChat.Location = New System.Drawing.Point(218, 426)
        Me.ClearChat.Name = "ClearChat"
        Me.ClearChat.Size = New System.Drawing.Size(134, 36)
        Me.ClearChat.TabIndex = 30
        Me.ClearChat.Text = "Clear Chat"
        Me.ClearChat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.SendButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1359, 874)
        Me.Controls.Add(Me.ClearChat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReplyPublic)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PublicChat)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnonyChat Server Software"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ActiveConnectionsLabel As System.Windows.Forms.Label
    Friend WithEvents UptimeLabel As System.Windows.Forms.Label
    Friend WithEvents TotalConnectionsLabel As System.Windows.Forms.Label
    Friend WithEvents PublicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PrivateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents UnblockButton As System.Windows.Forms.Button
    Friend WithEvents BlockButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents KickButton As System.Windows.Forms.Button
    Friend WithEvents PublicChat As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SendButton As System.Windows.Forms.Button
    Friend WithEvents Uptime As System.Windows.Forms.Timer
    Friend WithEvents ListViewActive As System.Windows.Forms.ListView
    Friend WithEvents ListViewBlocked As System.Windows.Forms.ListView
    Friend WithEvents ListViewPrivate As System.Windows.Forms.ListView
    Friend WithEvents ReplyPublic As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusTimer As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaxLines As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UpdateSocketList As System.Windows.Forms.Timer
    Friend WithEvents BanIPTextbox As System.Windows.Forms.TextBox
    Friend WithEvents AddBlockedManual As System.Windows.Forms.Button
    Friend WithEvents ListViewTaken As System.Windows.Forms.ListView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBoxTriedToConnect As System.Windows.Forms.ListBox
    Friend WithEvents Usernames As System.Windows.Forms.Timer
    Friend WithEvents ClearChat As System.Windows.Forms.Button
    Friend WithEvents KickUser As System.Windows.Forms.Button

End Class
