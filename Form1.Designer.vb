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
        dtvMatrizPrincipal = New DataGridView()
        dtvNuevaMatriz = New DataGridView()
        dtvVector = New DataGridView()
        cmdEjecutar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(dtvMatrizPrincipal, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvNuevaMatriz, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvVector, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtvMatrizPrincipal
        ' 
        dtvMatrizPrincipal.BackgroundColor = SystemColors.GradientActiveCaption
        dtvMatrizPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvMatrizPrincipal.Location = New Point(12, 73)
        dtvMatrizPrincipal.Name = "dtvMatrizPrincipal"
        dtvMatrizPrincipal.RowHeadersWidth = 51
        dtvMatrizPrincipal.Size = New Size(349, 257)
        dtvMatrizPrincipal.TabIndex = 0
        ' 
        ' dtvNuevaMatriz
        ' 
        dtvNuevaMatriz.BackgroundColor = SystemColors.GradientActiveCaption
        dtvNuevaMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvNuevaMatriz.Location = New Point(432, 73)
        dtvNuevaMatriz.Name = "dtvNuevaMatriz"
        dtvNuevaMatriz.RowHeadersWidth = 51
        dtvNuevaMatriz.Size = New Size(210, 165)
        dtvNuevaMatriz.TabIndex = 1
        ' 
        ' dtvVector
        ' 
        dtvVector.BackgroundColor = SystemColors.GradientActiveCaption
        dtvVector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvVector.Location = New Point(12, 434)
        dtvVector.Name = "dtvVector"
        dtvVector.RowHeadersWidth = 51
        dtvVector.Size = New Size(277, 71)
        dtvVector.TabIndex = 2
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.BackColor = SystemColors.MenuHighlight
        cmdEjecutar.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        cmdEjecutar.Location = New Point(432, 434)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(210, 71)
        cmdEjecutar.TabIndex = 3
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(12, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 32)
        Label1.TabIndex = 5
        Label1.Text = "Matriz Principal"
        Label1.UseMnemonic = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.Location = New Point(432, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 32)
        Label2.TabIndex = 6
        Label2.Text = "Nueva Matriz"
        Label2.UseMnemonic = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label3.Location = New Point(12, 378)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 32)
        Label3.TabIndex = 7
        Label3.Text = "Vector Solicitado"
        Label3.UseMnemonic = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(658, 517)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmdEjecutar)
        Controls.Add(dtvVector)
        Controls.Add(dtvNuevaMatriz)
        Controls.Add(dtvMatrizPrincipal)
        Name = "Form1"
        Text = "Matrices y Vectores"
        CType(dtvMatrizPrincipal, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvNuevaMatriz, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvVector, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtvMatrizPrincipal As DataGridView
    Friend WithEvents dtvNuevaMatriz As DataGridView
    Friend WithEvents dtvVector As DataGridView
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
