<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridSiswa = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        TxtNim = New TextBox()
        txtName = New TextBox()
        txtAddress = New TextBox()
        txtNomorTelepon = New TextBox()
        btUpdate = New Button()
        btDelete = New Button()
        cbGender = New ComboBox()
        GroupBox1 = New GroupBox()
        BtCancel = New Button()
        BtAdd = New Button()
        Label5 = New Label()
        Label7 = New Label()
        txtMajor = New TextBox()
        Label8 = New Label()
        CType(DataGridSiswa, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridSiswa
        ' 
        DataGridSiswa.AllowUserToAddRows = False
        DataGridSiswa.AllowUserToDeleteRows = False
        DataGridSiswa.AllowUserToResizeRows = False
        DataGridSiswa.BackgroundColor = SystemColors.Control
        DataGridSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridSiswa.Location = New Point(20, 26)
        DataGridSiswa.Name = "DataGridSiswa"
        DataGridSiswa.ReadOnly = True
        DataGridSiswa.RowHeadersWidth = 51
        DataGridSiswa.Size = New Size(620, 217)
        DataGridSiswa.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 1
        Label1.Text = "NIM*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 2
        Label2.Text = "Name*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 3
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(398, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 4
        Label4.Text = "Phone Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(379, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 6
        Label6.Text = "Gender*"
        ' 
        ' TxtNim
        ' 
        TxtNim.Location = New Point(79, 20)
        TxtNim.MaxLength = 15
        TxtNim.Name = "TxtNim"
        TxtNim.Size = New Size(294, 27)
        TxtNim.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.CharacterCasing = CharacterCasing.Upper
        txtName.Enabled = False
        txtName.Location = New Point(79, 68)
        txtName.Name = "txtName"
        txtName.Size = New Size(294, 27)
        txtName.TabIndex = 8
        ' 
        ' txtAddress
        ' 
        txtAddress.CharacterCasing = CharacterCasing.Upper
        txtAddress.Enabled = False
        txtAddress.Location = New Point(79, 118)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.ScrollBars = ScrollBars.Vertical
        txtAddress.Size = New Size(313, 100)
        txtAddress.TabIndex = 9
        ' 
        ' txtNomorTelepon
        ' 
        txtNomorTelepon.Enabled = False
        txtNomorTelepon.Location = New Point(512, 118)
        txtNomorTelepon.MaxLength = 15
        txtNomorTelepon.Name = "txtNomorTelepon"
        txtNomorTelepon.Size = New Size(268, 27)
        txtNomorTelepon.TabIndex = 10
        ' 
        ' btUpdate
        ' 
        btUpdate.Enabled = False
        btUpdate.Location = New Point(398, 167)
        btUpdate.Name = "btUpdate"
        btUpdate.Size = New Size(221, 49)
        btUpdate.TabIndex = 11
        btUpdate.Text = "Update"
        btUpdate.UseVisualStyleBackColor = True
        ' 
        ' btDelete
        ' 
        btDelete.Enabled = False
        btDelete.Location = New Point(625, 167)
        btDelete.Name = "btDelete"
        btDelete.Size = New Size(155, 49)
        btDelete.TabIndex = 12
        btDelete.Text = "Delete"
        btDelete.UseVisualStyleBackColor = True
        ' 
        ' cbGender
        ' 
        cbGender.Enabled = False
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        cbGender.Location = New Point(448, 68)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(332, 28)
        cbGender.TabIndex = 14
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtCancel)
        GroupBox1.Controls.Add(BtAdd)
        GroupBox1.Controls.Add(DataGridSiswa)
        GroupBox1.Location = New Point(11, 224)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 265)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Table"
        ' 
        ' BtCancel
        ' 
        BtCancel.Enabled = False
        BtCancel.Location = New Point(646, 79)
        BtCancel.Name = "BtCancel"
        BtCancel.Size = New Size(124, 47)
        BtCancel.TabIndex = 2
        BtCancel.Text = "Cancel"
        BtCancel.UseVisualStyleBackColor = True
        ' 
        ' BtAdd
        ' 
        BtAdd.Enabled = False
        BtAdd.Location = New Point(646, 26)
        BtAdd.Name = "BtAdd"
        BtAdd.Size = New Size(124, 47)
        BtAdd.TabIndex = 1
        BtAdd.Text = "Add"
        BtAdd.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Tai Le", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.InactiveCaption
        Label5.Location = New Point(625, 477)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 16)
        Label5.TabIndex = 16
        Label5.Text = "Naufal Nur Hafizh ©️2024"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlDark
        Label7.Location = New Point(655, 148)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 16)
        Label7.TabIndex = 17
        Label7.Text = "* 896xxxxxxxx is valid"
        ' 
        ' txtMajor
        ' 
        txtMajor.CharacterCasing = CharacterCasing.Upper
        txtMajor.Enabled = False
        txtMajor.Location = New Point(448, 20)
        txtMajor.Name = "txtMajor"
        txtMajor.Size = New Size(332, 27)
        txtMajor.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(379, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 20)
        Label8.TabIndex = 20
        Label8.Text = "Major*"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 507)
        Controls.Add(txtMajor)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(cbGender)
        Controls.Add(btDelete)
        Controls.Add(btUpdate)
        Controls.Add(txtNomorTelepon)
        Controls.Add(txtAddress)
        Controls.Add(txtName)
        Controls.Add(TxtNim)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        Text = "Aplikasi Data Siswa"
        CType(DataGridSiswa, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridSiswa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNim As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtNomorTelepon As TextBox
    Friend WithEvents btUpdate As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtCancel As Button
    Friend WithEvents BtAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents Label8 As Label

End Class
