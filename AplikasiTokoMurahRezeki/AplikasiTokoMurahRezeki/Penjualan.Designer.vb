<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.TxtFaktur = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMember = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.TxtKembali = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lb_Harga = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lb_KdPegawai = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lb_Stok = New System.Windows.Forms.Label()
        Me.Lb_HasilStok = New System.Windows.Forms.Label()
        Me.Lb_KodeBarang = New System.Windows.Forms.Label()
        Me.Lb_HasilTotal = New System.Windows.Forms.Label()
        Me.Lb_HasilKembalian = New System.Windows.Forms.Label()
        Me.Lb_PesanDiskon = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lb_Diskon = New System.Windows.Forms.Label()
        Me.LbBayar = New System.Windows.Forms.Label()
        Me.BtnDiskon = New System.Windows.Forms.Button()
        Me.Btn_Cetak = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(66, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 35)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Toko Murah Rezeki"
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(618, 366)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(56, 23)
        Me.BtnBatal.TabIndex = 45
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(680, 366)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(56, 23)
        Me.BtnSave.TabIndex = 44
        Me.BtnSave.Text = "Simpan"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(8, 145)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(728, 218)
        Me.DataGridView1.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TxtQty)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtCari)
        Me.Panel1.Controls.Add(Me.TxtFaktur)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtMember)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtBayar)
        Me.Panel1.Controls.Add(Me.TxtKembali)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(8, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 69)
        Me.Panel1.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(498, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 15)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Qty"
        '
        'TxtQty
        '
        Me.TxtQty.BackColor = System.Drawing.Color.Black
        Me.TxtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQty.ForeColor = System.Drawing.Color.Red
        Me.TxtQty.Location = New System.Drawing.Point(497, 38)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(30, 24)
        Me.TxtQty.TabIndex = 58
        Me.TxtQty.Text = "0"
        Me.TxtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(331, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Cari Produk"
        '
        'TxtCari
        '
        Me.TxtCari.BackColor = System.Drawing.Color.Black
        Me.TxtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCari.ForeColor = System.Drawing.Color.LightBlue
        Me.TxtCari.Location = New System.Drawing.Point(354, 38)
        Me.TxtCari.Multiline = True
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(143, 24)
        Me.TxtCari.TabIndex = 52
        '
        'TxtFaktur
        '
        Me.TxtFaktur.BackColor = System.Drawing.Color.Black
        Me.TxtFaktur.Enabled = False
        Me.TxtFaktur.ForeColor = System.Drawing.Color.LightBlue
        Me.TxtFaktur.Location = New System.Drawing.Point(70, 14)
        Me.TxtFaktur.Name = "TxtFaktur"
        Me.TxtFaktur.Size = New System.Drawing.Size(109, 20)
        Me.TxtFaktur.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(535, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Kembali"
        '
        'TxtMember
        '
        Me.TxtMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtMember.FormattingEnabled = True
        Me.TxtMember.Location = New System.Drawing.Point(69, 40)
        Me.TxtMember.Name = "TxtMember"
        Me.TxtMember.Size = New System.Drawing.Size(110, 21)
        Me.TxtMember.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Faktur"
        '
        'TxtBayar
        '
        Me.TxtBayar.BackColor = System.Drawing.Color.Black
        Me.TxtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBayar.ForeColor = System.Drawing.Color.Red
        Me.TxtBayar.Location = New System.Drawing.Point(589, 8)
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(126, 24)
        Me.TxtBayar.TabIndex = 9
        Me.TxtBayar.Text = "0"
        Me.TxtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtKembali
        '
        Me.TxtKembali.BackColor = System.Drawing.Color.Black
        Me.TxtKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKembali.ForeColor = System.Drawing.Color.Red
        Me.TxtKembali.Location = New System.Drawing.Point(589, 38)
        Me.TxtKembali.Name = "TxtKembali"
        Me.TxtKembali.Size = New System.Drawing.Size(126, 24)
        Me.TxtKembali.TabIndex = 6
        Me.TxtKembali.Text = "0"
        Me.TxtKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Member"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(535, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Bayar"
        '
        'Lb_Harga
        '
        Me.Lb_Harga.AutoSize = True
        Me.Lb_Harga.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Harga.Location = New System.Drawing.Point(93, 54)
        Me.Lb_Harga.Name = "Lb_Harga"
        Me.Lb_Harga.Size = New System.Drawing.Size(14, 15)
        Me.Lb_Harga.TabIndex = 54
        Me.Lb_Harga.Text = "0"
        Me.Lb_Harga.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(545, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "TOTAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Black
        Me.TxtTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Red
        Me.TxtTotal.Location = New System.Drawing.Point(543, 35)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(193, 31)
        Me.TxtTotal.TabIndex = 50
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "User :"
        '
        'Lb_KdPegawai
        '
        Me.Lb_KdPegawai.AutoSize = True
        Me.Lb_KdPegawai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_KdPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lb_KdPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_KdPegawai.Location = New System.Drawing.Point(43, 374)
        Me.Lb_KdPegawai.Name = "Lb_KdPegawai"
        Me.Lb_KdPegawai.Size = New System.Drawing.Size(18, 17)
        Me.Lb_KdPegawai.TabIndex = 55
        Me.Lb_KdPegawai.Text = "..."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Fuchsia
        Me.DateTimePicker1.CustomFormat = "yyyy/mm/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(513, 368)
        Me.DateTimePicker1.MinDate = New Date(1909, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 56
        '
        'Lb_Stok
        '
        Me.Lb_Stok.AutoSize = True
        Me.Lb_Stok.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_Stok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Stok.Location = New System.Drawing.Point(151, 54)
        Me.Lb_Stok.Name = "Lb_Stok"
        Me.Lb_Stok.Size = New System.Drawing.Size(14, 15)
        Me.Lb_Stok.TabIndex = 57
        Me.Lb_Stok.Text = "0"
        Me.Lb_Stok.Visible = False
        '
        'Lb_HasilStok
        '
        Me.Lb_HasilStok.AutoSize = True
        Me.Lb_HasilStok.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_HasilStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_HasilStok.Location = New System.Drawing.Point(206, 54)
        Me.Lb_HasilStok.Name = "Lb_HasilStok"
        Me.Lb_HasilStok.Size = New System.Drawing.Size(14, 15)
        Me.Lb_HasilStok.TabIndex = 58
        Me.Lb_HasilStok.Text = "0"
        Me.Lb_HasilStok.Visible = False
        '
        'Lb_KodeBarang
        '
        Me.Lb_KodeBarang.AutoSize = True
        Me.Lb_KodeBarang.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_KodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_KodeBarang.Location = New System.Drawing.Point(261, 54)
        Me.Lb_KodeBarang.Name = "Lb_KodeBarang"
        Me.Lb_KodeBarang.Size = New System.Drawing.Size(14, 15)
        Me.Lb_KodeBarang.TabIndex = 59
        Me.Lb_KodeBarang.Text = "0"
        Me.Lb_KodeBarang.Visible = False
        '
        'Lb_HasilTotal
        '
        Me.Lb_HasilTotal.AutoSize = True
        Me.Lb_HasilTotal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_HasilTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_HasilTotal.Location = New System.Drawing.Point(635, 17)
        Me.Lb_HasilTotal.Name = "Lb_HasilTotal"
        Me.Lb_HasilTotal.Size = New System.Drawing.Size(14, 15)
        Me.Lb_HasilTotal.TabIndex = 60
        Me.Lb_HasilTotal.Text = "0"
        Me.Lb_HasilTotal.Visible = False
        '
        'Lb_HasilKembalian
        '
        Me.Lb_HasilKembalian.AutoSize = True
        Me.Lb_HasilKembalian.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_HasilKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_HasilKembalian.Location = New System.Drawing.Point(316, 54)
        Me.Lb_HasilKembalian.Name = "Lb_HasilKembalian"
        Me.Lb_HasilKembalian.Size = New System.Drawing.Size(14, 15)
        Me.Lb_HasilKembalian.TabIndex = 61
        Me.Lb_HasilKembalian.Text = "0"
        Me.Lb_HasilKembalian.Visible = False
        '
        'Lb_PesanDiskon
        '
        Me.Lb_PesanDiskon.AutoSize = True
        Me.Lb_PesanDiskon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_PesanDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PesanDiskon.ForeColor = System.Drawing.Color.Yellow
        Me.Lb_PesanDiskon.Location = New System.Drawing.Point(150, 371)
        Me.Lb_PesanDiskon.Name = "Lb_PesanDiskon"
        Me.Lb_PesanDiskon.Size = New System.Drawing.Size(23, 18)
        Me.Lb_PesanDiskon.TabIndex = 62
        Me.Lb_PesanDiskon.Text = "..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(347, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "0"
        Me.Label4.Visible = False
        '
        'Lb_Diskon
        '
        Me.Lb_Diskon.AutoSize = True
        Me.Lb_Diskon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Lb_Diskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Diskon.Location = New System.Drawing.Point(689, 17)
        Me.Lb_Diskon.Name = "Lb_Diskon"
        Me.Lb_Diskon.Size = New System.Drawing.Size(14, 15)
        Me.Lb_Diskon.TabIndex = 64
        Me.Lb_Diskon.Text = "0"
        Me.Lb_Diskon.Visible = False
        '
        'LbBayar
        '
        Me.LbBayar.AutoSize = True
        Me.LbBayar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LbBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBayar.Location = New System.Drawing.Point(422, 54)
        Me.LbBayar.Name = "LbBayar"
        Me.LbBayar.Size = New System.Drawing.Size(14, 15)
        Me.LbBayar.TabIndex = 65
        Me.LbBayar.Text = "0"
        Me.LbBayar.Visible = False
        '
        'BtnDiskon
        '
        Me.BtnDiskon.Location = New System.Drawing.Point(394, 365)
        Me.BtnDiskon.Name = "BtnDiskon"
        Me.BtnDiskon.Size = New System.Drawing.Size(37, 23)
        Me.BtnDiskon.TabIndex = 60
        Me.BtnDiskon.UseVisualStyleBackColor = True
        Me.BtnDiskon.Visible = False
        '
        'Btn_Cetak
        '
        Me.Btn_Cetak.Location = New System.Drawing.Point(437, 366)
        Me.Btn_Cetak.Name = "Btn_Cetak"
        Me.Btn_Cetak.Size = New System.Drawing.Size(70, 23)
        Me.Btn_Cetak.TabIndex = 66
        Me.Btn_Cetak.Text = "Cetak Nota"
        Me.Btn_Cetak.UseVisualStyleBackColor = True
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(748, 394)
        Me.Controls.Add(Me.Btn_Cetak)
        Me.Controls.Add(Me.BtnDiskon)
        Me.Controls.Add(Me.LbBayar)
        Me.Controls.Add(Me.Lb_Diskon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lb_PesanDiskon)
        Me.Controls.Add(Me.Lb_HasilKembalian)
        Me.Controls.Add(Me.Lb_HasilTotal)
        Me.Controls.Add(Me.Lb_KodeBarang)
        Me.Controls.Add(Me.Lb_HasilStok)
        Me.Controls.Add(Me.Lb_Stok)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Lb_Harga)
        Me.Controls.Add(Me.Lb_KdPegawai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtBayar As TextBox
    Friend WithEvents TxtFaktur As TextBox
    Friend WithEvents TxtKembali As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtMember As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Lb_KdPegawai As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Lb_Harga As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtQty As TextBox
    Friend WithEvents Lb_Stok As Label
    Friend WithEvents Lb_HasilStok As Label
    Friend WithEvents Lb_KodeBarang As Label
    Friend WithEvents Lb_HasilTotal As Label
    Friend WithEvents Lb_HasilKembalian As Label
    Friend WithEvents Lb_PesanDiskon As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lb_Diskon As Label
    Friend WithEvents LbBayar As Label
    Friend WithEvents BtnDiskon As Button
    Friend WithEvents Btn_Cetak As Button
End Class
