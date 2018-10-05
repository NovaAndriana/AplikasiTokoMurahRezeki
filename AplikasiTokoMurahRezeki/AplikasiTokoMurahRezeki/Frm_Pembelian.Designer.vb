<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_LapPembelian
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LB_Harga = New System.Windows.Forms.Label()
        Me.LB_HasilTotal = New System.Windows.Forms.Label()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.TxtKodeSupplier = New System.Windows.Forms.ComboBox()
        Me.LB_JumlahStok = New System.Windows.Forms.Label()
        Me.LB_Stok = New System.Windows.Forms.Label()
        Me.LB_Total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.TxtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(80, 126)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(63, 23)
        Me.BtnCancel.TabIndex = 38
        Me.BtnCancel.Text = "Close"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(11, 126)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(63, 23)
        Me.BtnUpdate.TabIndex = 36
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Cari"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(406, 127)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(100, 20)
        Me.TxtCari.TabIndex = 35
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(494, 150)
        Me.DataGridView1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LB_Harga)
        Me.Panel1.Controls.Add(Me.LB_HasilTotal)
        Me.Panel1.Controls.Add(Me.BtnBarang)
        Me.Panel1.Controls.Add(Me.TxtKodeSupplier)
        Me.Panel1.Controls.Add(Me.LB_JumlahStok)
        Me.Panel1.Controls.Add(Me.LB_Stok)
        Me.Panel1.Controls.Add(Me.LB_Total)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtJumlah)
        Me.Panel1.Controls.Add(Me.TxtKodeBarang)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtKode)
        Me.Panel1.Controls.Add(Me.TxtHarga)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 90)
        Me.Panel1.TabIndex = 32
        '
        'LB_Harga
        '
        Me.LB_Harga.AutoSize = True
        Me.LB_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Harga.ForeColor = System.Drawing.Color.SkyBlue
        Me.LB_Harga.Location = New System.Drawing.Point(264, 67)
        Me.LB_Harga.Name = "LB_Harga"
        Me.LB_Harga.Size = New System.Drawing.Size(14, 15)
        Me.LB_Harga.TabIndex = 42
        Me.LB_Harga.Text = "0"
        Me.LB_Harga.Visible = False
        '
        'LB_HasilTotal
        '
        Me.LB_HasilTotal.AutoSize = True
        Me.LB_HasilTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_HasilTotal.ForeColor = System.Drawing.Color.SkyBlue
        Me.LB_HasilTotal.Location = New System.Drawing.Point(422, 8)
        Me.LB_HasilTotal.Name = "LB_HasilTotal"
        Me.LB_HasilTotal.Size = New System.Drawing.Size(16, 15)
        Me.LB_HasilTotal.TabIndex = 41
        Me.LB_HasilTotal.Text = "..."
        Me.LB_HasilTotal.Visible = False
        '
        'BtnBarang
        '
        Me.BtnBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBarang.Location = New System.Drawing.Point(224, 58)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(13, 20)
        Me.BtnBarang.TabIndex = 40
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'TxtKodeSupplier
        '
        Me.TxtKodeSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtKodeSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtKodeSupplier.FormattingEnabled = True
        Me.TxtKodeSupplier.Location = New System.Drawing.Point(125, 32)
        Me.TxtKodeSupplier.Name = "TxtKodeSupplier"
        Me.TxtKodeSupplier.Size = New System.Drawing.Size(110, 21)
        Me.TxtKodeSupplier.TabIndex = 20
        '
        'LB_JumlahStok
        '
        Me.LB_JumlahStok.AutoSize = True
        Me.LB_JumlahStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_JumlahStok.ForeColor = System.Drawing.Color.SkyBlue
        Me.LB_JumlahStok.Location = New System.Drawing.Point(367, 63)
        Me.LB_JumlahStok.Name = "LB_JumlahStok"
        Me.LB_JumlahStok.Size = New System.Drawing.Size(14, 15)
        Me.LB_JumlahStok.TabIndex = 19
        Me.LB_JumlahStok.Text = "0"
        Me.LB_JumlahStok.Visible = False
        '
        'LB_Stok
        '
        Me.LB_Stok.AutoSize = True
        Me.LB_Stok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Stok.ForeColor = System.Drawing.Color.SkyBlue
        Me.LB_Stok.Location = New System.Drawing.Point(347, 63)
        Me.LB_Stok.Name = "LB_Stok"
        Me.LB_Stok.Size = New System.Drawing.Size(14, 15)
        Me.LB_Stok.TabIndex = 18
        Me.LB_Stok.Text = "0"
        Me.LB_Stok.Visible = False
        '
        'LB_Total
        '
        Me.LB_Total.AutoSize = True
        Me.LB_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Total.ForeColor = System.Drawing.Color.SkyBlue
        Me.LB_Total.Location = New System.Drawing.Point(422, 33)
        Me.LB_Total.Name = "LB_Total"
        Me.LB_Total.Size = New System.Drawing.Size(16, 15)
        Me.LB_Total.TabIndex = 17
        Me.LB_Total.Text = "..."
        Me.LB_Total.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Kode Supplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jumlah"
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(318, 9)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(45, 20)
        Me.TxtJumlah.TabIndex = 9
        '
        'TxtKodeBarang
        '
        Me.TxtKodeBarang.Location = New System.Drawing.Point(125, 58)
        Me.TxtKodeBarang.Name = "TxtKodeBarang"
        Me.TxtKodeBarang.Size = New System.Drawing.Size(100, 20)
        Me.TxtKodeBarang.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Harga"
        '
        'TxtKode
        '
        Me.TxtKode.Enabled = False
        Me.TxtKode.Location = New System.Drawing.Point(126, 8)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(109, 20)
        Me.TxtKode.TabIndex = 7
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(318, 39)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(87, 20)
        Me.TxtHarga.TabIndex = 6
        Me.TxtHarga.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Beli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(204, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Data Pembelian"
        '
        'Frm_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(523, 316)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Frm_Pembelian"
        Me.Text = "Data Pembelian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtKodeBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LB_Total As Label
    Friend WithEvents LB_Stok As Label
    Friend WithEvents LB_JumlahStok As Label
    Friend WithEvents TxtKodeSupplier As ComboBox
    Friend WithEvents BtnBarang As Button
    Friend WithEvents LB_HasilTotal As Label
    Friend WithEvents LB_Harga As Label
End Class
