﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.17929
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace EditorServicio
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="DEditor", [Namespace]:="http://schemas.datacontract.org/2004/07/ServiciosWeb"),  _
     System.SerializableAttribute()>  _
    Partial Public Class DEditor
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DescripcionField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private IdEditorField As System.Guid
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Descripcion() As String
            Get
                Return Me.DescripcionField
            End Get
            Set
                If (Object.ReferenceEquals(Me.DescripcionField, value) <> true) Then
                    Me.DescripcionField = value
                    Me.RaisePropertyChanged("Descripcion")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IdEditor() As System.Guid
            Get
                Return Me.IdEditorField
            End Get
            Set
                If (Me.IdEditorField.Equals(value) <> true) Then
                    Me.IdEditorField = value
                    Me.RaisePropertyChanged("IdEditor")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="EditorServicio.IEditorServicio")>  _
    Public Interface IEditorServicio
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/DoWork", ReplyAction:="http://tempuri.org/IEditorServicio/DoWorkResponse")>  _
        Sub DoWork()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/DoWork", ReplyAction:="http://tempuri.org/IEditorServicio/DoWorkResponse")>  _
        Function DoWorkAsync() As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Guardar", ReplyAction:="http://tempuri.org/IEditorServicio/GuardarResponse")>  _
        Sub Guardar(ByVal Editor As EditorServicio.DEditor)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Guardar", ReplyAction:="http://tempuri.org/IEditorServicio/GuardarResponse")>  _
        Function GuardarAsync(ByVal Editor As EditorServicio.DEditor) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Lista", ReplyAction:="http://tempuri.org/IEditorServicio/ListaResponse")>  _
        Function Lista() As System.Collections.Generic.List(Of EditorServicio.DEditor)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Lista", ReplyAction:="http://tempuri.org/IEditorServicio/ListaResponse")>  _
        Function ListaAsync() As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of EditorServicio.DEditor))
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Editar", ReplyAction:="http://tempuri.org/IEditorServicio/EditarResponse")>  _
        Sub Editar(ByVal Editor As EditorServicio.DEditor)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Editar", ReplyAction:="http://tempuri.org/IEditorServicio/EditarResponse")>  _
        Function EditarAsync(ByVal Editor As EditorServicio.DEditor) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Eliminar", ReplyAction:="http://tempuri.org/IEditorServicio/EliminarResponse")>  _
        Sub Eliminar(ByVal IdEditor As System.Guid)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Eliminar", ReplyAction:="http://tempuri.org/IEditorServicio/EliminarResponse")>  _
        Function EliminarAsync(ByVal IdEditor As System.Guid) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/BuscarPorId", ReplyAction:="http://tempuri.org/IEditorServicio/BuscarPorIdResponse")>  _
        Function BuscarPorId(ByVal IdEditor As System.Guid) As EditorServicio.DEditor
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/BuscarPorId", ReplyAction:="http://tempuri.org/IEditorServicio/BuscarPorIdResponse")>  _
        Function BuscarPorIdAsync(ByVal IdEditor As System.Guid) As System.Threading.Tasks.Task(Of EditorServicio.DEditor)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Busqueda", ReplyAction:="http://tempuri.org/IEditorServicio/BusquedaResponse")>  _
        Function Busqueda(ByVal Descripcion As String) As System.Collections.Generic.List(Of EditorServicio.DEditor)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Busqueda", ReplyAction:="http://tempuri.org/IEditorServicio/BusquedaResponse")>  _
        Function BusquedaAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of EditorServicio.DEditor))
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/BuscarPorDescripcion", ReplyAction:="http://tempuri.org/IEditorServicio/BuscarPorDescripcionResponse")>  _
        Function BuscarPorDescripcion(ByVal Descripcion As String) As EditorServicio.DEditor
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/BuscarPorDescripcion", ReplyAction:="http://tempuri.org/IEditorServicio/BuscarPorDescripcionResponse")>  _
        Function BuscarPorDescripcionAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of EditorServicio.DEditor)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Existe", ReplyAction:="http://tempuri.org/IEditorServicio/ExisteResponse")>  _
        Function Existe(ByVal Descripcion As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEditorServicio/Existe", ReplyAction:="http://tempuri.org/IEditorServicio/ExisteResponse")>  _
        Function ExisteAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of Boolean)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IEditorServicioChannel
        Inherits EditorServicio.IEditorServicio, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class EditorServicioClient
        Inherits System.ServiceModel.ClientBase(Of EditorServicio.IEditorServicio)
        Implements EditorServicio.IEditorServicio
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Sub DoWork() Implements EditorServicio.IEditorServicio.DoWork
            MyBase.Channel.DoWork
        End Sub
        
        Public Function DoWorkAsync() As System.Threading.Tasks.Task Implements EditorServicio.IEditorServicio.DoWorkAsync
            Return MyBase.Channel.DoWorkAsync
        End Function
        
        Public Sub Guardar(ByVal Editor As EditorServicio.DEditor) Implements EditorServicio.IEditorServicio.Guardar
            MyBase.Channel.Guardar(Editor)
        End Sub
        
        Public Function GuardarAsync(ByVal Editor As EditorServicio.DEditor) As System.Threading.Tasks.Task Implements EditorServicio.IEditorServicio.GuardarAsync
            Return MyBase.Channel.GuardarAsync(Editor)
        End Function
        
        Public Function Lista() As System.Collections.Generic.List(Of EditorServicio.DEditor) Implements EditorServicio.IEditorServicio.Lista
            Return MyBase.Channel.Lista
        End Function
        
        Public Function ListaAsync() As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of EditorServicio.DEditor)) Implements EditorServicio.IEditorServicio.ListaAsync
            Return MyBase.Channel.ListaAsync
        End Function
        
        Public Sub Editar(ByVal Editor As EditorServicio.DEditor) Implements EditorServicio.IEditorServicio.Editar
            MyBase.Channel.Editar(Editor)
        End Sub
        
        Public Function EditarAsync(ByVal Editor As EditorServicio.DEditor) As System.Threading.Tasks.Task Implements EditorServicio.IEditorServicio.EditarAsync
            Return MyBase.Channel.EditarAsync(Editor)
        End Function
        
        Public Sub Eliminar(ByVal IdEditor As System.Guid) Implements EditorServicio.IEditorServicio.Eliminar
            MyBase.Channel.Eliminar(IdEditor)
        End Sub
        
        Public Function EliminarAsync(ByVal IdEditor As System.Guid) As System.Threading.Tasks.Task Implements EditorServicio.IEditorServicio.EliminarAsync
            Return MyBase.Channel.EliminarAsync(IdEditor)
        End Function
        
        Public Function BuscarPorId(ByVal IdEditor As System.Guid) As EditorServicio.DEditor Implements EditorServicio.IEditorServicio.BuscarPorId
            Return MyBase.Channel.BuscarPorId(IdEditor)
        End Function
        
        Public Function BuscarPorIdAsync(ByVal IdEditor As System.Guid) As System.Threading.Tasks.Task(Of EditorServicio.DEditor) Implements EditorServicio.IEditorServicio.BuscarPorIdAsync
            Return MyBase.Channel.BuscarPorIdAsync(IdEditor)
        End Function
        
        Public Function Busqueda(ByVal Descripcion As String) As System.Collections.Generic.List(Of EditorServicio.DEditor) Implements EditorServicio.IEditorServicio.Busqueda
            Return MyBase.Channel.Busqueda(Descripcion)
        End Function
        
        Public Function BusquedaAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of EditorServicio.DEditor)) Implements EditorServicio.IEditorServicio.BusquedaAsync
            Return MyBase.Channel.BusquedaAsync(Descripcion)
        End Function
        
        Public Function BuscarPorDescripcion(ByVal Descripcion As String) As EditorServicio.DEditor Implements EditorServicio.IEditorServicio.BuscarPorDescripcion
            Return MyBase.Channel.BuscarPorDescripcion(Descripcion)
        End Function
        
        Public Function BuscarPorDescripcionAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of EditorServicio.DEditor) Implements EditorServicio.IEditorServicio.BuscarPorDescripcionAsync
            Return MyBase.Channel.BuscarPorDescripcionAsync(Descripcion)
        End Function
        
        Public Function Existe(ByVal Descripcion As String) As Boolean Implements EditorServicio.IEditorServicio.Existe
            Return MyBase.Channel.Existe(Descripcion)
        End Function
        
        Public Function ExisteAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of Boolean) Implements EditorServicio.IEditorServicio.ExisteAsync
            Return MyBase.Channel.ExisteAsync(Descripcion)
        End Function
    End Class
End Namespace
