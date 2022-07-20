<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a176426
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
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_products = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(340, 396)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(123, 27)
        Me.btn_exit.TabIndex = 0
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_products
        '
        Me.btn_products.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_products.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_products.Location = New System.Drawing.Point(331, 169)
        Me.btn_products.Name = "btn_products"
        Me.btn_products.Size = New System.Drawing.Size(142, 33)
        Me.btn_products.TabIndex = 1
        Me.btn_products.Text = "PRODUCTS"
        Me.btn_products.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_staff.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(331, 316)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(142, 33)
        Me.btn_staff.TabIndex = 2
        Me.btn_staff.Text = "STAFF"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_orders.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orders.Location = New System.Drawing.Point(331, 219)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(142, 33)
        Me.btn_orders.TabIndex = 3
        Me.btn_orders.Text = "ORDERS"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'btn_customers
        '
        Me.btn_customers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_customers.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customers.Location = New System.Drawing.Point(331, 267)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Size = New System.Drawing.Size(142, 33)
        Me.btn_customers.TabIndex = 4
        Me.btn_customers.Text = "CUSTOMERS"
        Me.btn_customers.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(237, 51)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(362, 60)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "VegeFruit Garden"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 34)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "- MAIN MENU -"
        '
        'frm_mainmenu_a176426
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_vegefruitgarden_a176426.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_customers)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_products)
        Me.Controls.Add(Me.btn_exit)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.Name = "frm_mainmenu_a176426"
        Me.Text = "VegeFruit Garden - Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_products As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents Label1 As Label
End Class
