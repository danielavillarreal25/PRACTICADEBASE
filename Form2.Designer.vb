﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.btnMostrarCompras = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCompras
        '
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Location = New System.Drawing.Point(53, 219)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.Size = New System.Drawing.Size(696, 207)
        Me.dgvCompras.TabIndex = 0
        '
        'btnMostrarCompras
        '
        Me.btnMostrarCompras.Location = New System.Drawing.Point(341, 148)
        Me.btnMostrarCompras.Name = "btnMostrarCompras"
        Me.btnMostrarCompras.Size = New System.Drawing.Size(121, 48)
        Me.btnMostrarCompras.TabIndex = 1
        Me.btnMostrarCompras.Text = "Mostrar"
        Me.btnMostrarCompras.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Compras y saldos pendientes"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMostrarCompras)
        Me.Controls.Add(Me.dgvCompras)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents btnMostrarCompras As Button
    Friend WithEvents Label1 As Label
End Class
